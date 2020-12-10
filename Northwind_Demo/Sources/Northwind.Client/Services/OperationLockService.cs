using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Common.Properties;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.Exceptions;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.DataObjects;
using BusinessFramework.Contracts.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.DataObjects;

namespace NorthWind.Client.Services
{
    public sealed class OperationLockService : IOperationLockService, IDisposable
    {
        private readonly SysOperationLockDao _operationLockDao;
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private Thread _keepAliveThread;
        private readonly List<SysOperationLock> _activeLocks = new List<SysOperationLock>();

        private static readonly object SyncRoot = new object();

        public OperationLockService(IControllerClientFactory clientFactory,
            IMessageBoxService messageBoxService,
            ILogger logger)
        {
            _operationLockDao = new SysOperationLockDao(clientFactory, messageBoxService);
            Logger = logger;
            MessageBoxService = messageBoxService;


            _keepAliveThread = new Thread(UpdateLocks)
            {
                IsBackground = true,
                Name = "OperationLockManager thread"
            };
            _keepAliveThread.Start();
        }
        #region  Dependencies
        private ILogger Logger { get; }
        private IMessageBoxService MessageBoxService { get; }
        #endregion
        public bool TryAquireLock(string operationName, string operationContext, out IOperationLock operationLock)
        {
            var request = new SysOperationLock
            {
                OperationName = operationName,
                OperationContext = operationContext,
                MachineName = Environment.MachineName,
                ProcessId = Process.GetCurrentProcess().Id
            };

            SysOperationLock sysOperationLock;
            var newLockAquired = _operationLockDao.TryAquireLock(request, out sysOperationLock);

            if (newLockAquired)
            {
                lock (SyncRoot)
                {
                    _activeLocks.Add(sysOperationLock);
                }
            }
            operationLock = sysOperationLock;
            return newLockAquired;
        }

        public void ReleaseLock(IOperationLock operationLock)
        {
            var sysOperationLock = (SysOperationLock)operationLock;
            lock (SyncRoot)
            {
                _activeLocks.Remove(sysOperationLock);
                _operationLockDao.DeleteObject(sysOperationLock);
            }
        }

        private void UpdateLocks()
        {
            while (true)
            {
                List<SysOperationLock> activeLocks;

                lock (SyncRoot)
                {
                    activeLocks = _activeLocks.ToList();
                }

                foreach (var operationLock in activeLocks)
                {
                    try
                    {
                        _operationLockDao.UpdateObject(operationLock);
                    }
                    catch (Exception exc)
                    {
                        Logger.Warning(exc, "Error updating operation lock");
                    }
                }

                Thread.Sleep(15000);
            }
// ReSharper disable FunctionNeverReturns
        }

        private const string ObjectLockOperationName = "Edit";

        private static string GetObjectOperationContext(object objectKey, Type objectType)
        {
            return $"{objectType.FullName?.Replace(".", "-")}({StringHelper.KeyToString(objectKey)})";
        }

        public bool DoWithObjectEditLock(object objectKey, Type objectType, Action editObjectAction)
        {
            return DoWithObjectEditLock(objectKey, objectType, () =>
            {
                editObjectAction();
                return true;
            }, () => false);
        }
        public T DoWithObjectEditLock<T>(object objectKey, Type objectType, Func<T> editObjectFunc, Func<T> locked)
        {
            if (!TryAquireLock(ObjectLockOperationName, GetObjectOperationContext(objectKey, objectType), out var sysOperationLock))
            {
                MessageBoxService.ShowWarning(Resources.ObjectLocked);

                return locked();
            }

            try
            {
                return editObjectFunc();
            }
            finally
            {
                ReleaseLock(sysOperationLock);
            }
        }

        private Exception ThrowObjectLockedException(SysOperationLock sysOperationLock)
        {
            var lockException = new ObjectIsLockedException(@"This object is locked by another user.
Please wait until user finishes his work.")
            {
                LockAquiredTime = sysOperationLock.AquiredTime.DateTime,
                LockExpirationTime = sysOperationLock.ExpirationTime.DateTime
            };
            return lockException;
        }

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (_keepAliveThread == null)
            {
                return;
            }
            _keepAliveThread.Abort();
            _keepAliveThread = null;
        }

        #region Nested type: Dao
        public sealed class SysOperationLockDao : AbstractWebApiDao<SysOperationLock, SysOperationLockKey>
        {
            /// <inheritdoc />
            public SysOperationLockDao(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
                : base(clientFactory, messageBoxService)
            {
            }

            public bool TryAquireLock(SysOperationLock request, out SysOperationLock sysOperationLock)
            {
                var content = ContentHelper.ToContent(request);
                ActionResult<ObjectOperationResult<SysOperationLock>> resp;
                try
                {
                    resp = Client.HttpPost<ActionResult<ObjectOperationResult<SysOperationLock>>>(content: content);
                }
                catch (CommunicationException exc)
                {
                    if (exc.StatusCode == HttpStatusCode.Forbidden)
                    {
                        resp = null;
                    }
                    else
                    {
                        throw;    
                    }
                }

                if (resp == null || resp.Type != ActionResultType.Success)
                {
                    sysOperationLock = null;
                    return false;
                }
                sysOperationLock = resp.Data.Object;
                return true;
            }
        }
        #endregion
    }
}
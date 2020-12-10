using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="SysOperationLock"/>
    /// </summary>
    public abstract class CodeBehindSysOperationLockCollectionManager : ObjectWebApiCollectionManager<SysOperationLock, SysOperationLockKey>
    {
	    
		/// <inheritdoc />
        protected CodeBehindSysOperationLockCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindSysOperationLockCollectionManager(AbstractDao<SysOperationLock, SysOperationLockKey> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
        /// <inheritdoc />
        public override SysOperationLock GetReadOnlyObjectByKey(SysOperationLockKey key)
        {
            return GetAllObjects().Where(o => o.OperationName == key.OperationName && o.OperationContext == key.OperationContext).FirstOrDefault();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Client.Contracts.Services.Security;
using BusinessFramework.Client.Contracts.Services.Settings;
using BusinessFramework.Contracts;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;

namespace Northwind.Common.Settings
{
    public sealed class SessionSettingsService : ISessionSettingsService
    {
        private const int DefaultUserId = int.MinValue;

        private readonly Dictionary<int?, SessionSettingsProvider> _settingsProviders = new Dictionary<int?, SessionSettingsProvider>();

        private readonly object _syncRoot = new object();
        private bool? _authorizedEditAll;

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public SessionSettingsService(SessionSettingsAccessLevels accessLevels,
            ILogger logger,
            IMessageBoxService messageBoxService,
            ISecurityService securityService,
            ISysSettingCollectionManager sysSettingCollectionManager,
            ISysSettingPropertyCollectionManager sysSettingPropertyCollectionManager)
        {
            AccessLevels = accessLevels;

            Logger = logger;
            MessageBoxService = messageBoxService;
            SecurityService = securityService;
            SysSettingCollectionManager = sysSettingCollectionManager;
            SysSettingPropertyCollectionManager = sysSettingPropertyCollectionManager;
        }
        #region Dependencies
        private ILogger Logger { get; }
        private IMessageBoxService MessageBoxService { get; }
        internal ISecurityService SecurityService { get; }

        internal ISysSettingCollectionManager SysSettingCollectionManager { get; }
        internal ISysSettingPropertyCollectionManager SysSettingPropertyCollectionManager { get; }
        #endregion
        #region ISettingsService Members
        public SessionSettingsAccessLevels AccessLevels { get; }

        public ISessionSettingsProvider Current
        {
            get { return GetSettingsProvider(SecurityService.UserId); }
        }

        public ISessionSettingsProvider GetSettingsProvider(int? userId)
        {
            return GetSettingsProviderInternal(userId ?? DefaultUserId);
        }

        public void Reset(int? userId)
        {
            SysSettingCollectionManager.ClearCache();
            var settingsProvider = GetSettingsProviderInternal(userId ?? DefaultUserId);
            settingsProvider.Reset();
        }

        public void Reset()
        {
            SysSettingCollectionManager.ClearCache();
        }

        public void Save(int? userId)
        {
            var settingsProvider = GetSettingsProviderInternal(userId ?? DefaultUserId);
            settingsProvider.Save();
        }

        public void Save()
        {
            var saveDefaults = false;

            lock (_syncRoot)
            {
                foreach (var settingsProvider in _settingsProviders.Values)
                {
                    if (!settingsProvider.IsChanged)
                    {
                        continue;
                    }

                    settingsProvider.Save();
                    if (settingsProvider.UserId == null)
                    {
                        saveDefaults = true;
                    }
                }
            }

            RaiseSettingsChangedEvent();

            if (saveDefaults)
            {
                Reset();
            }
        }

        private void RaiseSettingsChangedEvent()
        {
            if (SettingsChanged == null)
            {
                return;
            }

            var errors = false;
            foreach (var handler in SettingsChanged.GetInvocationList().Cast<EventHandler>())
            {
                try
                {
                    handler(this, EventArgs.Empty);
                }
                catch (Exception exc)
                {
                    errors = true;
                    Logger.Error(exc, "Error applying setings");
                }
            }
            if (errors)
            {
                MessageBoxService.ShowWarning("Error(s) occurred when applying settings. See log for details");
            }
        }

        public event EventHandler SettingsChanged;
        #endregion

        internal bool TryGetSettingProperty(string settingName, out SysSettingProperty settingProperty)
        {
            return SysSettingPropertyCollectionManager.TryGetSettingProperty(settingName, out settingProperty);
        }

        private SessionSettingsProvider GetSettingsProviderInternal(int? userId)
        {
            lock (_syncRoot)
            {
                SessionSettingsProvider sessionSettingsProvider;
                if (!_settingsProviders.TryGetValue(userId ?? DefaultUserId, out sessionSettingsProvider))
                {
                    _settingsProviders[userId ?? DefaultUserId] = sessionSettingsProvider = CreateSettingsProvider(userId);
                }
                return sessionSettingsProvider;
            }
        }

        private SessionSettingsProvider CreateSettingsProvider(int? userId)
        {
            return new SessionSettingsProvider(this, userId ?? DefaultUserId);
        }
    }
}
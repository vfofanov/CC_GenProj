using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.Services.Security;
using BusinessFramework.Client.Contracts.Services.Settings;
using BusinessFramework.Contracts;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;

namespace Northwind.Client.CustomSettings
{
    internal class SettingsPresenter : IDisposable
    {
        private ISysSettingPropertyCollectionManager SysSettingPropertyCollectionManager { get; }
        private readonly ISessionSettingsService _service;
        private readonly ISettingsView _view;
        private readonly HashSet<int?> _changedSettingsProviders = new HashSet<int?>();
        private int? _currentUserId;

        public SettingsPresenter(ISecurityService securityService, 
            ISessionSettingsService service, ISettingsView view,
            ISysSettingPropertyCollectionManager sysSettingPropertyCollectionManager)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }
            SysSettingPropertyCollectionManager = sysSettingPropertyCollectionManager;

            _service = service;
            _view = view;

            view.AfterCurrentUserChanged += ChangeSettingProvider;
            view.AfterDefaultValueChanged += DefaultValueChanged;
            view.AfterValueChanged += ValueChanged;

            _currentUserId = securityService.UserId;
        }

        public void InitializeView()
        {
            _view.UpdateAcceessLevels(_service.AccessLevels);
            Update(_currentUserId);
        }

        public IEnumerable<ISessionSettingsProvider> GetСhangedSettingsProviders()
        {
            return
                from userName in _changedSettingsProviders
                select _service.GetSettingsProvider(userName);
        }

        public void Update()
        {
            Update(_currentUserId);
        }

        public void Refresh()
        {
            _view.Refresh();
        }

        private void Update(int? userId)
        {
            _currentUserId = userId;
            var settingsProvider = _service.GetSettingsProvider(_currentUserId);

            _view.UpdateUsers(_currentUserId, new int?[0]);
            _view.UpdateSettingProperties(EnumerateSettingProperties().Where(i => i.IsManaged));


            var defaults = ToDictionary(EnumerateSettingProperties(), settingProperty => settingsProvider.GetDefaultValue<object>(settingProperty.Name));
            _view.UpdateDefaultValues(defaults);

            if (userId == null)
            {
                _view.UpdateValues(new Dictionary<SysSettingProperty, object>());
            }
            else
            {
                var values = ToDictionary(EnumerateSettingProperties(), settingProperty => settingsProvider.GetValue<object>(settingProperty.Name));
                _view.UpdateValues(values);
            }
        }

        private IEnumerable<SysSettingProperty> EnumerateSettingProperties()
        {
            return SysSettingPropertyCollectionManager.GetAllObjects();
        }

        private Dictionary<SysSettingProperty, object> ToDictionary(IEnumerable<SysSettingProperty> properties, 
            Func<SysSettingProperty, object> getValue)
        {
            var dict = new Dictionary<SysSettingProperty, object>();
            foreach (var settingProperty in properties)
            {
                try
                {
                    dict.Add(settingProperty, getValue(settingProperty));
                }
                catch (ArgumentException exc)
                {
                    GlobalServices.Logger.Error(exc, exc.Message + "\r\nProperty:" + settingProperty.Name);
                    System.Diagnostics.Debug.Fail(exc.Message + "\r\nProperty:" + settingProperty.Name);
                }
            }
            return dict;
        }

        private void ChangeSettingProvider(int? userId)
        {
            Update(userId);
        }

        private void ValueChanged(string settingName, object value)
        {
            var settingsProvider = _service.GetSettingsProvider(_currentUserId);
            if (settingsProvider.SetValue(settingName, value))
                _changedSettingsProviders.Add(_currentUserId);
        }

        private void DefaultValueChanged(string settingName, object defaultValue)
        {
            var settingsProvider = _service.GetSettingsProvider(_currentUserId);
            if (settingsProvider.SetDefaultValue(settingName, defaultValue))
                _changedSettingsProviders.Add(_currentUserId);
        }

        #region Implementation of IDisposable

        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _view.AfterCurrentUserChanged -= ChangeSettingProvider;
                    _view.AfterDefaultValueChanged -= DefaultValueChanged;
                    _view.AfterValueChanged -= ValueChanged;
                }
            }
            _disposed = true;
        }

        ~SettingsPresenter()
        {
            Dispose(false);
        }

        #endregion
    }
}
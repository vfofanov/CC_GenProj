using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.Services.Settings;
using Northwind.Client.Contracts.BusinessObjects;

namespace Northwind.Common.Settings
{
    internal sealed class SessionSettingsProvider : ISessionSettingsProvider
    {
        private readonly SessionSettingsService _sessionSettingsService;
        private readonly Dictionary<string, SysSetting> _defaultValues = new Dictionary<string, SysSetting>();
        private readonly Dictionary<string, SysSetting> _values = new Dictionary<string, SysSetting>();


        public int? UserId { get; }

        public SessionSettingsProvider(SessionSettingsService sessionSettingsService, int? userId)
        {
            _sessionSettingsService = sessionSettingsService;
            UserId = userId;

            RefreshSettings();
        }


        #region Resolved properties
        public string Culture
        {
            get { return GetValue<string>(CommonSettings.Culture); }
            set { SetValue(CommonSettings.Culture, value); }
        }

        public string ApplicationStyle
        {
            get { return GetValue<string>(CommonSettings.ApplicationStyle); }
            set { SetValue(CommonSettings.ApplicationStyle, value); }
        }
        #endregion

        public bool IsChanged { get; private set; }

        private void RefreshSettings()
        {
            var settings = _sessionSettingsService.SysSettingCollectionManager.GetUserSettings(UserId);
            foreach (var setting in settings)
            {
                if (setting.UserId == null)
                {
                    _defaultValues[setting.SettingProperty.Name] = setting;
                }
                else
                {
                    _values[setting.SettingProperty.Name] = setting;
                }
            }
            IsChanged = false;
        }


        public void Reset()
        {
            foreach (var setting in EnumerateSettings())
            {
                if (setting.GetEditLevel() > 0)
                {
                    setting.CancelEdit();
                }
            }

            RefreshSettings();
        }

        private IEnumerable<SysSetting> EnumerateSettings()
        {
            return _values.Values.Concat(_defaultValues.Values).Select(setting => setting);
        }

        public void Save()
        {
            foreach (var setting in EnumerateSettings())
            {
                if (setting.Changed)
                {
                    _sessionSettingsService.SysSettingCollectionManager.SaveObject(setting);
                }

                setting.EndEdit();
            }

            RefreshSettings();
        }

        private object GetValueInternal(Type type, bool isDefault, string settingName)
        {
            SysSettingProperty settingProperty;
            if (!_sessionSettingsService.TryGetSettingProperty(settingName, out settingProperty))
            {
                return null;
                //throw new InvalidOperationException(string.Format("Unknown setting \"{0}\"", settingName));
            }

            SysSetting setting;

            if (!isDefault)
            {
                if (_values.TryGetValue(settingName, out setting))
                {
                    try
                    {
                        return ConvertValue(type, setting.GetValue());
                    }
                    catch
                    {
                        return null;
                    }
                }
            }

            if (!_defaultValues.TryGetValue(settingName, out setting))
            {
                return null;
            }

            try
            {
                return ConvertValue(type, setting.GetValue());
            }
            catch
            {
                return null;
            }
        }

        private static object ConvertValue(Type type, object value)
        {
            if (value == null)
            {
                return null;
            }

            if (type == typeof(object))
            {
                return value;
            }

            var converter = TypeDescriptor.GetConverter(type);
            if (!converter.CanConvertFrom(value.GetType()))
            {
                return value;
            }
            return converter.ConvertFrom(value);
        }

        private bool SetValueInternal(bool isDefault, string settingName, object value)
        {
            var acceessLevels = _sessionSettingsService.AccessLevels;

            if (!isDefault &&
                (acceessLevels & SessionSettingsAccessLevels.WriteValue) != SessionSettingsAccessLevels.WriteValue)
            {
                return false;
            }

            if (isDefault &&
                (acceessLevels & SessionSettingsAccessLevels.WriteDefaultValue) !=
                SessionSettingsAccessLevels.WriteDefaultValue)
            {
                return false;
            }

            if ((acceessLevels & SessionSettingsAccessLevels.AllUsersAccess) !=
                SessionSettingsAccessLevels.AllUsersAccess && UserId != _sessionSettingsService.SecurityService.UserId)
            {
                return false;
            }

            SysSettingProperty settingProperty;

            if (!_sessionSettingsService.TryGetSettingProperty(settingName, out settingProperty))
            {
                throw new InvalidOperationException("Unknown setting: " + settingName);
            }

            SysSetting setting;

            if (!isDefault)
            {
                if (!settingProperty.IsOverridable)
                {
                    throw new InvalidOperationException("The setting isn't overridable");
                }

                setting = BeginEditSetting(settingProperty, UserId, _values);
            }
            else
            {
                setting = BeginEditSetting(settingProperty, null, _defaultValues);
            }

            if (setting.GetValue() == value || setting.GetValue() != null && setting.GetValue().Equals(value))
            {
                return false;
            }

            setting.SetValue(value);
            IsChanged = true;
            return true;
        }

        private SysSetting BeginEditSetting(SysSettingProperty property, int? userId, Dictionary<string, SysSetting> dictionary)
        {
            SysSetting setting;
            if (!dictionary.TryGetValue(property.Name, out setting))
            {
                setting = new SysSetting
                {
                    Name = property.Name,
                    UserId = userId,
                    SettingPropertyId = property.Id
                };

                dictionary[property.Name] = setting;
            }

            if (setting.GetEditLevel() == 0)
            {
                setting.BeginEdit(false);
            }
            return setting;
        }

        #region ISettingsProvider Members
        public void CreateNewSettingEntry(ISysSetting setting)
        {
            var obj = (SysSetting) setting;
            if (obj.SettingProperty == null)
            {
                var property = GetOrCreateSettingProperty(obj);
                obj.SettingProperty = property;
            }

            obj = _sessionSettingsService.SysSettingCollectionManager.SaveObject(obj);

            _values[obj.Name] = obj;
        }

        private SysSettingProperty GetOrCreateSettingProperty(SysSetting obj)
        {
            SysSettingProperty property;
            if (!_sessionSettingsService.SysSettingPropertyCollectionManager.TryGetSettingProperty(obj.Name, out property))
            {
                property = new SysSettingProperty
                {
                    Name = obj.Name,
                    IsManaged = false,
                    IsOverridable = true
                };
                property = _sessionSettingsService.SysSettingPropertyCollectionManager.SaveObject(property);
            }
            return property;
        }

        public T GetDefaultValue<T>(string settingName)
        {
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            return (T) (GetValueInternal(typeof(T), true, settingName) ?? default(T));
        }

        public bool SetDefaultValue<T>(string settingName, T value)
        {
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            return SetValueInternal(true, settingName, value);
        }


        public T GetValue<T>(string settingName)
        {
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            return (T) (GetValueInternal(typeof(T), false, settingName) ?? default(T));
        }

        public object GetValue(Type type, string settingName)
        {
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            return GetValueInternal(type, false, settingName);
        }

        public bool SetValue<T>(string settingName, T value)
        {
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            return SetValueInternal(false, settingName, value);
        }
        #endregion
    }
}
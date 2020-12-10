using System.Collections.Generic;
using BusinessFramework.Client.Contracts.Services.Settings;
using NorthWind.Client.Contracts.BusinessObjects;

namespace NorthWind.Client.CustomSettings
{
    public interface ISettingsView
    {
        void UpdateAcceessLevels(SessionSettingsAccessLevels accessLevels);
        void UpdateUsers(int? currentUserId, IEnumerable<int?> userIds);
        void UpdateSettingProperties(IEnumerable<SysSettingProperty> settingProperties);
        void UpdateDefaultValues(IDictionary<SysSettingProperty, object> defaultValues);
        void UpdateValues(IDictionary<SysSettingProperty, object> values);
        void Refresh();
/*
		event Action AfterReset;
		event Action AfterSave;
		event Action AfterResetAll;
		event Action AfterSaveAll;
 */
        event System.Action<int?> AfterCurrentUserChanged;
        event System.Action<string, object> AfterDefaultValueChanged;
        event System.Action<string, object> AfterValueChanged;
    }
}
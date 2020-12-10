using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.Services.Settings;
using BusinessFramework.Client.WinForms.IG.Controls.PropertyGridEx;
using Infragistics.Shared;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;

namespace NorthWind.Client.CustomSettings
{
    public partial class SettingsTreeControl : UserControl, ISettingsView
    {
        
        private readonly Dictionary<string, CustomProperty> customProperties =
            new Dictionary<string, CustomProperty>(StringComparer.InvariantCultureIgnoreCase);

        private readonly Dictionary<string, Action<object>> setters =
            new Dictionary<string, Action<object>>(StringComparer.InvariantCultureIgnoreCase);

        private SessionSettingsAccessLevels _accessLevels = SessionSettingsAccessLevels.Base;
        private int? _currentUserId;
        private bool _firstUpdate = true;

        public SettingsTreeControl()
        {
            InitializeComponent();
            propertyGrid.ShowCustomProperties = true;
            propertyGrid.AutoSizeProperties = true;
        }

        #region Implementation of ISettingsView
        public void UpdateAcceessLevels(SessionSettingsAccessLevels accessLevels)
        {
            _accessLevels = accessLevels;
        }

        public void UpdateUsers(int? currentUserId, IEnumerable<int?> userNameIds)
        {
            _currentUserId = currentUserId;
            comboBoxUsers.Items.Clear();
            if (ShowDefaults)
            {
                comboBoxUsers.Items.Add("Defaults");
            }

            userChanging = true;
            try
            {
                comboBoxUsers.SelectedIndex = 0;
            }
            finally
            {
                userChanging = false;
            }
        }

        public void UpdateSettingProperties(IEnumerable<SysSettingProperty> settingProperties)
        {
            customProperties.Clear();
            setters.Clear();
            propertyGrid.Item.Clear();
            foreach (var property in settingProperties)
            {
                var index = propertyGrid.Item.Add(property.Name, string.Empty, false, property.GroupName ?? "Ungrouped",
                    property.Description, true);
                var prop = property;
                if (SetDefaults)
                {
                    setters[property.Name] = val => AfterDefaultValueChanged(prop.Name, val);
                }
                else
                {
                    setters[property.Name] = val => AfterValueChanged(prop.Name, val);
                }
                var item = propertyGrid.Item[index];
                item.IsReadOnly = _currentUserId.HasValue && !prop.IsOverridable;
                item.Tag = property.Name;
                customProperties[property.Name] = item;
                if (property.GetUIEditorType() != null)
                {
                    item.CustomEditor = Activator.CreateInstance(property.GetUIEditorType()) as UITypeEditor;
                }
            }
        }

        private void UpdateTreeValues(IDictionary<SysSettingProperty, object> values)
        {
            foreach (var value in values)
            {
                CustomProperty customProperty;
                if (!customProperties.TryGetValue(value.Key.Name, out customProperty))
                {
                    continue;
                }
                var val = value.Value;
                if (val == null && value.Key.GetDefaultType() != null && (value.Key.GetDefaultType().IsPrimitive ||
                                                                          value.Key.GetDefaultType().GetConstructor(
                                                                              Type.EmptyTypes) != null))
                    /* if class has a parameterless constructor, then create default instance*/
                {
                    val = Activator.CreateInstance(value.Key.GetDefaultType());
                }
                if (val == null)
                {
                    val = string.Empty;
                }
                customProperty.Value = val;
                customProperty.DefaultValue = val;
                if (value.Key.GetDefaultType() == null &&
                    (customProperty.Value == null || customProperty.Value.GetType().IsPrimitive))
                {
                    customProperty.CustomEditor =
                        Activator.CreateInstance(typeof (PrimitiveTypeUITypeEditor)) as UITypeEditor;
                }
            }
            if (_firstUpdate)
            {
                _firstUpdate = false;
                propertyGrid.CollapseAllGridItems();
            }
            propertyGrid.Refresh();
        }

        public void UpdateDefaultValues(IDictionary<SysSettingProperty, object> defaultValues)
        {
            if (!SetDefaults)
            {
                return;
            }
            UpdateTreeValues(defaultValues);
        }

        public void UpdateValues(IDictionary<SysSettingProperty, object> values)
        {
            if (SetDefaults)
            {
                return;
            }
            UpdateTreeValues(values);
        }

/*
        public event Action AfterReset;
        public event Action AfterSave;
        public event Action AfterResetAll;
        public event Action AfterSaveAll;
 */
        public event Action<int?> AfterCurrentUserChanged;
        public event Action<string, object> AfterDefaultValueChanged;
        public event Action<string, object> AfterValueChanged;
        #endregion
        private bool ShowDefaults
        {
            get
            {
                return (_accessLevels & SessionSettingsAccessLevels.AllUsersAccess) ==
                       SessionSettingsAccessLevels.AllUsersAccess;
            }
        }

        private bool SetDefaults
        {
            get { return _currentUserId == null && ShowDefaults; }
        }

        private bool userChanging;

        private void ComboBoxUsersSelectedIndexChanged(object sender, EventArgs e)
        {
            if (userChanging)
            {
                return;
            }
            if (ShowDefaults && comboBoxUsers.SelectedIndex == 0)
            {
                AfterCurrentUserChanged(null);
            }
        }

        private void PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
        {
            if (e == null || e.ChangedItem == null)
            {
                return;
            }
            Action<object> setter;
            if (!setters.TryGetValue(e.ChangedItem.Label, out setter))
            {
                return;
            }
            setter(e.ChangedItem.Value);
        }

        public new void Refresh()
        {
            base.Refresh();
            propertyGrid.Refresh();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.DataObjects.CustomSettings;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Client.Contracts.BusinessObjects;

namespace NorthWind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindSysSettingCollectionManager" />
    public sealed class SysSettingCollectionManager : CodeBehind.CodeBehindSysSettingCollectionManager, ISysSettingCollectionManager
    {
        /// <inheritdoc />
        public SysSettingCollectionManager(
            ISysSettingPropertyCollectionManager propertyCollectionManager,
            IControllerClientFactory clientFactory, IMessageBoxService messageBoxService)
            : base(new SysSettingDao(clientFactory, messageBoxService))
        {
            PropertyCollectionManager = propertyCollectionManager;
        }

        private ISysSettingPropertyCollectionManager PropertyCollectionManager { get; }

        /// <inheritdoc />
        public override SysSetting CreateObject(SysSetting obj)
        {
            CheckForSettingProperty(obj);
            return base.CreateObject(obj);
        }

        /// <inheritdoc />
        public override void UpdateObject(SysSetting obj)
        {
            CheckForSettingProperty(obj);
            base.UpdateObject(obj);
        }

        private void CheckForSettingProperty(SysSetting obj)
        {
             // Setting has no setting property -> create it.
            if (obj.SettingProperty == null)
            {
                var objProperty = new SysSettingProperty
                                      {
                                          Name = obj.Name,
                                          IsManaged = false,
                                          IsOverridable = true
                                      };
                objProperty = PropertyCollectionManager.SaveObject(objProperty);
                obj.SettingPropertyId = objProperty.Id;
            }
        }

        /// <summary>
        /// Get settings by user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<SysSetting> GetUserSettings(int? userId)
        {
            return GetAllObjects().Where(setting => setting.UserId == null || setting.UserId == userId).ToList();
        }

        #region Nested type: Dao
        public class SysSettingDao : AbstractWebApiDao<SysSetting, int>
    {
        /// <inheritdoc />
        public SysSettingDao(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
            : base(clientFactory, messageBoxService)
        {
        }

        /// <inheritdoc />
        public override IQueryable<SysSetting> GetAllObjects()
        {
            //TODO: Need parse value after query condition

            var result = base.GetAllObjects().ToList();
            foreach (var setting in result)
            {
                ParseValue(setting);
            }
            return result.AsQueryable();
        }

        /// <inheritdoc />
        public override SysSetting CreateObject(SysSetting obj)
        {
            FormatValue(obj);
            var updatedSetting = base.CreateObject(obj);
            if (updatedSetting == null)
            {
                return null;
            }
            ParseValue(updatedSetting);
            return updatedSetting;
        }

        /// <inheritdoc />
        public override SysSetting UpdateObject(SysSetting obj)
        {
            FormatValue(obj);
            var updatedSetting = base.UpdateObject(obj);
            if (updatedSetting == null)
            {
                return null;
            }
            ParseValue(updatedSetting);
            return updatedSetting;
        }

        private static void ParseValue(SysSetting setting)
        {
            if (setting.SettingProperty != null &&
                typeof (ISettingStringConvertable).IsAssignableFrom(setting.SettingProperty.GetDefaultType()))
            {
                setting.SetValue(Activator.CreateInstance(setting.SettingProperty.GetDefaultType()));
                ((ISettingStringConvertable) setting.GetValue()).Value = setting.StringValue;
            }
            else
            {
                setting.SetValue(setting.StringValue);
            }

            setting.MarkOld();
        }

        private void FormatValue(SysSetting setting)
        {
            string valStr = null;
            var settingStringConvertable = setting.GetValue() as ISettingStringConvertable;
            if (settingStringConvertable != null)
            {
                valStr = settingStringConvertable.Value;
            }

            if (valStr == null && setting.GetValue() != null)
            {
                var converter = TypeDescriptor.GetConverter(setting.GetValue().GetType());
                if (converter.CanConvertTo(typeof (string)))
                {
                    valStr = converter.ConvertToString(setting.GetValue());
                }
            }

            setting.StringValue = valStr;
        }
    }
        #endregion
    }
}
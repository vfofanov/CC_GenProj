using System;
using System.ComponentModel;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.DataObjects;
using Newtonsoft.Json;

namespace NorthWind.Client.Contracts.BusinessObjects
{

    [Serializable]
	public sealed class SysSetting : CodeBehind.CodeBehindSysSetting, ISysSetting
    {
        private object _value;
        private string _name;

        public SysSetting()
		{
		}

		private SysSetting(SysSetting origin)
		    :base(origin)
	    {
	        _value = origin._value;
	        _name = origin._name;
		}

        [JsonIgnore]
        public SysSettingProperty SettingProperty
        {
            get => SessionGlobalServices.GetManager<SysSettingProperty, int>().GetObjectByKey(SettingPropertyId);
            set => SettingPropertyId = value?.Id ?? 0;
        }

        /// <summary>
        ///     Setting name.
        /// </summary>
        public string Name
        {
            get => SettingProperty != null ? SettingProperty.Name : _name;

            set
            {
                if (SettingProperty != null)
                {
                    SettingProperty.Name = value;
                }
                else
                {
                    _name = value;
                }
            }
        }

        public void SetValue(object value)
        {
            SetMemberAndMarkChanged(ref _value, value);
        }

        public object GetValue()
        {
            if (_value == null || SettingProperty == null || SettingProperty.GetDefaultType() == null)
            {
                return _value;
            }

            if (_value.GetType() == SettingProperty.GetDefaultType())
            {
                return _value;
            }

            var converter = TypeDescriptor.GetConverter(SettingProperty.GetDefaultType());
            if (!converter.CanConvertFrom(_value.GetType()))
            {
                return _value;
            }

            try
            {
                return converter.ConvertFrom(_value);
            }
            catch
            {
            }

            return _value;
        }

        public override SysSetting Clone()
        {
            return new SysSetting(this);
        }	 
    }
}
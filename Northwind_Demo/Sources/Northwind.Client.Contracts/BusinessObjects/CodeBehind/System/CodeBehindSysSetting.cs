using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using NorthWind.Client.Contracts.Properties;


namespace NorthWind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("SysSetting" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindSysSetting : ClassicDataObject<int, SysSetting>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static SysSetting CreateSysSetting(int id)
        {
            return new SysSetting {Id = id};
        }

        private int _settingPropertyId;
        private string _stringValue;
        private int? _userId;

        protected CodeBehindSysSetting()
		{
		}

		protected CodeBehindSysSetting(SysSetting origin)
		    :base(origin)
	    {
            _settingPropertyId = origin._settingPropertyId;
            _stringValue = origin._stringValue;
            _userId = origin._userId;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysSetting_SettingPropertyId_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSetting_SettingPropertyId")]
		public virtual int SettingPropertyId
        {
            [DebuggerStepThrough]
            get { return _settingPropertyId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _settingPropertyId, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSetting_StringValue")]
		public virtual string StringValue
        {
            [DebuggerStepThrough]
            get { return _stringValue; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _stringValue, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSetting_UserId")]
		public virtual int? UserId
        {
            [DebuggerStepThrough]
            get { return _userId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _userId, value); }
        } 
    } 
}

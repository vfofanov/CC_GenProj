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
	[DebuggerDisplay("SysSettingProperty" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindSysSettingProperty : ClassicDataObject<int, SysSettingProperty>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static SysSettingProperty CreateSysSettingProperty(int id)
        {
            return new SysSettingProperty {Id = id};
        }

        private string _defaultType;
        private string _description;
        private string _groupName;
        private bool _isManaged;
        private bool _isOverridable;
        private string _name;
        private string _uIEditorType;

        protected CodeBehindSysSettingProperty()
		{
            _isOverridable = true;
		}

		protected CodeBehindSysSettingProperty(SysSettingProperty origin)
		    :base(origin)
	    {
            _defaultType = origin._defaultType;
            _description = origin._description;
            _groupName = origin._groupName;
            _isManaged = origin._isManaged;
            _isOverridable = origin._isOverridable;
            _name = origin._name;
            _uIEditorType = origin._uIEditorType;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_DefaultType")]
		public virtual string DefaultType
        {
            [DebuggerStepThrough]
            get { return _defaultType; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _defaultType, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_Description")]
		public virtual string Description
        {
            [DebuggerStepThrough]
            get { return _description; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _description, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_GroupName")]
		public virtual string GroupName
        {
            [DebuggerStepThrough]
            get { return _groupName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _groupName, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysSettingProperty_IsManaged_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_IsManaged")]
		public virtual bool IsManaged
        {
            [DebuggerStepThrough]
            get { return _isManaged; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _isManaged, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysSettingProperty_IsOverridable_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_IsOverridable")]
		public virtual bool IsOverridable
        {
            [DebuggerStepThrough]
            get { return _isOverridable; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _isOverridable, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysSettingProperty_Name_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_Name")]
		public virtual string Name
        {
            [DebuggerStepThrough]
            get { return _name; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _name, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysSettingProperty_UIEditorType")]
		public virtual string UIEditorType
        {
            [DebuggerStepThrough]
            get { return _uIEditorType; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _uIEditorType, value); }
        } 
    } 
}

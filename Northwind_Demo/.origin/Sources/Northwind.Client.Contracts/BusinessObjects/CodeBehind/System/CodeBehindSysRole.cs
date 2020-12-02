using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using Northwind.Client.Contracts.Properties;


namespace Northwind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("SysRole" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindSysRole : ClassicDataObject<int, SysRole>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static SysRole CreateSysRole(int id)
        {
            return new SysRole {Id = id};
        }

        private string _description;
        private bool _isOwnByUser;
        private bool _isSystem;
        private string _name;
        private int? _ownerUserID;

        protected CodeBehindSysRole()
		{
            _isOwnByUser = false;
            _isSystem = false;
		}

		protected CodeBehindSysRole(SysRole origin)
		    :base(origin)
	    {
            _description = origin._description;
            _isOwnByUser = origin._isOwnByUser;
            _isSystem = origin._isSystem;
            _name = origin._name;
            _ownerUserID = origin._ownerUserID;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "SysRole_Description")]
		public virtual string Description
        {
            [DebuggerStepThrough]
            get { return _description; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _description, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysRole_IsOwnByUser_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysRole_IsOwnByUser")]
		public virtual bool IsOwnByUser
        {
            [DebuggerStepThrough]
            get { return _isOwnByUser; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _isOwnByUser, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysRole_IsSystem_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysRole_IsSystem")]
		public virtual bool IsSystem
        {
            [DebuggerStepThrough]
            get { return _isSystem; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _isSystem, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysRole_Name_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysRole_Name")]
		public virtual string Name
        {
            [DebuggerStepThrough]
            get { return _name; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _name, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysRole_OwnerUserID")]
		public virtual int? OwnerUserID
        {
            [DebuggerStepThrough]
            get { return _ownerUserID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _ownerUserID, value); }
        } 
    } 
}

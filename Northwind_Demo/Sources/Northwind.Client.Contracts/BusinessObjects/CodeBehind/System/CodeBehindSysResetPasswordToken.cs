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
	[DebuggerDisplay("SysResetPasswordToken" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindSysResetPasswordToken : ClassicDataObject<int, SysResetPasswordToken>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static SysResetPasswordToken CreateSysResetPasswordToken(int id)
        {
            return new SysResetPasswordToken {Id = id};
        }

        private bool _isExecuted;
        private string _token;
        private int _userId;
        private DateTimeOffset _validFrom;

        protected CodeBehindSysResetPasswordToken()
		{
            _isExecuted = false;
		}

		protected CodeBehindSysResetPasswordToken(SysResetPasswordToken origin)
		    :base(origin)
	    {
            _isExecuted = origin._isExecuted;
            _token = origin._token;
            _userId = origin._userId;
            _validFrom = origin._validFrom;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysResetPasswordToken_IsExecuted_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysResetPasswordToken_IsExecuted")]
		public virtual bool IsExecuted
        {
            [DebuggerStepThrough]
            get { return _isExecuted; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _isExecuted, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysResetPasswordToken_Token_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysResetPasswordToken_Token")]
		public virtual string Token
        {
            [DebuggerStepThrough]
            get { return _token; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _token, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysResetPasswordToken_UserId_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysResetPasswordToken_UserId")]
		public virtual int UserId
        {
            [DebuggerStepThrough]
            get { return _userId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _userId, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysResetPasswordToken_ValidFrom_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysResetPasswordToken_ValidFrom")]
		public virtual DateTimeOffset ValidFrom
        {
            [DebuggerStepThrough]
            get { return _validFrom; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _validFrom, value); }
        } 
    } 
}

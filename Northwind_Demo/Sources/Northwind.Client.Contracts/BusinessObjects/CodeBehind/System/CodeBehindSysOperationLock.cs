using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using Northwind.Client.Contracts.Properties;
using Northwind.Contracts.DataObjects;


namespace Northwind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("SysOperationLock" + " {"+ nameof(OperationName) +"}" + " {"+ nameof(OperationContext) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(OperationName), nameof(OperationContext))]
    public abstract class CodeBehindSysOperationLock : AbstractDataObject<SysOperationLockKey, SysOperationLock>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static SysOperationLock CreateSysOperationLock(string operationName, string operationContext)
        {
            return new SysOperationLock {OperationName = operationName, OperationContext = operationContext};
        }

        private string _operationName;
        private string _operationContext;
        private DateTimeOffset _aquiredTime;
        private DateTimeOffset _expirationTime;
        private string _machineName;
        private int? _processId;

        protected CodeBehindSysOperationLock()
		{
		}

		protected CodeBehindSysOperationLock(SysOperationLock origin)
		    :base(origin)
	    {
            _operationName = origin._operationName;
            _operationContext = origin._operationContext;
            _aquiredTime = origin._aquiredTime;
            _expirationTime = origin._expirationTime;
            _machineName = origin._machineName;
            _processId = origin._processId;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysOperationLock_OperationName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysOperationLock_OperationName")]
		public virtual string OperationName
        {
            [DebuggerStepThrough]
            get { return _operationName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _operationName, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysOperationLock_OperationContext_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysOperationLock_OperationContext")]
		public virtual string OperationContext
        {
            [DebuggerStepThrough]
            get { return _operationContext; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _operationContext, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysOperationLock_AquiredTime_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysOperationLock_AquiredTime")]
		public virtual DateTimeOffset AquiredTime
        {
            [DebuggerStepThrough]
            get { return _aquiredTime; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _aquiredTime, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "SysOperationLock_ExpirationTime_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "SysOperationLock_ExpirationTime")]
		public virtual DateTimeOffset ExpirationTime
        {
            [DebuggerStepThrough]
            get { return _expirationTime; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _expirationTime, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysOperationLock_MachineName")]
		public virtual string MachineName
        {
            [DebuggerStepThrough]
            get { return _machineName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _machineName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "SysOperationLock_ProcessId")]
		public virtual int? ProcessId
        {
            [DebuggerStepThrough]
            get { return _processId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _processId, value); }
        } 
        public override SysOperationLockKey GetKey()
        {
            return new SysOperationLockKey(OperationName, OperationContext);
        }

        

		public override bool IsNew()
		{
		    return OperationName == default(string)|| OperationContext == default(string);
        }

		public override void MarkNew()
        {
            OperationName = default(string);
            OperationContext = default(string);
        }
    } 
}

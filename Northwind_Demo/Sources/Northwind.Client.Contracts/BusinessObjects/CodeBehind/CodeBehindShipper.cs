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
	[DebuggerDisplay("Shipper" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindShipper : ClassicDataObject<int, Shipper>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Shipper CreateShipper(int id)
        {
            return new Shipper {Id = id};
        }

        private string _companyName;
        private string _phone;

        protected CodeBehindShipper()
		{
		}

		protected CodeBehindShipper(Shipper origin)
		    :base(origin)
	    {
            _companyName = origin._companyName;
            _phone = origin._phone;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Shipper_CompanyName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Shipper_CompanyName")]
		public virtual string CompanyName
        {
            [DebuggerStepThrough]
            get { return _companyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _companyName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Shipper_Phone")]
		public virtual string Phone
        {
            [DebuggerStepThrough]
            get { return _phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _phone, value); }
        } 
    } 
}

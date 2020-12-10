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
	[DebuggerDisplay("Shippers" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindShippers : ClassicDataObject<int, Shippers>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Shippers CreateShippers(int id)
        {
            return new Shippers {Id = id};
        }

        private string _companyName;
        private string _phone;

        protected CodeBehindShippers()
		{
		}

		protected CodeBehindShippers(Shippers origin)
		    :base(origin)
	    {
            _companyName = origin._companyName;
            _phone = origin._phone;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Shippers_CompanyName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Shippers_CompanyName")]
		public virtual string CompanyName
        {
            [DebuggerStepThrough]
            get { return _companyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _companyName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Shippers_Phone")]
		public virtual string Phone
        {
            [DebuggerStepThrough]
            get { return _phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _phone, value); }
        } 
    } 
}

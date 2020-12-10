using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using NorthWind.Client.Contracts.Properties;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("CustomerCustomerDemo" + " {"+ nameof(CustomerID) +"}" + " {"+ nameof(CustomerTypeID) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(CustomerID), nameof(CustomerTypeID))]
    public abstract class CodeBehindCustomerCustomerDemo : AbstractDataObject<CustomerCustomerDemoKey, CustomerCustomerDemo>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static CustomerCustomerDemo CreateCustomerCustomerDemo(int customerID, int customerTypeID)
        {
            return new CustomerCustomerDemo {CustomerID = customerID, CustomerTypeID = customerTypeID};
        }

        private int _customerID;
        private int _customerTypeID;

        protected CodeBehindCustomerCustomerDemo()
		{
		}

		protected CodeBehindCustomerCustomerDemo(CustomerCustomerDemo origin)
		    :base(origin)
	    {
            _customerID = origin._customerID;
            _customerTypeID = origin._customerTypeID;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "CustomerCustomerDemo_CustomerID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "CustomerCustomerDemo_CustomerID")]
		public virtual int CustomerID
        {
            [DebuggerStepThrough]
            get { return _customerID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customerID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "CustomerCustomerDemo_CustomerTypeID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "CustomerCustomerDemo_CustomerTypeID")]
		public virtual int CustomerTypeID
        {
            [DebuggerStepThrough]
            get { return _customerTypeID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customerTypeID, value); }
        } 
        public override CustomerCustomerDemoKey GetKey()
        {
            return new CustomerCustomerDemoKey(CustomerID, CustomerTypeID);
        }

        

		public override bool IsNew()
		{
		    return CustomerID == default(int)|| CustomerTypeID == default(int);
        }

		public override void MarkNew()
        {
            CustomerID = default(int);
            CustomerTypeID = default(int);
        }
    } 
}

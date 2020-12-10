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
	[DebuggerDisplay("CustomerDemographic" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindCustomerDemographic : ClassicDataObject<int, CustomerDemographic>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static CustomerDemographic CreateCustomerDemographic(int id)
        {
            return new CustomerDemographic {Id = id};
        }

        private string _customerDesc;

        protected CodeBehindCustomerDemographic()
		{
		}

		protected CodeBehindCustomerDemographic(CustomerDemographic origin)
		    :base(origin)
	    {
            _customerDesc = origin._customerDesc;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "CustomerDemographic_CustomerDesc")]
		public virtual string CustomerDesc
        {
            [DebuggerStepThrough]
            get { return _customerDesc; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customerDesc, value); }
        } 
    } 
}

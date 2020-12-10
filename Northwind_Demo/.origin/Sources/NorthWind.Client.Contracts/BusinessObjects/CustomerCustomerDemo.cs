using System;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class CustomerCustomerDemo : CodeBehind.CodeBehindCustomerCustomerDemo
    {
        public CustomerCustomerDemo()
		{
		}

		private CustomerCustomerDemo(CustomerCustomerDemo origin)
		    :base(origin)
	    {
		}

		public override CustomerCustomerDemo Clone()
        {
            return new CustomerCustomerDemo(this);
        }	 
    }
}
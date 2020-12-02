using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Customer : CodeBehind.CodeBehindCustomer
    {
        public Customer()
		{
		}

		private Customer(Customer origin)
		    :base(origin)
	    {
		}

		public override Customer Clone()
        {
            return new Customer(this);
        }	 
    }
}
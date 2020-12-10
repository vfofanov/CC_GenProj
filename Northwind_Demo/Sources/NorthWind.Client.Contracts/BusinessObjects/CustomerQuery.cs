using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class CustomerQuery : CodeBehind.CodeBehindCustomerQuery
    {
        public CustomerQuery()
		{
		}

		private CustomerQuery(CustomerQuery origin)
		    :base(origin)
	    {
		}

		public override CustomerQuery Clone()
        {
            return new CustomerQuery(this);
        }	 
    }
}
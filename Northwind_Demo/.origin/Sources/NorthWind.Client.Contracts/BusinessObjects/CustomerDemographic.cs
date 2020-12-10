using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class CustomerDemographic : CodeBehind.CodeBehindCustomerDemographic
    {
        public CustomerDemographic()
		{
		}

		private CustomerDemographic(CustomerDemographic origin)
		    :base(origin)
	    {
		}

		public override CustomerDemographic Clone()
        {
            return new CustomerDemographic(this);
        }	 
    }
}
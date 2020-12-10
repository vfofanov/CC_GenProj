using System;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class OrderDetails : CodeBehind.CodeBehindOrderDetails
    {
        public OrderDetails()
		{
		}

		private OrderDetails(OrderDetails origin)
		    :base(origin)
	    {
		}

		public override OrderDetails Clone()
        {
            return new OrderDetails(this);
        }	 
    }
}
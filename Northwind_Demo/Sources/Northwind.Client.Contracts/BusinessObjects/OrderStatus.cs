using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class OrderStatus : CodeBehind.CodeBehindOrderStatus
    {
        public OrderStatus()
		{
		}

		private OrderStatus(OrderStatus origin)
		    :base(origin)
	    {
		}

		public override OrderStatus Clone()
        {
            return new OrderStatus(this);
        }	 
    }
}
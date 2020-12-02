using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class OrderDetail : CodeBehind.CodeBehindOrderDetail
    {
        public OrderDetail()
		{
		}

		private OrderDetail(OrderDetail origin)
		    :base(origin)
	    {
		}

		public override OrderDetail Clone()
        {
            return new OrderDetail(this);
        }	 
    }
}
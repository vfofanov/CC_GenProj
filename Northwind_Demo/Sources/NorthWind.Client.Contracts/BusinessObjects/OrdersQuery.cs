using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class OrdersQuery : CodeBehind.CodeBehindOrdersQuery
    {
        public OrdersQuery()
		{
		}

		private OrdersQuery(OrdersQuery origin)
		    :base(origin)
	    {
		}

		public override OrdersQuery Clone()
        {
            return new OrdersQuery(this);
        }	 
    }
}
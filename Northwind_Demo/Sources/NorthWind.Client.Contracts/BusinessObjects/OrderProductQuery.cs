using System;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class OrderProductQuery : CodeBehind.CodeBehindOrderProductQuery
    {
        public OrderProductQuery()
		{
		}

		private OrderProductQuery(OrderProductQuery origin)
		    :base(origin)
	    {
		}

		public override OrderProductQuery Clone()
        {
            return new OrderProductQuery(this);
        }	 
    }
}
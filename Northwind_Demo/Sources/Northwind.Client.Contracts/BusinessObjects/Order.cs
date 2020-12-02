using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Order : CodeBehind.CodeBehindOrder
    {
        public Order()
		{
		}

		private Order(Order origin)
		    :base(origin)
	    {
		}

		public override Order Clone()
        {
            return new Order(this);
        }	 
    }
}
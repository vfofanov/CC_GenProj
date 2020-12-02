using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QOrders : CodeBehind.CodeBehindQOrders
    {
        public QOrders()
		{
		}

		private QOrders(QOrders origin)
		    :base(origin)
	    {
		}

		public override QOrders Clone()
        {
            return new QOrders(this);
        }	 
    }
}
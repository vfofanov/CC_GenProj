using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QCustomers : CodeBehind.CodeBehindQCustomers
    {
        public QCustomers()
		{
		}

		private QCustomers(QCustomers origin)
		    :base(origin)
	    {
		}

		public override QCustomers Clone()
        {
            return new QCustomers(this);
        }	 
    }
}
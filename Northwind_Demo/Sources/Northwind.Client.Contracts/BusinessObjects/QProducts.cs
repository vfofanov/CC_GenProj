using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QProducts : CodeBehind.CodeBehindQProducts
    {
        public QProducts()
		{
		}

		private QProducts(QProducts origin)
		    :base(origin)
	    {
		}

		public override QProducts Clone()
        {
            return new QProducts(this);
        }	 
    }
}
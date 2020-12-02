using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QOrderProducts : CodeBehind.CodeBehindQOrderProducts
    {
        public QOrderProducts()
		{
		}

		private QOrderProducts(QOrderProducts origin)
		    :base(origin)
	    {
		}

		public override QOrderProducts Clone()
        {
            return new QOrderProducts(this);
        }	 
    }
}
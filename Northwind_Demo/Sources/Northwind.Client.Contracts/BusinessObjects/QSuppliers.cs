using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QSuppliers : CodeBehind.CodeBehindQSuppliers
    {
        public QSuppliers()
		{
		}

		private QSuppliers(QSuppliers origin)
		    :base(origin)
	    {
		}

		public override QSuppliers Clone()
        {
            return new QSuppliers(this);
        }	 
    }
}
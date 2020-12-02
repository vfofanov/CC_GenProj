using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Supplier : CodeBehind.CodeBehindSupplier
    {
        public Supplier()
		{
		}

		private Supplier(Supplier origin)
		    :base(origin)
	    {
		}

		public override Supplier Clone()
        {
            return new Supplier(this);
        }	 
    }
}
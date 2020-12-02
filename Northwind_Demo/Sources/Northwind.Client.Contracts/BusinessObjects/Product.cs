using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Product : CodeBehind.CodeBehindProduct
    {
        public Product()
		{
		}

		private Product(Product origin)
		    :base(origin)
	    {
		}

		public override Product Clone()
        {
            return new Product(this);
        }	 
    }
}
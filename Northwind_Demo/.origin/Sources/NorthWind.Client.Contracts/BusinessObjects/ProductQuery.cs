using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class ProductQuery : CodeBehind.CodeBehindProductQuery
    {
        public ProductQuery()
		{
		}

		private ProductQuery(ProductQuery origin)
		    :base(origin)
	    {
		}

		public override ProductQuery Clone()
        {
            return new ProductQuery(this);
        }	 
    }
}
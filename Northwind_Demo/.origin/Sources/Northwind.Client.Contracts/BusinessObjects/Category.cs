using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Category : CodeBehind.CodeBehindCategory
    {
        public Category()
		{
		}

		private Category(Category origin)
		    :base(origin)
	    {
		}

		public override Category Clone()
        {
            return new Category(this);
        }	 
    }
}
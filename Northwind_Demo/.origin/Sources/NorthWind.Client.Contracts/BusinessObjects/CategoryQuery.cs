using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class CategoryQuery : CodeBehind.CodeBehindCategoryQuery
    {
        public CategoryQuery()
		{
		}

		private CategoryQuery(CategoryQuery origin)
		    :base(origin)
	    {
		}

		public override CategoryQuery Clone()
        {
            return new CategoryQuery(this);
        }	 
    }
}
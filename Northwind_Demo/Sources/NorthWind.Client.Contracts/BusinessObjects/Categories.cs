using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Categories : CodeBehind.CodeBehindCategories
    {
        public Categories()
		{
		}

		private Categories(Categories origin)
		    :base(origin)
	    {
		}

		public override Categories Clone()
        {
            return new Categories(this);
        }	 
    }
}
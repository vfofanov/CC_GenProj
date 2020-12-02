using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class VSalesByCategory : CodeBehind.CodeBehindVSalesByCategory
    {
        public VSalesByCategory()
		{
		}

		private VSalesByCategory(VSalesByCategory origin)
		    :base(origin)
	    {
		}

		public override VSalesByCategory Clone()
        {
            return new VSalesByCategory(this);
        }	 
    }
}
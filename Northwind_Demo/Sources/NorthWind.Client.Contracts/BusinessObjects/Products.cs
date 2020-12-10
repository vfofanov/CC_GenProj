using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Products : CodeBehind.CodeBehindProducts
    {
        public Products()
		{
		}

		private Products(Products origin)
		    :base(origin)
	    {
		}

		public override Products Clone()
        {
            return new Products(this);
        }	 
    }
}
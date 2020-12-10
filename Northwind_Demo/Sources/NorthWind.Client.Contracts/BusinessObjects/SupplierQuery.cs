using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class SupplierQuery : CodeBehind.CodeBehindSupplierQuery
    {
        public SupplierQuery()
		{
		}

		private SupplierQuery(SupplierQuery origin)
		    :base(origin)
	    {
		}

		public override SupplierQuery Clone()
        {
            return new SupplierQuery(this);
        }	 
    }
}
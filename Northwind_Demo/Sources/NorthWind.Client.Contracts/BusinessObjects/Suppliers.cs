using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Suppliers : CodeBehind.CodeBehindSuppliers
    {
        public Suppliers()
		{
		}

		private Suppliers(Suppliers origin)
		    :base(origin)
	    {
		}

		public override Suppliers Clone()
        {
            return new Suppliers(this);
        }	 
    }
}
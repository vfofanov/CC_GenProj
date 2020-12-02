using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Shipper : CodeBehind.CodeBehindShipper
    {
        public Shipper()
		{
		}

		private Shipper(Shipper origin)
		    :base(origin)
	    {
		}

		public override Shipper Clone()
        {
            return new Shipper(this);
        }	 
    }
}
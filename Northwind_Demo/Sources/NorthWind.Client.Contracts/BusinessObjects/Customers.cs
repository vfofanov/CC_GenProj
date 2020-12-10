using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Customers : CodeBehind.CodeBehindCustomers
    {
        public Customers()
		{
		}

		private Customers(Customers origin)
		    :base(origin)
	    {
		}

		public override Customers Clone()
        {
            return new Customers(this);
        }	 
    }
}
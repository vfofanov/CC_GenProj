using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Shippers : CodeBehind.CodeBehindShippers
    {
        public Shippers()
		{
		}

		private Shippers(Shippers origin)
		    :base(origin)
	    {
		}

		public override Shippers Clone()
        {
            return new Shippers(this);
        }	 
    }
}
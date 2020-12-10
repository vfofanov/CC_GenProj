using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class ShipperQuery : CodeBehind.CodeBehindShipperQuery
    {
        public ShipperQuery()
		{
		}

		private ShipperQuery(ShipperQuery origin)
		    :base(origin)
	    {
		}

		public override ShipperQuery Clone()
        {
            return new ShipperQuery(this);
        }	 
    }
}
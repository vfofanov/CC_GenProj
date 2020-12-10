using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Territory : CodeBehind.CodeBehindTerritory
    {
        public Territory()
		{
		}

		private Territory(Territory origin)
		    :base(origin)
	    {
		}

		public override Territory Clone()
        {
            return new Territory(this);
        }	 
    }
}
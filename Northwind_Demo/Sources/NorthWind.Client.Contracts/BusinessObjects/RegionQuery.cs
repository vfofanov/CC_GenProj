using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class RegionQuery : CodeBehind.CodeBehindRegionQuery
    {
        public RegionQuery()
		{
		}

		private RegionQuery(RegionQuery origin)
		    :base(origin)
	    {
		}

		public override RegionQuery Clone()
        {
            return new RegionQuery(this);
        }	 
    }
}
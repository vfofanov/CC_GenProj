using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Region : CodeBehind.CodeBehindRegion
    {
        public Region()
		{
		}

		private Region(Region origin)
		    :base(origin)
	    {
		}

		public override Region Clone()
        {
            return new Region(this);
        }	 
    }
}
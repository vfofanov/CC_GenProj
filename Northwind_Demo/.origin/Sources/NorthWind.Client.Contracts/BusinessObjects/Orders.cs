using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Orders : CodeBehind.CodeBehindOrders
    {
        public Orders()
		{
		}

		private Orders(Orders origin)
		    :base(origin)
	    {
		}

		public override Orders Clone()
        {
            return new Orders(this);
        }	 
    }
}
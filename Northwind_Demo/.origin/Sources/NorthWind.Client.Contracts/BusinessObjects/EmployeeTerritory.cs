using System;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class EmployeeTerritory : CodeBehind.CodeBehindEmployeeTerritory
    {
        public EmployeeTerritory()
		{
		}

		private EmployeeTerritory(EmployeeTerritory origin)
		    :base(origin)
	    {
		}

		public override EmployeeTerritory Clone()
        {
            return new EmployeeTerritory(this);
        }	 
    }
}
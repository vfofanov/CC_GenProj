using System;
using BusinessFramework.Client.Contracts.Files;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class EmployeeQuery : CodeBehind.CodeBehindEmployeeQuery
    {
        public EmployeeQuery()
		{
		}

		private EmployeeQuery(EmployeeQuery origin)
		    :base(origin)
	    {
		}

		public override EmployeeQuery Clone()
        {
            return new EmployeeQuery(this);
        }	 
    }
}
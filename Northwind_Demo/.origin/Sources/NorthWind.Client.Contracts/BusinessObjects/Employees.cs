using System;
using BusinessFramework.Client.Contracts.Files;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Employees : CodeBehind.CodeBehindEmployees
    {
        public Employees()
		{
		}

		private Employees(Employees origin)
		    :base(origin)
	    {
		}

		public override Employees Clone()
        {
            return new Employees(this);
        }	 
    }
}
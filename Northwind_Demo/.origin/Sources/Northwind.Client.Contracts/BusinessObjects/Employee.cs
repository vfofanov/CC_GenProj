using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class Employee : CodeBehind.CodeBehindEmployee
    {
        public Employee()
		{
		}

		private Employee(Employee origin)
		    :base(origin)
	    {
		}

		public override Employee Clone()
        {
            return new Employee(this);
        }	 
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Employee"/> to table dbo.Employees
    /// </summary>
    internal sealed class EmployeeDatabaseMapping : CodeBehind.CodeBehindEmployeeDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public EmployeeDatabaseMapping()
        {            
        }
    }
}

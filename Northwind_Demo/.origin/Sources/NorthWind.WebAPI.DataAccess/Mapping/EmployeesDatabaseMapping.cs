using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Employees"/> to table dbo.Employees
    /// </summary>
    internal sealed class EmployeesDatabaseMapping : CodeBehind.CodeBehindEmployeesDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public EmployeesDatabaseMapping()
        {            
        }
    }
}

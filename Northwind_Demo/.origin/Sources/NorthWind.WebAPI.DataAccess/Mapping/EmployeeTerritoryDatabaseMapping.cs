using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="EmployeeTerritory"/> to table dbo.EmployeeTerritories
    /// </summary>
    internal sealed class EmployeeTerritoryDatabaseMapping : CodeBehind.CodeBehindEmployeeTerritoryDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public EmployeeTerritoryDatabaseMapping()
        {            
        }
    }
}

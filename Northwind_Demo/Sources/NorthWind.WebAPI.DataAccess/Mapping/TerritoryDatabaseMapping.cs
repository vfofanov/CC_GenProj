using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Territory"/> to table dbo.Territories
    /// </summary>
    internal sealed class TerritoryDatabaseMapping : CodeBehind.CodeBehindTerritoryDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public TerritoryDatabaseMapping()
        {            
        }
    }
}

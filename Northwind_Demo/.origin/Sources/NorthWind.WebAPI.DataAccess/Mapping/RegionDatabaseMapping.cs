using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Region"/> to table dbo.Region
    /// </summary>
    internal sealed class RegionDatabaseMapping : CodeBehind.CodeBehindRegionDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public RegionDatabaseMapping()
        {            
        }
    }
}

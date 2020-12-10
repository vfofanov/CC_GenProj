using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Shippers"/> to table dbo.Shippers
    /// </summary>
    internal sealed class ShippersDatabaseMapping : CodeBehind.CodeBehindShippersDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public ShippersDatabaseMapping()
        {            
        }
    }
}

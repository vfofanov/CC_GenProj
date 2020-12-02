using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Shipper"/> to table dbo.Shippers
    /// </summary>
    internal sealed class ShipperDatabaseMapping : CodeBehind.CodeBehindShipperDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public ShipperDatabaseMapping()
        {            
        }
    }
}

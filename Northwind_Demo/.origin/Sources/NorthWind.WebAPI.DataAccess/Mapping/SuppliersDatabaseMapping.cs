using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Suppliers"/> to table dbo.Suppliers
    /// </summary>
    internal sealed class SuppliersDatabaseMapping : CodeBehind.CodeBehindSuppliersDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SuppliersDatabaseMapping()
        {            
        }
    }
}

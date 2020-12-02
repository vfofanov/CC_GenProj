using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Supplier"/> to table dbo.Suppliers
    /// </summary>
    internal sealed class SupplierDatabaseMapping : CodeBehind.CodeBehindSupplierDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SupplierDatabaseMapping()
        {            
        }
    }
}

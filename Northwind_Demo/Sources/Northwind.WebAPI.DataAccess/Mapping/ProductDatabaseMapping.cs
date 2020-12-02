using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Product"/> to table dbo.Products
    /// </summary>
    internal sealed class ProductDatabaseMapping : CodeBehind.CodeBehindProductDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public ProductDatabaseMapping()
        {            
        }
    }
}

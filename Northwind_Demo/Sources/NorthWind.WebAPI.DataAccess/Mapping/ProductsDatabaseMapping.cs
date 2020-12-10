using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Products"/> to table dbo.Products
    /// </summary>
    internal sealed class ProductsDatabaseMapping : CodeBehind.CodeBehindProductsDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public ProductsDatabaseMapping()
        {            
        }
    }
}

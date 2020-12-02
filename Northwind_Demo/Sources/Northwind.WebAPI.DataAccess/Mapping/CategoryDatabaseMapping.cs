using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Category"/> to table dbo.Categories
    /// </summary>
    internal sealed class CategoryDatabaseMapping : CodeBehind.CodeBehindCategoryDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public CategoryDatabaseMapping()
        {            
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Categories"/> to table dbo.Categories
    /// </summary>
    internal sealed class CategoriesDatabaseMapping : CodeBehind.CodeBehindCategoriesDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public CategoriesDatabaseMapping()
        {            
        }
    }
}

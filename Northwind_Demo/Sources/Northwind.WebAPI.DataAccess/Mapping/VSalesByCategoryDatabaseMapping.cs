using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="VSalesByCategory"/> to table dbo.vSalesByCategory
    /// </summary>
    internal sealed class VSalesByCategoryDatabaseMapping : CodeBehind.CodeBehindVSalesByCategoryDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public VSalesByCategoryDatabaseMapping()
        {            
        }
    }
}

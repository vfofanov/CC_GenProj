using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Orders"/> to table dbo.Orders
    /// </summary>
    internal sealed class OrdersDatabaseMapping : CodeBehind.CodeBehindOrdersDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public OrdersDatabaseMapping()
        {            
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="OrderStatus"/> to table dbo.OrderStatus
    /// </summary>
    internal sealed class OrderStatusDatabaseMapping : CodeBehind.CodeBehindOrderStatusDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public OrderStatusDatabaseMapping()
        {            
        }
    }
}

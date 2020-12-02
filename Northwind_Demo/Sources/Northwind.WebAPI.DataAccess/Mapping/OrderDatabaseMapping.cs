using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Order"/> to table dbo.Orders
    /// </summary>
    internal sealed class OrderDatabaseMapping : CodeBehind.CodeBehindOrderDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public OrderDatabaseMapping()
        {            
        }
    }
}

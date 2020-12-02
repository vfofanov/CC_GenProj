using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="OrderDetail"/> to table dbo.Order Details
    /// </summary>
    internal sealed class OrderDetailDatabaseMapping : CodeBehind.CodeBehindOrderDetailDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public OrderDetailDatabaseMapping()
        {            
        }
    }
}

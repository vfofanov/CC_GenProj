using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="OrderDetails"/> to table dbo.Order Details
    /// </summary>
    internal sealed class OrderDetailsDatabaseMapping : CodeBehind.CodeBehindOrderDetailsDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public OrderDetailsDatabaseMapping()
        {            
        }
    }
}

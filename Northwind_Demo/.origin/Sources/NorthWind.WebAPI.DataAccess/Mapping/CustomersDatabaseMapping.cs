using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Customers"/> to table dbo.Customers
    /// </summary>
    internal sealed class CustomersDatabaseMapping : CodeBehind.CodeBehindCustomersDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public CustomersDatabaseMapping()
        {            
        }
    }
}

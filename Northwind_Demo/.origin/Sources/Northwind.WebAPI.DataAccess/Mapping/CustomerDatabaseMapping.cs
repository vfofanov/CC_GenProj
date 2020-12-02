using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="Customer"/> to table dbo.Customers
    /// </summary>
    internal sealed class CustomerDatabaseMapping : CodeBehind.CodeBehindCustomerDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public CustomerDatabaseMapping()
        {            
        }
    }
}

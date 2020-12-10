using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="CustomerDemographic"/> to table dbo.CustomerDemographics
    /// </summary>
    internal sealed class CustomerDemographicDatabaseMapping : CodeBehind.CodeBehindCustomerDemographicDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public CustomerDemographicDatabaseMapping()
        {            
        }
    }
}

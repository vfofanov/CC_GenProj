using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="CustomerDemographic"/> to table dbo.CustomerDemographics
    /// </summary>
    internal abstract class CodeBehindCustomerDemographicDatabaseMapping : EntityTypeConfiguration<CustomerDemographic>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindCustomerDemographicDatabaseMapping()
        {
            ToTable("CustomerDemographics", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("CustomerTypeID")
			    .IsRequired();
            Property(t => t.CustomerDesc)
			    .HasColumnName("CustomerDesc")
			    .IsUnicode();
        }
    }
}

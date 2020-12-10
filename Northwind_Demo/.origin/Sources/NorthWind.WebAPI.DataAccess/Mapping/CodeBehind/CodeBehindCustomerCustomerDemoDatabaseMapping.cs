using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="CustomerCustomerDemo"/> to table dbo.CustomerCustomerDemo
    /// </summary>
    internal abstract class CodeBehindCustomerCustomerDemoDatabaseMapping : EntityTypeConfiguration<CustomerCustomerDemo>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindCustomerCustomerDemoDatabaseMapping()
        {
            ToTable("CustomerCustomerDemo", "dbo");

            HasKey(t => new{t.CustomerID, t.CustomerTypeID});

            Property(t => t.CustomerID)
			    .HasColumnName("CustomerID")
			    .IsRequired();
            Property(t => t.CustomerTypeID)
			    .HasColumnName("CustomerTypeID")
			    .IsRequired();


            HasRequired(t => t.CustomerDemographic)
                .WithMany()
				.HasForeignKey(d =>  d.CustomerTypeID);

            HasRequired(t => t.Customers)
                .WithMany()
				.HasForeignKey(d =>  d.CustomerID);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Customer"/> to table dbo.Customers
    /// </summary>
    internal abstract class CodeBehindCustomerDatabaseMapping : EntityTypeConfiguration<Customer>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindCustomerDatabaseMapping()
        {
            ToTable("Customers", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ID")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Address)
			    .HasColumnName("Address")
			    .IsUnicode();
            Property(t => t.City)
			    .HasColumnName("City")
			    .IsUnicode();
            Property(t => t.CompanyName)
			    .HasColumnName("CompanyName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.ContactName)
			    .HasColumnName("ContactName")
			    .IsUnicode();
            Property(t => t.ContactTitle)
			    .HasColumnName("ContactTitle")
			    .IsUnicode();
            Property(t => t.Country)
			    .HasColumnName("Country")
			    .IsUnicode();
            Property(t => t.Fax)
			    .HasColumnName("Fax")
			    .IsUnicode();
            Property(t => t.Phone)
			    .HasColumnName("Phone")
			    .IsUnicode();
            Property(t => t.PostalCode)
			    .HasColumnName("PostalCode")
			    .IsUnicode();
            Property(t => t.Region)
			    .HasColumnName("Region")
			    .IsUnicode();
        }
    }
}

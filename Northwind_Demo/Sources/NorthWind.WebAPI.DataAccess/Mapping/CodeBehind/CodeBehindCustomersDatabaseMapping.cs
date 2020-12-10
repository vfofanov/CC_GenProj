using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Customers"/> to table dbo.Customers
    /// </summary>
    internal abstract class CodeBehindCustomersDatabaseMapping : EntityTypeConfiguration<Customers>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindCustomersDatabaseMapping()
        {
            ToTable("Customers", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("CustomerID")
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

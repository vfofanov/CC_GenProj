using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Shipper"/> to table dbo.Shippers
    /// </summary>
    internal abstract class CodeBehindShipperDatabaseMapping : EntityTypeConfiguration<Shipper>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindShipperDatabaseMapping()
        {
            ToTable("Shippers", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ID")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.CompanyName)
			    .HasColumnName("CompanyName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.Phone)
			    .HasColumnName("Phone")
			    .IsUnicode();
        }
    }
}

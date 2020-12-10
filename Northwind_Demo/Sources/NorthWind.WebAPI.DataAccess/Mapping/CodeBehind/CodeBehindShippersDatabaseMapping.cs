using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Shippers"/> to table dbo.Shippers
    /// </summary>
    internal abstract class CodeBehindShippersDatabaseMapping : EntityTypeConfiguration<Shippers>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindShippersDatabaseMapping()
        {
            ToTable("Shippers", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ShipperID")
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

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Territory"/> to table dbo.Territories
    /// </summary>
    internal abstract class CodeBehindTerritoryDatabaseMapping : EntityTypeConfiguration<Territory>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindTerritoryDatabaseMapping()
        {
            ToTable("Territories", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("TerritoryID")
			    .IsRequired();
            Property(t => t.RegionID)
			    .HasColumnName("RegionID")
			    .IsRequired();
            Property(t => t.TerritoryDescription)
			    .HasColumnName("TerritoryDescription")
			    .IsRequired()
			    .IsUnicode();


            HasRequired(t => t.Region)
                .WithMany()
				.HasForeignKey(d =>  d.RegionID);

        }
    }
}

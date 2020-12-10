using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Region"/> to table dbo.Region
    /// </summary>
    internal abstract class CodeBehindRegionDatabaseMapping : EntityTypeConfiguration<Region>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindRegionDatabaseMapping()
        {
            ToTable("Region", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("RegionID")
			    .IsRequired();
            Property(t => t.RegionDescription)
			    .HasColumnName("RegionDescription")
			    .IsRequired()
			    .IsUnicode();
        }
    }
}

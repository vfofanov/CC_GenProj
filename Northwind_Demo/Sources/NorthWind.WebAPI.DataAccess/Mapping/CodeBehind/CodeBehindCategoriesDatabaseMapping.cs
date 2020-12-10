using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Categories"/> to table dbo.Categories
    /// </summary>
    internal abstract class CodeBehindCategoriesDatabaseMapping : EntityTypeConfiguration<Categories>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindCategoriesDatabaseMapping()
        {
            ToTable("Categories", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("CategoryID")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.CategoryName)
			    .HasColumnName("CategoryName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.Description)
			    .HasColumnName("Description")
			    .IsUnicode();
            Property(t => t.Picture)
			    .HasColumnName("Picture");
        }
    }
}

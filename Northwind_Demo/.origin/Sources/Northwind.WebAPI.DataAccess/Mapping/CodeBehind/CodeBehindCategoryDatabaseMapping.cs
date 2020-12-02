using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Category"/> to table dbo.Categories
    /// </summary>
    internal abstract class CodeBehindCategoryDatabaseMapping : EntityTypeConfiguration<Category>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindCategoryDatabaseMapping()
        {
            ToTable("Categories", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ID")
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

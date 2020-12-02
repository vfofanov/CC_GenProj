using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="VSalesByCategory"/> to table dbo.vSalesByCategory
    /// </summary>
    internal abstract class CodeBehindVSalesByCategoryDatabaseMapping : EntityTypeConfiguration<VSalesByCategory>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindVSalesByCategoryDatabaseMapping()
        {
            ToTable("vSalesByCategory", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ID")
			    .IsRequired();
            Property(t => t.CategoryName)
			    .HasColumnName("CategoryName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.ProductName)
			    .HasColumnName("ProductName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.ProductSales)
			    .HasColumnName("ProductSales");
        }
    }
}

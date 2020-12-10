using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Products"/> to table dbo.Products
    /// </summary>
    internal abstract class CodeBehindProductsDatabaseMapping : EntityTypeConfiguration<Products>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindProductsDatabaseMapping()
        {
            ToTable("Products", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ProductID")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.CategoryID)
			    .HasColumnName("CategoryID");
            Property(t => t.Discontinued)
			    .HasColumnName("Discontinued")
			    .IsRequired();
            Property(t => t.ProductName)
			    .HasColumnName("ProductName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.QuantityPerUnit)
			    .HasColumnName("QuantityPerUnit")
			    .IsUnicode();
            Property(t => t.ReorderLevel)
			    .HasColumnName("ReorderLevel");
            Property(t => t.SupplierID)
			    .HasColumnName("SupplierID");
            Property(t => t.UnitPrice)
			    .HasColumnName("UnitPrice");
            Property(t => t.UnitsInStock)
			    .HasColumnName("UnitsInStock");
            Property(t => t.UnitsOnOrder)
			    .HasColumnName("UnitsOnOrder");


            HasOptional(t => t.Categories)
                .WithMany()
				.HasForeignKey(d =>  d.CategoryID);

            HasOptional(t => t.Suppliers)
                .WithMany()
				.HasForeignKey(d =>  d.SupplierID);

        }
    }
}

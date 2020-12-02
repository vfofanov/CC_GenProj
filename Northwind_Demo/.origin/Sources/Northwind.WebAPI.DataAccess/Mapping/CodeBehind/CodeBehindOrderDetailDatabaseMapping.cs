using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="OrderDetail"/> to table dbo.Order Details
    /// </summary>
    internal abstract class CodeBehindOrderDetailDatabaseMapping : EntityTypeConfiguration<OrderDetail>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindOrderDetailDatabaseMapping()
        {
            ToTable("Order Details", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("Id")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Discount)
			    .HasColumnName("Discount")
			    .IsRequired();
            Property(t => t.OrderID)
			    .HasColumnName("OrderID")
			    .IsRequired();
            Property(t => t.ProductID)
			    .HasColumnName("ProductID")
			    .IsRequired();
            Property(t => t.Quantity)
			    .HasColumnName("Quantity")
			    .IsRequired();
            Property(t => t.UnitPrice)
			    .HasColumnName("UnitPrice")
			    .IsRequired();


            HasRequired(t => t.Orders)
                .WithMany(t => t.OrderDetailss)
				.HasForeignKey(d =>  d.OrderID);

            HasRequired(t => t.Products)
                .WithMany()
				.HasForeignKey(d =>  d.ProductID);

        }
    }
}

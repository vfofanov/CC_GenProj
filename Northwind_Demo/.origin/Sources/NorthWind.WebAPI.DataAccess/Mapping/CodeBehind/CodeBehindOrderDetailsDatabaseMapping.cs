using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="OrderDetails"/> to table dbo.Order Details
    /// </summary>
    internal abstract class CodeBehindOrderDetailsDatabaseMapping : EntityTypeConfiguration<OrderDetails>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindOrderDetailsDatabaseMapping()
        {
            ToTable("Order Details", "dbo");

            HasKey(t => new{t.OrderID, t.ProductID});

            Property(t => t.OrderID)
			    .HasColumnName("OrderID")
			    .IsRequired();
            Property(t => t.ProductID)
			    .HasColumnName("ProductID")
			    .IsRequired();
            Property(t => t.Discount)
			    .HasColumnName("Discount")
			    .IsRequired();
            Property(t => t.Quantity)
			    .HasColumnName("Quantity")
			    .IsRequired();
            Property(t => t.UnitPrice)
			    .HasColumnName("UnitPrice")
			    .IsRequired();


            HasRequired(t => t.Orders)
                .WithMany(t => t.OrderDetails)
				.HasForeignKey(d =>  d.OrderID);

            HasRequired(t => t.Products)
                .WithMany()
				.HasForeignKey(d =>  d.ProductID);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="OrderStatus"/> to table dbo.OrderStatus
    /// </summary>
    internal abstract class CodeBehindOrderStatusDatabaseMapping : EntityTypeConfiguration<OrderStatus>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindOrderStatusDatabaseMapping()
        {
            ToTable("OrderStatus", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ID")
			    .IsRequired();
            Property(t => t.Name)
			    .HasColumnName("Name");
        }
    }
}

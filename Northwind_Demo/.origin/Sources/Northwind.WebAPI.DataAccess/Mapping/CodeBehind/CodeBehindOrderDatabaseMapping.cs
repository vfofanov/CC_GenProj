﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Order"/> to table dbo.Orders
    /// </summary>
    internal abstract class CodeBehindOrderDatabaseMapping : EntityTypeConfiguration<Order>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindOrderDatabaseMapping()
        {
            ToTable("Orders", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("ID")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.CustomerID)
			    .HasColumnName("CustomerID");
            Property(t => t.EmployeeID)
			    .HasColumnName("EmployeeID");
            Property(t => t.Freight)
			    .HasColumnName("Freight");
            Property(t => t.OrderDate)
			    .HasColumnName("OrderDate");
            Property(t => t.RequiredDate)
			    .HasColumnName("RequiredDate");
            Property(t => t.ShipAddress)
			    .HasColumnName("ShipAddress")
			    .IsUnicode();
            Property(t => t.ShipCity)
			    .HasColumnName("ShipCity")
			    .IsUnicode();
            Property(t => t.ShipCountry)
			    .HasColumnName("ShipCountry")
			    .IsUnicode();
            Property(t => t.ShipName)
			    .HasColumnName("ShipName")
			    .IsUnicode();
            Property(t => t.ShippedDate)
			    .HasColumnName("ShippedDate");
            Property(t => t.ShipPostalCode)
			    .HasColumnName("ShipPostalCode")
			    .IsUnicode();
            Property(t => t.ShipRegion)
			    .HasColumnName("ShipRegion")
			    .IsUnicode();
            Property(t => t.ShipVia)
			    .HasColumnName("ShipVia");
            Property(t => t.StatusID)
			    .HasColumnName("StatusID");


            HasOptional(t => t.Customers)
                .WithMany()
				.HasForeignKey(d =>  d.CustomerID);

            HasOptional(t => t.Employees)
                .WithMany()
				.HasForeignKey(d =>  d.EmployeeID);

            HasOptional(t => t.Shippers)
                .WithMany()
				.HasForeignKey(d =>  d.ShipVia);

            HasOptional(t => t.OrderStatus)
                .WithMany()
				.HasForeignKey(d =>  d.StatusID);

        }
    }
}

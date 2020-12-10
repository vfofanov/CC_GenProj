using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="EmployeeTerritory"/> to table dbo.EmployeeTerritories
    /// </summary>
    internal abstract class CodeBehindEmployeeTerritoryDatabaseMapping : EntityTypeConfiguration<EmployeeTerritory>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindEmployeeTerritoryDatabaseMapping()
        {
            ToTable("EmployeeTerritories", "dbo");

            HasKey(t => new{t.EmployeeID, t.TerritoryID});

            Property(t => t.EmployeeID)
			    .HasColumnName("EmployeeID")
			    .IsRequired();
            Property(t => t.TerritoryID)
			    .HasColumnName("TerritoryID")
			    .IsRequired();


            HasRequired(t => t.Employees)
                .WithMany()
				.HasForeignKey(d =>  d.EmployeeID);

            HasRequired(t => t.Territory)
                .WithMany()
				.HasForeignKey(d =>  d.TerritoryID);

        }
    }
}

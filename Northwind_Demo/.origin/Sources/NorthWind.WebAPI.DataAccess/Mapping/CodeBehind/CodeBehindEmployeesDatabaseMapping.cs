using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping.CodeBehind
{
    /// <summary>
    /// Database mapping for <see cref="Employees"/> to table dbo.Employees
    /// </summary>
    internal abstract class CodeBehindEmployeesDatabaseMapping : EntityTypeConfiguration<Employees>
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        protected CodeBehindEmployeesDatabaseMapping()
        {
            ToTable("Employees", "dbo");

            HasKey(t => t.Id);

            Property(t => t.Id)
			    .HasColumnName("EmployeeID")
			    .IsRequired()
			    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Address)
			    .HasColumnName("Address")
			    .IsUnicode();
            Property(t => t.BirthDate)
			    .HasColumnName("BirthDate");
            Property(t => t.City)
			    .HasColumnName("City")
			    .IsUnicode();
            Property(t => t.Country)
			    .HasColumnName("Country")
			    .IsUnicode();
            Property(t => t.FileLink_DocumentScanFileId)
			    .HasColumnName("DocumentScanFileId");

	        HasOptional(t => t.DocumentScanFileId)
	            .WithMany()
	            .HasForeignKey(d => d.FileLink_DocumentScanFileId);
            Property(t => t.Extension)
			    .HasColumnName("Extension")
			    .IsUnicode();
            Property(t => t.FirstName)
			    .HasColumnName("FirstName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.HireDate)
			    .HasColumnName("HireDate");
            Property(t => t.HomePhone)
			    .HasColumnName("HomePhone")
			    .IsUnicode();
            Property(t => t.LastName)
			    .HasColumnName("LastName")
			    .IsRequired()
			    .IsUnicode();
            Property(t => t.Notes)
			    .HasColumnName("Notes")
			    .IsUnicode();
            Property(t => t.Photo)
			    .HasColumnName("Photo");
            Property(t => t.PhotoPath)
			    .HasColumnName("PhotoPath")
			    .IsUnicode();
            Property(t => t.PostalCode)
			    .HasColumnName("PostalCode")
			    .IsUnicode();
            Property(t => t.Region)
			    .HasColumnName("Region")
			    .IsUnicode();
            Property(t => t.ReportsTo)
			    .HasColumnName("ReportsTo");
            Property(t => t.Title)
			    .HasColumnName("Title")
			    .IsUnicode();
            Property(t => t.TitleOfCourtesy)
			    .HasColumnName("TitleOfCourtesy")
			    .IsUnicode();


            HasOptional(t => t.ReportsToEmployees)
                .WithMany()
				.HasForeignKey(d =>  d.ReportsTo);

        }
    }
}

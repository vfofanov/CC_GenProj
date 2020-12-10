using System;
using System.Collections.Generic;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Files;
using BusinessFramework.WebAPI.Contracts.Files.Storage;
using BusinessFramework.WebAPI.Contracts.Metadata;
using Newtonsoft.Json;
using NorthWind.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.DataObjects
{    
    public partial class EmployeeQuery : ClassicApiEntity<int>, IFileHolder
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.EmployeeQuery; }
        }

        public EmployeeQuery()
		{
		}	
        public virtual string Address { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual string City { get; set; }

        public virtual string Country { get; set; }

        public virtual FileLink DocumentScanFileId { get; set; }

        public virtual string Employee_FullName { get; set; }

        public virtual string Extension { get; set; }

        public virtual string FirstName { get; set; }

        public virtual DateTime? HireDate { get; set; }

        public virtual string HomePhone { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Notes { get; set; }

        public virtual byte[] Photo { get; set; }

        public virtual string PostalCode { get; set; }

        public virtual string Region { get; set; }

        public virtual int? ReportsTo { get; set; }

        public virtual string Title { get; set; }

        public virtual string TitleOfCourtesy { get; set; }

        
		public EmployeeQuery Clone()
        {
            var obj = new EmployeeQuery
            {
                Address = Address,
                BirthDate = BirthDate,
                City = City,
                Country = Country,
                DocumentScanFileId = DocumentScanFileId,
                Employee_FullName = Employee_FullName,
                Extension = Extension,
                FirstName = FirstName,
                HireDate = HireDate,
                HomePhone = HomePhone,
                LastName = LastName,
                Notes = Notes,
                Photo = Photo,
                PostalCode = PostalCode,
                Region = Region,
                ReportsTo = ReportsTo,
                Title = Title,
                TitleOfCourtesy = TitleOfCourtesy,
            };

            return obj;
        }
        

        /// <inheritdoc />
        public IEnumerable<UploadFileLink> GetUploadLinks()
        {
               if (DocumentScanFileId != null && !string.IsNullOrEmpty(DocumentScanFileId.UploadLink))
               {
                   DocumentScanFileId.FieldId = DomainObjectPropertyKeys.EmployeeQuery.DocumentScanFileId;

                   yield return new UploadFileLink(DocumentScanFileId, this);
               }

        }

        /// <inheritdoc />
        public IEnumerable<UploadFileLink> GetFileLinks()
        {
               if (DocumentScanFileId != null)
               {
                   DocumentScanFileId.FieldId = DomainObjectPropertyKeys.EmployeeQuery.DocumentScanFileId;

                   yield return new UploadFileLink(DocumentScanFileId, this);
               }

        }
    }
}
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
    public partial class Employees : ClassicApiEntity<int>, IFileHolder
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Employees; }
        }

        public Employees()
		{
		}	
        public virtual string Address { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual string City { get; set; }

        public virtual string Country { get; set; }

        [JsonIgnore]
        public virtual int? FileLink_DocumentScanFileId { get; set; }

        public void SetDocumentScanFileId(FileData file, IFileStorageSwitcher storageSwitcher, IFileStorageSaveOptionsSwitcher saveOptionsSwitcher)
        {
            DocumentScanFileId = new FileLink
            {
                FileName = file.FileName,
                UploadLink = "#DocumentScanFileId_setter#",
                FieldId = DomainObjectPropertyKeys.Employees.DocumentScanFileId
            };
            storageSwitcher.Create(new UploadFileLink(DocumentScanFileId, this), file, saveOptionsSwitcher);
        }

        public virtual FileLink DocumentScanFileId { get; set; }

        public virtual string Extension { get; set; }

        public virtual string FirstName { get; set; }

        public virtual DateTime? HireDate { get; set; }

        public virtual string HomePhone { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Notes { get; set; }

        public virtual byte[] Photo { get; set; }

        public virtual string PhotoPath { get; set; }

        public virtual string PostalCode { get; set; }

        public virtual string Region { get; set; }

        public virtual int? ReportsTo { get; set; }

        [JsonIgnore]
        public virtual Employees ReportsToEmployees { get; set; }

        public virtual string Title { get; set; }

        public virtual string TitleOfCourtesy { get; set; }

        
		public Employees Clone()
        {
            var obj = new Employees
            {
                Address = Address,
                BirthDate = BirthDate,
                City = City,
                Country = Country,
                FileLink_DocumentScanFileId = FileLink_DocumentScanFileId,
                Extension = Extension,
                FirstName = FirstName,
                HireDate = HireDate,
                HomePhone = HomePhone,
                LastName = LastName,
                Notes = Notes,
                Photo = Photo,
                PhotoPath = PhotoPath,
                PostalCode = PostalCode,
                Region = Region,
                ReportsTo = ReportsTo,
                Title = Title,
                TitleOfCourtesy = TitleOfCourtesy,
            };

            if (IsNew())
            {
                if(ReportsToEmployees != null && ReportsToEmployees.IsNew())  
                {
                   obj.ReportsToEmployees = ReportsToEmployees;
                }
            }
            return obj;
        }
        

        /// <inheritdoc />
        public IEnumerable<UploadFileLink> GetUploadLinks()
        {
               if (DocumentScanFileId != null && !string.IsNullOrEmpty(DocumentScanFileId.UploadLink))
               {
                   DocumentScanFileId.FieldId = DomainObjectPropertyKeys.Employees.DocumentScanFileId;

                   yield return new UploadFileLink(DocumentScanFileId, this);
               }

        }

        /// <inheritdoc />
        public IEnumerable<UploadFileLink> GetFileLinks()
        {
               if (DocumentScanFileId != null)
               {
                   DocumentScanFileId.FieldId = DomainObjectPropertyKeys.Employees.DocumentScanFileId;

                   yield return new UploadFileLink(DocumentScanFileId, this);
               }

        }
    }
}
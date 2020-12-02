using System;
using System.Collections.Generic;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Metadata;
using Newtonsoft.Json;
using Northwind.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.DataObjects
{    
    public partial class QEmployees : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.QEmployees; }
        }

        public QEmployees()
		{
		}	
        public virtual string Address { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual string City { get; set; }

        public virtual string Country { get; set; }

        public virtual string Employee_FullName { get; set; }

        public virtual string Extension { get; set; }

        public virtual string FirstName { get; set; }

        public virtual DateTime? HireDate { get; set; }

        public virtual string HomePhone { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Notes { get; set; }

        public virtual string PostalCode { get; set; }

        public virtual string Region { get; set; }

        public virtual int? ReportsTo { get; set; }

        public virtual string Title { get; set; }

        public virtual string TitleOfCourtesy { get; set; }

        
		public QEmployees Clone()
        {
            var obj = new QEmployees
            {
                Address = Address,
                BirthDate = BirthDate,
                City = City,
                Country = Country,
                Employee_FullName = Employee_FullName,
                Extension = Extension,
                FirstName = FirstName,
                HireDate = HireDate,
                HomePhone = HomePhone,
                LastName = LastName,
                Notes = Notes,
                PostalCode = PostalCode,
                Region = Region,
                ReportsTo = ReportsTo,
                Title = Title,
                TitleOfCourtesy = TitleOfCourtesy,
            };

            return obj;
        }
    }
}
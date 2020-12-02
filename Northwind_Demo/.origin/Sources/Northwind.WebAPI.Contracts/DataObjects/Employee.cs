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
    public partial class Employee : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Employee; }
        }

        public Employee()
		{
		}	
        public virtual string Address { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual string City { get; set; }

        public virtual string Country { get; set; }

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
        public virtual Employee ReportsToEmployee { get; set; }

        public virtual string Title { get; set; }

        public virtual string TitleOfCourtesy { get; set; }

        
		public Employee Clone()
        {
            var obj = new Employee
            {
                Address = Address,
                BirthDate = BirthDate,
                City = City,
                Country = Country,
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
                if(ReportsToEmployee != null && ReportsToEmployee.IsNew())  
                {
                   obj.ReportsToEmployee = ReportsToEmployee;
                }
            }
            return obj;
        }
    }
}
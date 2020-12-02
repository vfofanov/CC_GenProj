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
    public partial class Supplier : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Supplier; }
        }

        public Supplier()
		{
		}	
        public virtual string Address { get; set; }

        public virtual string City { get; set; }

        public virtual string CompanyName { get; set; }

        public virtual string ContactName { get; set; }

        public virtual string ContactTitle { get; set; }

        public virtual string Country { get; set; }

        public virtual string Fax { get; set; }

        public virtual string HomePage { get; set; }

        public virtual string Phone { get; set; }

        public virtual string PostalCode { get; set; }

        public virtual string Region { get; set; }

        
		public Supplier Clone()
        {
            var obj = new Supplier
            {
                Address = Address,
                City = City,
                CompanyName = CompanyName,
                ContactName = ContactName,
                ContactTitle = ContactTitle,
                Country = Country,
                Fax = Fax,
                HomePage = HomePage,
                Phone = Phone,
                PostalCode = PostalCode,
                Region = Region,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}
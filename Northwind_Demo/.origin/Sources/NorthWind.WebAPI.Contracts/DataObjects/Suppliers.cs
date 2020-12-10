using System;
using System.Collections.Generic;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Metadata;
using Newtonsoft.Json;
using NorthWind.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.DataObjects
{    
    public partial class Suppliers : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Suppliers; }
        }

        public Suppliers()
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

        
		public Suppliers Clone()
        {
            var obj = new Suppliers
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
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
    public partial class Shipper : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Shipper; }
        }

        public Shipper()
		{
		}	
        public virtual string CompanyName { get; set; }

        public virtual string Phone { get; set; }

        
		public Shipper Clone()
        {
            var obj = new Shipper
            {
                CompanyName = CompanyName,
                Phone = Phone,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}
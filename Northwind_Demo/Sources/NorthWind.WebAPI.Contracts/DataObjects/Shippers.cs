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
    public partial class Shippers : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Shippers; }
        }

        public Shippers()
		{
		}	
        public virtual string CompanyName { get; set; }

        public virtual string Phone { get; set; }

        
		public Shippers Clone()
        {
            var obj = new Shippers
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
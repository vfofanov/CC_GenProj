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
    public partial class ShipperQuery : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.ShipperQuery; }
        }

        public ShipperQuery()
		{
		}	
        public virtual string CompanyName { get; set; }

        public virtual string Phone { get; set; }

        
		public ShipperQuery Clone()
        {
            var obj = new ShipperQuery
            {
                CompanyName = CompanyName,
                Phone = Phone,
            };

            return obj;
        }
    }
}
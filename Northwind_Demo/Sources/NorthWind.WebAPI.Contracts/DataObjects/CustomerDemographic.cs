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
    public partial class CustomerDemographic : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.CustomerDemographic; }
        }

        public CustomerDemographic()
		{
		}	
        public virtual string CustomerDesc { get; set; }

        
		public CustomerDemographic Clone()
        {
            var obj = new CustomerDemographic
            {
                CustomerDesc = CustomerDesc,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}
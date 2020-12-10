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
    public partial class CustomerCustomerDemo : AbstractApiEntity<CustomerCustomerDemoKey>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.CustomerCustomerDemo; }
        }

        public CustomerCustomerDemo()
		{
		}	
        public virtual int CustomerID { get; set; }

        public virtual int CustomerTypeID { get; set; }

        [JsonIgnore]
        public virtual CustomerDemographic CustomerDemographic { get; set; }

        [JsonIgnore]
        public virtual Customers Customers { get; set; }

        public override CustomerCustomerDemoKey GetKey()
        {
            return new CustomerCustomerDemoKey(CustomerID, CustomerTypeID);
            
        }
        
		public bool IsNew()
        {
		    return Equals(CustomerID, default(int)) && Equals(CustomerTypeID, default(int));
        }
        
		public CustomerCustomerDemo Clone()
        {
            var obj = new CustomerCustomerDemo
            {
            };

            return obj;
        }
    }
}
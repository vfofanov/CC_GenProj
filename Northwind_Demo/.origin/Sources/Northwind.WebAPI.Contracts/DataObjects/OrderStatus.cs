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
    public partial class OrderStatus : ClassicApiEntity<short>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.OrderStatus; }
        }

        public OrderStatus()
		{
		}	
        public virtual string Name { get; set; }

        
		public OrderStatus Clone()
        {
            var obj = new OrderStatus
            {
                Name = Name,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}
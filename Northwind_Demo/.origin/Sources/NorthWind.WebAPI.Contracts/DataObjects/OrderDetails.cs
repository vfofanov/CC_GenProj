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
    public partial class OrderDetails : AbstractApiEntity<OrderDetailsKey>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.OrderDetails; }
        }

        public OrderDetails()
		{
            Discount = 0;
            Quantity = 1;
		}	
        public virtual int OrderID { get; set; }

        public virtual int ProductID { get; set; }

        public virtual float Discount { get; set; }

        [JsonIgnore]
        public virtual Orders Orders { get; set; }

        [JsonIgnore]
        public virtual Products Products { get; set; }

        public virtual short Quantity { get; set; }

        public virtual decimal UnitPrice { get; set; }

        public override OrderDetailsKey GetKey()
        {
            return new OrderDetailsKey(OrderID, ProductID);
            
        }
        
		public bool IsNew()
        {
		    return Equals(OrderID, default(int)) && Equals(ProductID, default(int));
        }
        
		public OrderDetails Clone()
        {
            var obj = new OrderDetails
            {
                Discount = Discount,
                Quantity = Quantity,
                UnitPrice = UnitPrice,
            };

            return obj;
        }
    }
}
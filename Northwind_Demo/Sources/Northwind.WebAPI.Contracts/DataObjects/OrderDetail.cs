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
    public partial class OrderDetail : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.OrderDetail; }
        }

        public OrderDetail()
		{
            Discount = 0;
            Quantity = 1;
		}	
        public virtual float Discount { get; set; }

        public virtual int OrderID { get; set; }

        [JsonIgnore]
        public virtual Order Orders { get; set; }

        public virtual int ProductID { get; set; }

        [JsonIgnore]
        public virtual Product Products { get; set; }

        public virtual short Quantity { get; set; }

        public virtual decimal UnitPrice { get; set; }

        
		public OrderDetail Clone()
        {
            var obj = new OrderDetail
            {
                Discount = Discount,
                OrderID = OrderID,
                ProductID = ProductID,
                Quantity = Quantity,
                UnitPrice = UnitPrice,
            };

            if (IsNew())
            {
                if(Orders != null && Orders.IsNew())  
                {
                   obj.Orders = Orders;
                }
                if(Products != null && Products.IsNew())  
                {
                   obj.Products = Products;
                }
            }
            return obj;
        }
    }
}
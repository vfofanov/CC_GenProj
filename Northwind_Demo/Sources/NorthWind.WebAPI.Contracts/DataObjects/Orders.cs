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
    public partial class Orders : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Orders; }
        }

        public Orders()
		{
            OrderDate = DateTime.Now;
		}	
        public virtual int CustomerID { get; set; }

        [JsonIgnore]
        public virtual Customers Customers { get; set; }

        public virtual int? EmployeeID { get; set; }

        [JsonIgnore]
        public virtual Employees Employees { get; set; }

        public virtual decimal? Freight { get; set; }

        public virtual DateTime? OrderDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual DateTime? RequiredDate { get; set; }

        public virtual string ShipAddress { get; set; }

        public virtual string ShipCity { get; set; }

        public virtual string ShipCountry { get; set; }

        public virtual string ShipName { get; set; }

        public virtual DateTime? ShippedDate { get; set; }

        [JsonIgnore]
        public virtual Shippers Shippers { get; set; }

        public virtual string ShipPostalCode { get; set; }

        public virtual string ShipRegion { get; set; }

        public virtual int? ShipVia { get; set; }

        
		public Orders Clone()
        {
            var obj = new Orders
            {
                CustomerID = CustomerID,
                EmployeeID = EmployeeID,
                Freight = Freight,
                OrderDate = OrderDate,
                RequiredDate = RequiredDate,
                ShipAddress = ShipAddress,
                ShipCity = ShipCity,
                ShipCountry = ShipCountry,
                ShipName = ShipName,
                ShippedDate = ShippedDate,
                ShipPostalCode = ShipPostalCode,
                ShipRegion = ShipRegion,
                ShipVia = ShipVia,
            };

            if (IsNew())
            {
                if(Customers != null && Customers.IsNew())  
                {
                   obj.Customers = Customers;
                }
                if(Employees != null && Employees.IsNew())  
                {
                   obj.Employees = Employees;
                }
                if(Shippers != null && Shippers.IsNew())  
                {
                   obj.Shippers = Shippers;
                }
            }
            return obj;
        }
    }
}
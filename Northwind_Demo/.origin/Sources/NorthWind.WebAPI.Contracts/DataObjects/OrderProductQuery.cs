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
    public partial class OrderProductQuery : AbstractApiEntity<OrderProductQueryKey>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.OrderProductQuery; }
        }

        public OrderProductQuery()
		{
		}	
        public virtual int Id { get; set; }

        public virtual int OrderID { get; set; }

        public virtual int ProductID { get; set; }

        public virtual float Discount { get; set; }

        public virtual int Orders_CustomerID { get; set; }

        public virtual int? Orders_EmployeeID { get; set; }

        public virtual decimal? Orders_Freight { get; set; }

        public virtual int Orders_Id { get; set; }

        public virtual DateTime? Orders_OrderDate { get; set; }

        public virtual DateTime? Orders_RequiredDate { get; set; }

        public virtual string Orders_ShipAddress { get; set; }

        public virtual string Orders_ShipCity { get; set; }

        public virtual string Orders_ShipCountry { get; set; }

        public virtual string Orders_ShipName { get; set; }

        public virtual DateTime? Orders_ShippedDate { get; set; }

        public virtual string Orders_ShipPostalCode { get; set; }

        public virtual string Orders_ShipRegion { get; set; }

        public virtual int? Orders_ShipVia { get; set; }

        public virtual int? Products_CategoryID { get; set; }

        public virtual bool Products_Discontinued { get; set; }

        public virtual int Products_Id { get; set; }

        public virtual string Products_ProductName { get; set; }

        public virtual string Products_QuantityPerUnit { get; set; }

        public virtual short? Products_ReorderLevel { get; set; }

        public virtual int? Products_SupplierID { get; set; }

        public virtual decimal? Products_UnitPrice { get; set; }

        public virtual short? Products_UnitsInStock { get; set; }

        public virtual short? Products_UnitsOnOrder { get; set; }

        public virtual short Quantity { get; set; }

        public virtual decimal UnitPrice { get; set; }

        public override OrderProductQueryKey GetKey()
        {
            return new OrderProductQueryKey(Id, OrderID, ProductID);
            
        }
        
		public bool IsNew()
        {
		    return Equals(Id, default(int)) && Equals(OrderID, default(int)) && Equals(ProductID, default(int));
        }
        
		public OrderProductQuery Clone()
        {
            var obj = new OrderProductQuery
            {
                Discount = Discount,
                Orders_CustomerID = Orders_CustomerID,
                Orders_EmployeeID = Orders_EmployeeID,
                Orders_Freight = Orders_Freight,
                Orders_Id = Orders_Id,
                Orders_OrderDate = Orders_OrderDate,
                Orders_RequiredDate = Orders_RequiredDate,
                Orders_ShipAddress = Orders_ShipAddress,
                Orders_ShipCity = Orders_ShipCity,
                Orders_ShipCountry = Orders_ShipCountry,
                Orders_ShipName = Orders_ShipName,
                Orders_ShippedDate = Orders_ShippedDate,
                Orders_ShipPostalCode = Orders_ShipPostalCode,
                Orders_ShipRegion = Orders_ShipRegion,
                Orders_ShipVia = Orders_ShipVia,
                Products_CategoryID = Products_CategoryID,
                Products_Discontinued = Products_Discontinued,
                Products_Id = Products_Id,
                Products_ProductName = Products_ProductName,
                Products_QuantityPerUnit = Products_QuantityPerUnit,
                Products_ReorderLevel = Products_ReorderLevel,
                Products_SupplierID = Products_SupplierID,
                Products_UnitPrice = Products_UnitPrice,
                Products_UnitsInStock = Products_UnitsInStock,
                Products_UnitsOnOrder = Products_UnitsOnOrder,
                Quantity = Quantity,
                UnitPrice = UnitPrice,
            };

            return obj;
        }
    }
}
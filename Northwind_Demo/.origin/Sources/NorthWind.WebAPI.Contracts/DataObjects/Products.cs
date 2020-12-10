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
    public partial class Products : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Products; }
        }

        public Products()
		{
            Discontinued = false;
            ReorderLevel = 0;
            UnitsInStock = 0;
            UnitsOnOrder = 0;
		}	
        [JsonIgnore]
        public virtual Categories Categories { get; set; }

        public virtual int? CategoryID { get; set; }

        public virtual bool Discontinued { get; set; }

        public virtual string ProductName { get; set; }

        public virtual string QuantityPerUnit { get; set; }

        public virtual short? ReorderLevel { get; set; }

        public virtual int? SupplierID { get; set; }

        [JsonIgnore]
        public virtual Suppliers Suppliers { get; set; }

        public virtual decimal? UnitPrice { get; set; }

        public virtual short? UnitsInStock { get; set; }

        public virtual short? UnitsOnOrder { get; set; }

        
		public Products Clone()
        {
            var obj = new Products
            {
                CategoryID = CategoryID,
                Discontinued = Discontinued,
                ProductName = ProductName,
                QuantityPerUnit = QuantityPerUnit,
                ReorderLevel = ReorderLevel,
                SupplierID = SupplierID,
                UnitPrice = UnitPrice,
                UnitsInStock = UnitsInStock,
                UnitsOnOrder = UnitsOnOrder,
            };

            if (IsNew())
            {
                if(Categories != null && Categories.IsNew())  
                {
                   obj.Categories = Categories;
                }
                if(Suppliers != null && Suppliers.IsNew())  
                {
                   obj.Suppliers = Suppliers;
                }
            }
            return obj;
        }
    }
}
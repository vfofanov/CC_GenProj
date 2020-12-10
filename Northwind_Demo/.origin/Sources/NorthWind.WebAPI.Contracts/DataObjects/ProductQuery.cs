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
    public partial class ProductQuery : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.ProductQuery; }
        }

        public ProductQuery()
		{
		}	
        public virtual string Categories_CategoryName { get; set; }

        public virtual string Categories_Description { get; set; }

        public virtual int? Categories_Id { get; set; }

        public virtual int? CategoryID { get; set; }

        public virtual bool Discontinued { get; set; }

        public virtual string ProductName { get; set; }

        public virtual string QuantityPerUnit { get; set; }

        public virtual short? ReorderLevel { get; set; }

        public virtual int? SupplierID { get; set; }

        public virtual string Suppliers_Address { get; set; }

        public virtual string Suppliers_City { get; set; }

        public virtual string Suppliers_CompanyName { get; set; }

        public virtual string Suppliers_ContactName { get; set; }

        public virtual string Suppliers_ContactTitle { get; set; }

        public virtual string Suppliers_Country { get; set; }

        public virtual string Suppliers_Fax { get; set; }

        public virtual string Suppliers_HomePage { get; set; }

        public virtual int? Suppliers_Id { get; set; }

        public virtual string Suppliers_Phone { get; set; }

        public virtual string Suppliers_PostalCode { get; set; }

        public virtual string Suppliers_Region { get; set; }

        public virtual decimal? UnitPrice { get; set; }

        public virtual short? UnitsInStock { get; set; }

        public virtual short? UnitsOnOrder { get; set; }

        
		public ProductQuery Clone()
        {
            var obj = new ProductQuery
            {
                Categories_CategoryName = Categories_CategoryName,
                Categories_Description = Categories_Description,
                Categories_Id = Categories_Id,
                CategoryID = CategoryID,
                Discontinued = Discontinued,
                ProductName = ProductName,
                QuantityPerUnit = QuantityPerUnit,
                ReorderLevel = ReorderLevel,
                SupplierID = SupplierID,
                Suppliers_Address = Suppliers_Address,
                Suppliers_City = Suppliers_City,
                Suppliers_CompanyName = Suppliers_CompanyName,
                Suppliers_ContactName = Suppliers_ContactName,
                Suppliers_ContactTitle = Suppliers_ContactTitle,
                Suppliers_Country = Suppliers_Country,
                Suppliers_Fax = Suppliers_Fax,
                Suppliers_HomePage = Suppliers_HomePage,
                Suppliers_Id = Suppliers_Id,
                Suppliers_Phone = Suppliers_Phone,
                Suppliers_PostalCode = Suppliers_PostalCode,
                Suppliers_Region = Suppliers_Region,
                UnitPrice = UnitPrice,
                UnitsInStock = UnitsInStock,
                UnitsOnOrder = UnitsOnOrder,
            };

            return obj;
        }
    }
}
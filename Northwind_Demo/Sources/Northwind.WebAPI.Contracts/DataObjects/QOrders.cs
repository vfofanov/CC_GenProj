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
    public partial class QOrders : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.QOrders; }
        }

        public QOrders()
		{
		}	
        public virtual int? CustomerID { get; set; }

        public virtual string Customers_Address { get; set; }

        public virtual string Customers_City { get; set; }

        public virtual string Customers_CompanyName { get; set; }

        public virtual string Customers_ContactName { get; set; }

        public virtual string Customers_ContactTitle { get; set; }

        public virtual string Customers_Country { get; set; }

        public virtual string Customers_Fax { get; set; }

        public virtual int? Customers_Id { get; set; }

        public virtual string Customers_Phone { get; set; }

        public virtual string Customers_PostalCode { get; set; }

        public virtual string Customers_Region { get; set; }

        public virtual string EmployeeFullName { get; set; }

        public virtual int? EmployeeID { get; set; }

        public virtual string Employees_Address { get; set; }

        public virtual DateTime? Employees_BirthDate { get; set; }

        public virtual string Employees_City { get; set; }

        public virtual string Employees_Country { get; set; }

        public virtual string Employees_Extension { get; set; }

        public virtual string Employees_FirstName { get; set; }

        public virtual DateTime? Employees_HireDate { get; set; }

        public virtual string Employees_HomePhone { get; set; }

        public virtual int? Employees_Id { get; set; }

        public virtual string Employees_LastName { get; set; }

        public virtual string Employees_Notes { get; set; }

        public virtual string Employees_PhotoPath { get; set; }

        public virtual string Employees_PostalCode { get; set; }

        public virtual string Employees_Region { get; set; }

        public virtual int? Employees_ReportsTo { get; set; }

        public virtual string Employees_Title { get; set; }

        public virtual string Employees_TitleOfCourtesy { get; set; }

        public virtual decimal? Freight { get; set; }

        public virtual DateTime? OrderDate { get; set; }

        public virtual DateTime? RequiredDate { get; set; }

        public virtual string ShipAddress { get; set; }

        public virtual string ShipCity { get; set; }

        public virtual string ShipCountry { get; set; }

        public virtual string ShipName { get; set; }

        public virtual DateTime? ShippedDate { get; set; }

        public virtual string Shippers_CompanyName { get; set; }

        public virtual int? Shippers_Id { get; set; }

        public virtual string Shippers_Phone { get; set; }

        public virtual string ShipPostalCode { get; set; }

        public virtual string ShipRegion { get; set; }

        public virtual int? ShipVia { get; set; }

        
		public QOrders Clone()
        {
            var obj = new QOrders
            {
                CustomerID = CustomerID,
                Customers_Address = Customers_Address,
                Customers_City = Customers_City,
                Customers_CompanyName = Customers_CompanyName,
                Customers_ContactName = Customers_ContactName,
                Customers_ContactTitle = Customers_ContactTitle,
                Customers_Country = Customers_Country,
                Customers_Fax = Customers_Fax,
                Customers_Id = Customers_Id,
                Customers_Phone = Customers_Phone,
                Customers_PostalCode = Customers_PostalCode,
                Customers_Region = Customers_Region,
                EmployeeFullName = EmployeeFullName,
                EmployeeID = EmployeeID,
                Employees_Address = Employees_Address,
                Employees_BirthDate = Employees_BirthDate,
                Employees_City = Employees_City,
                Employees_Country = Employees_Country,
                Employees_Extension = Employees_Extension,
                Employees_FirstName = Employees_FirstName,
                Employees_HireDate = Employees_HireDate,
                Employees_HomePhone = Employees_HomePhone,
                Employees_Id = Employees_Id,
                Employees_LastName = Employees_LastName,
                Employees_Notes = Employees_Notes,
                Employees_PhotoPath = Employees_PhotoPath,
                Employees_PostalCode = Employees_PostalCode,
                Employees_Region = Employees_Region,
                Employees_ReportsTo = Employees_ReportsTo,
                Employees_Title = Employees_Title,
                Employees_TitleOfCourtesy = Employees_TitleOfCourtesy,
                Freight = Freight,
                OrderDate = OrderDate,
                RequiredDate = RequiredDate,
                ShipAddress = ShipAddress,
                ShipCity = ShipCity,
                ShipCountry = ShipCountry,
                ShipName = ShipName,
                ShippedDate = ShippedDate,
                Shippers_CompanyName = Shippers_CompanyName,
                Shippers_Id = Shippers_Id,
                Shippers_Phone = Shippers_Phone,
                ShipPostalCode = ShipPostalCode,
                ShipRegion = ShipRegion,
                ShipVia = ShipVia,
            };

            return obj;
        }
    }
}
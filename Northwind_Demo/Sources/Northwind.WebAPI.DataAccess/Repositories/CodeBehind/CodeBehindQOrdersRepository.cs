using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using Northwind.Contracts;
using Northwind.Contracts.Enums;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindQOrdersRepository"/> objects
    /// </summary>
    public abstract class CodeBehindQOrdersRepository : ClassicQueryRepository<QOrders, int, Order, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindQOrdersRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QOrders> ApplySorting(IQueryable<QOrders> source)
        {
            return source.OrderByDescending(o => o.OrderDate);
        }

        /// <summary>
        /// Select <see cref="QOrders"/> objects from <see cref="Order"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QOrders> Set(IQueryable<Order> source)
        {
            return source.Select(o => new QOrders
            {
					Id = o.Id,
					CustomerID = o.CustomerID,
					Customers_Address = o.Customers == null ? default(string) : o.Customers.Address,
					Customers_City = o.Customers == null ? default(string) : o.Customers.City,
					Customers_CompanyName = o.Customers == null ? default(string) : o.Customers.CompanyName,
					Customers_ContactName = o.Customers == null ? default(string) : o.Customers.ContactName,
					Customers_ContactTitle = o.Customers == null ? default(string) : o.Customers.ContactTitle,
					Customers_Country = o.Customers == null ? default(string) : o.Customers.Country,
					Customers_Fax = o.Customers == null ? default(string) : o.Customers.Fax,
					Customers_Id = o.Customers == null ? default(int?) : o.Customers.Id,
					Customers_Phone = o.Customers == null ? default(string) : o.Customers.Phone,
					Customers_PostalCode = o.Customers == null ? default(string) : o.Customers.PostalCode,
					Customers_Region = o.Customers == null ? default(string) : o.Customers.Region,
					EmployeeFullName = (o.Employees.FirstName ?? string.Empty) + " " + (o.Employees.LastName ?? string.Empty),
					EmployeeID = o.EmployeeID,
					Employees_Address = o.Employees == null ? default(string) : o.Employees.Address,
					Employees_BirthDate = o.Employees == null ? default(DateTime?) : o.Employees.BirthDate,
					Employees_City = o.Employees == null ? default(string) : o.Employees.City,
					Employees_Country = o.Employees == null ? default(string) : o.Employees.Country,
					Employees_Extension = o.Employees == null ? default(string) : o.Employees.Extension,
					Employees_FirstName = o.Employees == null ? default(string) : o.Employees.FirstName,
					Employees_HireDate = o.Employees == null ? default(DateTime?) : o.Employees.HireDate,
					Employees_HomePhone = o.Employees == null ? default(string) : o.Employees.HomePhone,
					Employees_Id = o.Employees == null ? default(int?) : o.Employees.Id,
					Employees_LastName = o.Employees == null ? default(string) : o.Employees.LastName,
					Employees_Notes = o.Employees == null ? default(string) : o.Employees.Notes,
					Employees_PhotoPath = o.Employees == null ? default(string) : o.Employees.PhotoPath,
					Employees_PostalCode = o.Employees == null ? default(string) : o.Employees.PostalCode,
					Employees_Region = o.Employees == null ? default(string) : o.Employees.Region,
					Employees_ReportsTo = o.Employees == null ? default(int?) : o.Employees.ReportsTo,
					Employees_Title = o.Employees == null ? default(string) : o.Employees.Title,
					Employees_TitleOfCourtesy = o.Employees == null ? default(string) : o.Employees.TitleOfCourtesy,
					Freight = o.Freight,
					OrderDate = o.OrderDate,
					RequiredDate = o.RequiredDate,
					ShipAddress = o.ShipAddress,
					ShipCity = o.ShipCity,
					ShipCountry = o.ShipCountry,
					ShipName = o.ShipName,
					ShippedDate = o.ShippedDate,
					Shippers_CompanyName = o.Shippers == null ? default(string) : o.Shippers.CompanyName,
					Shippers_Id = o.Shippers == null ? default(int?) : o.Shippers.Id,
					Shippers_Phone = o.Shippers == null ? default(string) : o.Shippers.Phone,
					ShipPostalCode = o.ShipPostalCode,
					ShipRegion = o.ShipRegion,
					ShipVia = o.ShipVia,
  
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QOrders Create(QOrders entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QOrders Update(QOrders entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(int key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(QOrders entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Save()
        {
            Context.SaveChanges();
        }
    }
}
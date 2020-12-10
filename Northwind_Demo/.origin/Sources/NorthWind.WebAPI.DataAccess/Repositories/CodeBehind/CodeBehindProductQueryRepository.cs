using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindProductQueryRepository"/> objects
    /// </summary>
    public abstract class CodeBehindProductQueryRepository : ClassicQueryRepository<ProductQuery, int, Products, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindProductQueryRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Select <see cref="ProductQuery"/> objects from <see cref="Products"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<ProductQuery> Set(IQueryable<Products> source)
        {
            return source.Select(o => new ProductQuery
            {
					Id = o.Id,
					Categories_CategoryName = o.Categories == null ? default(string) : o.Categories.CategoryName,
					Categories_Description = o.Categories == null ? default(string) : o.Categories.Description,
					Categories_Id = o.Categories == null ? default(int?) : o.Categories.Id,
					CategoryID = o.CategoryID,
					Discontinued = o.Discontinued,
					ProductName = o.ProductName,
					QuantityPerUnit = o.QuantityPerUnit,
					ReorderLevel = o.ReorderLevel,
					SupplierID = o.SupplierID,
					Suppliers_Address = o.Suppliers == null ? default(string) : o.Suppliers.Address,
					Suppliers_City = o.Suppliers == null ? default(string) : o.Suppliers.City,
					Suppliers_CompanyName = o.Suppliers == null ? default(string) : o.Suppliers.CompanyName,
					Suppliers_ContactName = o.Suppliers == null ? default(string) : o.Suppliers.ContactName,
					Suppliers_ContactTitle = o.Suppliers == null ? default(string) : o.Suppliers.ContactTitle,
					Suppliers_Country = o.Suppliers == null ? default(string) : o.Suppliers.Country,
					Suppliers_Fax = o.Suppliers == null ? default(string) : o.Suppliers.Fax,
					Suppliers_HomePage = o.Suppliers == null ? default(string) : o.Suppliers.HomePage,
					Suppliers_Id = o.Suppliers == null ? default(int?) : o.Suppliers.Id,
					Suppliers_Phone = o.Suppliers == null ? default(string) : o.Suppliers.Phone,
					Suppliers_PostalCode = o.Suppliers == null ? default(string) : o.Suppliers.PostalCode,
					Suppliers_Region = o.Suppliers == null ? default(string) : o.Suppliers.Region,
					UnitPrice = o.UnitPrice,
					UnitsInStock = o.UnitsInStock,
					UnitsOnOrder = o.UnitsOnOrder,
  
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override ProductQuery Create(ProductQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override ProductQuery Update(ProductQuery entity)
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
        public override void Delete(ProductQuery entity)
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
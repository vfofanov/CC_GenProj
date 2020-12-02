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
    /// Repository for <see cref="CodeBehindQOrderProductsRepository"/> objects
    /// </summary>
    public abstract class CodeBehindQOrderProductsRepository : ClassicQueryRepository<QOrderProducts, int, OrderDetail, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindQOrderProductsRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QOrderProducts> ApplySorting(IQueryable<QOrderProducts> source)
        {
            return source.OrderBy(o => o.Products_ProductName);
        }

        /// <summary>
        /// Select <see cref="QOrderProducts"/> objects from <see cref="OrderDetail"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QOrderProducts> Set(IQueryable<OrderDetail> source)
        {
            return source.Select(o => new QOrderProducts
            {
					Id = o.Id,
					Discount = o.Discount,
					OrderID = o.OrderID,
					Orders_CustomerID = o.Orders.CustomerID,
					Orders_EmployeeID = o.Orders.EmployeeID,
					Orders_Freight = o.Orders.Freight,
					Orders_Id = o.Orders.Id,
					Orders_OrderDate = o.Orders.OrderDate,
					Orders_RequiredDate = o.Orders.RequiredDate,
					Orders_ShipAddress = o.Orders.ShipAddress,
					Orders_ShipCity = o.Orders.ShipCity,
					Orders_ShipCountry = o.Orders.ShipCountry,
					Orders_ShipName = o.Orders.ShipName,
					Orders_ShippedDate = o.Orders.ShippedDate,
					Orders_ShipPostalCode = o.Orders.ShipPostalCode,
					Orders_ShipRegion = o.Orders.ShipRegion,
					Orders_ShipVia = o.Orders.ShipVia,
					ProductID = o.ProductID,
					Products_CategoryID = o.Products.CategoryID,
					Products_Discontinued = o.Products.Discontinued,
					Products_Id = o.Products.Id,
					Products_ProductName = o.Products.ProductName,
					Products_QuantityPerUnit = o.Products.QuantityPerUnit,
					Products_ReorderLevel = o.Products.ReorderLevel,
					Products_SupplierID = o.Products.SupplierID,
					Products_UnitPrice = o.Products.UnitPrice,
					Products_UnitsInStock = o.Products.UnitsInStock,
					Products_UnitsOnOrder = o.Products.UnitsOnOrder,
					Quantity = o.Quantity,
					UnitPrice = o.UnitPrice,
  
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QOrderProducts Create(QOrderProducts entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QOrderProducts Update(QOrderProducts entity)
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
        public override void Delete(QOrderProducts entity)
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
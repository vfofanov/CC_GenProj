using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.DataObjects;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindOrderProductQueryRepository"/> objects
    /// </summary>
    public abstract class CodeBehindOrderProductQueryRepository : QueryRepository<OrderProductQuery, OrderProductQueryKey, OrderDetails, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindOrderProductQueryRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<OrderProductQuery> ApplySorting(IQueryable<OrderProductQuery> source)
        {
            return source.OrderBy(o => o.Products_ProductName);
        }

        /// <summary>
        /// Select <see cref="OrderProductQuery"/> objects from <see cref="OrderDetails"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<OrderProductQuery> Set(IQueryable<OrderDetails> source)
        {
            return source.Select(o => new OrderProductQuery
            {
					Id = o.OrderID,
					OrderID = o.OrderID,
					ProductID = o.ProductID,
					Discount = o.Discount,
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


        /// <inheritdoc />
        public override OrderProductQuery GetByKey(OrderProductQueryKey key)
        {
            return Set().FirstOrDefault(entity => entity.Id == key.Id && entity.OrderID == key.OrderID && entity.ProductID == key.ProductID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override OrderProductQuery Create(OrderProductQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override OrderProductQuery Update(OrderProductQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(OrderProductQueryKey key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(OrderProductQuery entity)
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
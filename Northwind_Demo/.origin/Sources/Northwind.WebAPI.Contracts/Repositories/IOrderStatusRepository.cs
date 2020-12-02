using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="OrderStatus"/> entity
    /// </summary>
    public interface IOrderStatusRepository : IClassicEntityRepository<OrderStatus, short>
    {
    }
}
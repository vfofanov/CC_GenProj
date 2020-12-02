using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Order"/> entity
    /// </summary>
    public interface IOrderRepository : IClassicEntityRepository<Order, int>
    {
    }
}
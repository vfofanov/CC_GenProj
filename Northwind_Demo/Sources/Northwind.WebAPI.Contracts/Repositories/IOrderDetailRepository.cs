using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="OrderDetail"/> entity
    /// </summary>
    public interface IOrderDetailRepository : IClassicEntityRepository<OrderDetail, int>
    {
    }
}
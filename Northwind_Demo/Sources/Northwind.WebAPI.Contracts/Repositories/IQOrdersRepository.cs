using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QOrders"/> entity
    /// </summary>
    public interface IQOrdersRepository : IClassicQueryRepository<QOrders, int>
    {
    }
}
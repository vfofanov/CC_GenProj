using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QCustomers"/> entity
    /// </summary>
    public interface IQCustomersRepository : IClassicQueryRepository<QCustomers, int>
    {
    }
}
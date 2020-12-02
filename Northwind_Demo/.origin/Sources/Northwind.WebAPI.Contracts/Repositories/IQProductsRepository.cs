using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QProducts"/> entity
    /// </summary>
    public interface IQProductsRepository : IClassicQueryRepository<QProducts, int>
    {
    }
}
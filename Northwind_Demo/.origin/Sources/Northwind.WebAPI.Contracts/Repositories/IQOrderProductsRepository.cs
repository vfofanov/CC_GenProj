using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QOrderProducts"/> entity
    /// </summary>
    public interface IQOrderProductsRepository : IClassicQueryRepository<QOrderProducts, int>
    {
    }
}
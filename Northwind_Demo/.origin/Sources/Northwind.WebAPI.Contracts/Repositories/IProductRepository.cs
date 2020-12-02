using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Product"/> entity
    /// </summary>
    public interface IProductRepository : IClassicEntityRepository<Product, int>
    {
    }
}
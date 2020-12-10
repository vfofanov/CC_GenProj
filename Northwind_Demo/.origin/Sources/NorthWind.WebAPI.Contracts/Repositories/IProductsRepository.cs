using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Products"/> entity
    /// </summary>
    public interface IProductsRepository : IClassicEntityRepository<Products, int>
    {
    }
}
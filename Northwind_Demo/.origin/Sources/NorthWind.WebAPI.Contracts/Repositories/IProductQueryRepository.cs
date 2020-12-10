using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="ProductQuery"/> entity
    /// </summary>
    public interface IProductQueryRepository : IClassicQueryRepository<ProductQuery, int>
    {
    }
}
using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SupplierQuery"/> entity
    /// </summary>
    public interface ISupplierQueryRepository : IClassicQueryRepository<SupplierQuery, int>
    {
    }
}
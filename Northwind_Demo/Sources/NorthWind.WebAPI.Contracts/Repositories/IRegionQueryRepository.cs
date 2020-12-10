using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="RegionQuery"/> entity
    /// </summary>
    public interface IRegionQueryRepository : IClassicQueryRepository<RegionQuery, int>
    {
    }
}
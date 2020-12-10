using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="ShipperQuery"/> entity
    /// </summary>
    public interface IShipperQueryRepository : IClassicQueryRepository<ShipperQuery, int>
    {
    }
}
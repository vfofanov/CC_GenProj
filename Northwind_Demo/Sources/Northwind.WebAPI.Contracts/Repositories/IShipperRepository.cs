using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Shipper"/> entity
    /// </summary>
    public interface IShipperRepository : IClassicEntityRepository<Shipper, int>
    {
    }
}
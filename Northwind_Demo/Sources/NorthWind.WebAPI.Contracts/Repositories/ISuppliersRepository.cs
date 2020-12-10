using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Suppliers"/> entity
    /// </summary>
    public interface ISuppliersRepository : IClassicEntityRepository<Suppliers, int>
    {
    }
}
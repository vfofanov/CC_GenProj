using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Shippers"/> entity
    /// </summary>
    public interface IShippersRepository : IClassicEntityRepository<Shippers, int>
    {
    }
}
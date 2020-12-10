using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Customers"/> entity
    /// </summary>
    public interface ICustomersRepository : IClassicEntityRepository<Customers, int>
    {
    }
}
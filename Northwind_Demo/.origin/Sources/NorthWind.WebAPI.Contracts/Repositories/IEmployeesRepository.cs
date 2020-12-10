using System;
using BusinessFramework.WebAPI.Contracts.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Employees"/> entity
    /// </summary>
    public interface IEmployeesRepository : IClassicEntityRepository<Employees, int>
    {
    }
}
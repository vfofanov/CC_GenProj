using System;
using BusinessFramework.WebAPI.Contracts.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="EmployeeQuery"/> entity
    /// </summary>
    public interface IEmployeeQueryRepository : IClassicQueryRepository<EmployeeQuery, int>
    {
    }
}
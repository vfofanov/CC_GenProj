using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QEmployees"/> entity
    /// </summary>
    public interface IQEmployeesRepository : IClassicQueryRepository<QEmployees, int>
    {
    }
}
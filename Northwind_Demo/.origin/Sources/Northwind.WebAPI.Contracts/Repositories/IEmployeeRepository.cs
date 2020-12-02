using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Employee"/> entity
    /// </summary>
    public interface IEmployeeRepository : IClassicEntityRepository<Employee, int>
    {
    }
}
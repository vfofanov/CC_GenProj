using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysPermission"/> entity
    /// </summary>
    public interface ISysPermissionRepository : IClassicEntityRepository<SysPermission, int>
    {
    }
}
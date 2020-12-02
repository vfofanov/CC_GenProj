using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysRolePermission"/> entity
    /// </summary>
    public interface ISysRolePermissionRepository : IClassicEntityRepository<SysRolePermission, int>
    {
    }
}
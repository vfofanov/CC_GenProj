using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysUserPermissionsDisplayView"/> entity
    /// </summary>
    public interface ISysUserPermissionsDisplayViewRepository : IEntityRepository<SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewKey>
    {
    }
}
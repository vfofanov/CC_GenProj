using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysUserPermissionsDisplayView"/> entity
    /// </summary>
    public interface ISysUserPermissionsDisplayViewRepository : IEntityRepository<SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewKey>
    {
    }
}
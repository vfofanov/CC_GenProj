using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysPermissionType"/> entity
    /// </summary>
    public interface ISysPermissionTypeRepository : IClassicEntityRepository<SysPermissionType, byte>
    {
    }
}
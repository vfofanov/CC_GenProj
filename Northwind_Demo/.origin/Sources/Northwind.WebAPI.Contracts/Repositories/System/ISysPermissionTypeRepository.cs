using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysPermissionType"/> entity
    /// </summary>
    public interface ISysPermissionTypeRepository : IClassicEntityRepository<SysPermissionType, byte>
    {
    }
}
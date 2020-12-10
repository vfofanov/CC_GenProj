using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysUserRole"/> entity
    /// </summary>
    public interface ISysUserRoleRepository : IClassicEntityRepository<SysUserRole, int>
    {
    }
}
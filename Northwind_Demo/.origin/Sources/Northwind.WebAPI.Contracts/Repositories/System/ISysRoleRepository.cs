using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysRole"/> entity
    /// </summary>
    public interface ISysRoleRepository : IClassicEntityRepository<SysRole, int>
    {
    }
}
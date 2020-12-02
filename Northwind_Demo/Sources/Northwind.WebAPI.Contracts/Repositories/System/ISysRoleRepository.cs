using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysRole"/> entity
    /// </summary>
    public interface ISysRoleRepository : IClassicEntityRepository<SysRole, int>
    {
    }
}
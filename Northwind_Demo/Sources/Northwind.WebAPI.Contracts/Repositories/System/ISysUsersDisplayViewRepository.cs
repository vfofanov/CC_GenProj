using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysUsersDisplayView"/> entity
    /// </summary>
    public interface ISysUsersDisplayViewRepository : IClassicEntityRepository<SysUsersDisplayView, int>
    {
    }
}
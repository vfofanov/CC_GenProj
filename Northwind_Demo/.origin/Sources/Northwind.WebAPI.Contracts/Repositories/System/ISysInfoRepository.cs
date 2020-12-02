using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysInfo"/> entity
    /// </summary>
    public interface ISysInfoRepository : IEntityRepository<SysInfo, SysInfoKey>
    {
    }
}
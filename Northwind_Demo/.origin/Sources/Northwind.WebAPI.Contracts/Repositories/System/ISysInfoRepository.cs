using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysInfo"/> entity
    /// </summary>
    public interface ISysInfoRepository : IEntityRepository<SysInfo, SysInfoKey>
    {
    }
}
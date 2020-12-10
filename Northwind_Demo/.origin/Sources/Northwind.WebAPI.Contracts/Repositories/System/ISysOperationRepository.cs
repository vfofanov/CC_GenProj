using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysOperation"/> entity
    /// </summary>
    public interface ISysOperationRepository : IClassicEntityRepository<SysOperation, long>
    {
    }
}
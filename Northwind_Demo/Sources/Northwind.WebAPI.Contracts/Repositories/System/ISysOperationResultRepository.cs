using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysOperationResult"/> entity
    /// </summary>
    public interface ISysOperationResultRepository : IClassicEntityRepository<SysOperationResult, byte>
    {
    }
}
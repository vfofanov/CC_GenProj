using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.Enums;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysOperationResult"/> entity
    /// </summary>
    public interface ISysOperationResultRepository : IClassicEntityRepository<SysOperationResult, byte>
    {
    }
}
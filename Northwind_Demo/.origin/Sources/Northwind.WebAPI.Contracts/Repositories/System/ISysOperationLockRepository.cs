using System;
using System.Collections.Generic;
using NorthWind.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    public interface ISysOperationLockRepository : IEntityRepository<SysOperationLock, SysOperationLockKey>
    {
        void Cleanup();
    }
}
using System;
using System.Collections.Generic;
using Northwind.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    public interface ISysOperationLockRepository : IEntityRepository<SysOperationLock, SysOperationLockKey>
    {
        void Cleanup();
    }
}
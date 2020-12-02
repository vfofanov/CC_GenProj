using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindSysOperationLockRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysOperationLockRepository : EntityRepository<SysOperationLock, SysOperationLockKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysOperationLockRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override SysOperationLock GetByKey(SysOperationLockKey key)
        {
            return Set().FirstOrDefault(entity => entity.OperationName == key.OperationName && entity.OperationContext == key.OperationContext);
        }
    
    }
}
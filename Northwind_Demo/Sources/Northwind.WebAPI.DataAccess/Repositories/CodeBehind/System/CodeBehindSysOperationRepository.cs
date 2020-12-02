using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindSysOperationRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysOperationRepository : ClassicEntityRepository<SysOperation, long, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysOperationRepository(IApiDbContext context) 
		    :base(context)
        {

        }


    
    }
}
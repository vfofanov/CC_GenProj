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
    /// Repository for <see cref="CodeBehindSysInfoRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysInfoRepository : EntityRepository<SysInfo, SysInfoKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysInfoRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override SysInfo GetByKey(SysInfoKey key)
        {
            return Set().FirstOrDefault(entity => entity.SystemVersion == key.SystemVersion && entity.DomainVersion == key.DomainVersion && entity.LastInitialization == key.LastInitialization);
        }
    
    }
}
﻿using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories.CodeBehind
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
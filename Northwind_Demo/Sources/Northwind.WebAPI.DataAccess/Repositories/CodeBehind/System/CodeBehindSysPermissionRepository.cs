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
    /// Repository for <see cref="CodeBehindSysPermissionRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysPermissionRepository : ClassicEntityRepository<SysPermission, int, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysPermissionRepository(IApiDbContext context) 
		    :base(context)
        {

        }


    
    }
}
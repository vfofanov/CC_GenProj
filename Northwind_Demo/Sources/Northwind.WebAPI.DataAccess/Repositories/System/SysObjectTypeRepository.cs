﻿using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories
{
    /// <summary>
    /// Repository for <see cref="SysObjectTypeRepository"/> objects
    /// </summary>
    public sealed class SysObjectTypeRepository : CodeBehind.CodeBehindSysObjectTypeRepository, ISysObjectTypeRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public SysObjectTypeRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context) 
		    : base(context)
        {
        }
    }
}
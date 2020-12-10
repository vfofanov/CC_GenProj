using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.DataObjects;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories
{
    /// <summary>
    /// Repository for <see cref="SysUserPermissionsDisplayViewRepository"/> objects
    /// </summary>
    public sealed class SysUserPermissionsDisplayViewRepository : CodeBehind.CodeBehindSysUserPermissionsDisplayViewRepository, ISysUserPermissionsDisplayViewRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public SysUserPermissionsDisplayViewRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context) 
		    : base(context)
        {
        }
    }
}
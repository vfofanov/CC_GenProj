using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using Northwind.Contracts;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories
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
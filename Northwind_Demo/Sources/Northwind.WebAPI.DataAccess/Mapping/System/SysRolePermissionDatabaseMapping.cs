﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysRolePermission"/> to table CCSystem.RolePermissions
    /// </summary>
    internal sealed class SysRolePermissionDatabaseMapping : CodeBehind.CodeBehindSysRolePermissionDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysRolePermissionDatabaseMapping()
        {            
        }
    }
}

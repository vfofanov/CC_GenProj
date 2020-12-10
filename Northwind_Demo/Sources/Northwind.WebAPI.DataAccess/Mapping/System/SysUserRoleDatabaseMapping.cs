﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysUserRole"/> to table CCSystem.UserRoles
    /// </summary>
    internal sealed class SysUserRoleDatabaseMapping : CodeBehind.CodeBehindSysUserRoleDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysUserRoleDatabaseMapping()
        {            
        }
    }
}

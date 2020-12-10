﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysUserPermissionsDisplayView"/> to table CCSystem.UserPermissionsDisplayView
    /// </summary>
    internal sealed class SysUserPermissionsDisplayViewDatabaseMapping : CodeBehind.CodeBehindSysUserPermissionsDisplayViewDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysUserPermissionsDisplayViewDatabaseMapping()
        {            
        }
    }
}

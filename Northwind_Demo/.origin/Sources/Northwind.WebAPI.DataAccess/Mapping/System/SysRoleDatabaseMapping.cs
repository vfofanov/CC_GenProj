﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysRole"/> to table CCSystem.Roles
    /// </summary>
    internal sealed class SysRoleDatabaseMapping : CodeBehind.CodeBehindSysRoleDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysRoleDatabaseMapping()
        {            
        }
    }
}

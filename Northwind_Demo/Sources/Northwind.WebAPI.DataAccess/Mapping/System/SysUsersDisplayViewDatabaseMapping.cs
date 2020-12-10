﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysUsersDisplayView"/> to table CCSystem.UsersDisplayView
    /// </summary>
    internal sealed class SysUsersDisplayViewDatabaseMapping : CodeBehind.CodeBehindSysUsersDisplayViewDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysUsersDisplayViewDatabaseMapping()
        {            
        }
    }
}

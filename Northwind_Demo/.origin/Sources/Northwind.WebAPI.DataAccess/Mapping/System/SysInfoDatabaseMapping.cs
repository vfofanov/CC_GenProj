﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysInfo"/> to table CCSystem.Info
    /// </summary>
    internal sealed class SysInfoDatabaseMapping : CodeBehind.CodeBehindSysInfoDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysInfoDatabaseMapping()
        {            
        }
    }
}

﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysRefreshToken"/> to table CCSystem.RefreshToken
    /// </summary>
    internal sealed class SysRefreshTokenDatabaseMapping : CodeBehind.CodeBehindSysRefreshTokenDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysRefreshTokenDatabaseMapping()
        {            
        }
    }
}

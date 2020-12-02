﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysResetPasswordToken"/> to table CCSystem.ResetPasswordToken
    /// </summary>
    internal sealed class SysResetPasswordTokenDatabaseMapping : CodeBehind.CodeBehindSysResetPasswordTokenDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysResetPasswordTokenDatabaseMapping()
        {            
        }
    }
}
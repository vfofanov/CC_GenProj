﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysOperation"/> to table CCSystem.Operation
    /// </summary>
    internal sealed class SysOperationDatabaseMapping : CodeBehind.CodeBehindSysOperationDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysOperationDatabaseMapping()
        {            
        }
    }
}

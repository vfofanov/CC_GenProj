﻿using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindSysObjectRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysObjectRepository : ClassicEntityRepository<SysObject, int, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysObjectRepository(IApiDbContext context) 
		    :base(context)
        {

        }


    
    }
}
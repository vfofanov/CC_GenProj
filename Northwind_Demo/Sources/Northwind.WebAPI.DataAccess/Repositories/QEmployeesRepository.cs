using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using Northwind.Contracts;
using Northwind.Contracts.Enums;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories
{
    /// <summary>
    /// Repository for <see cref="QEmployeesRepository"/> objects
    /// </summary>
    public sealed class QEmployeesRepository : CodeBehind.CodeBehindQEmployeesRepository, IQEmployeesRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public QEmployeesRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context) 
		    : base(context)
        {
        }
    
    }
}
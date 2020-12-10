using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories
{
    /// <summary>
    /// Repository for <see cref="EmployeesRepository"/> objects
    /// </summary>
    public sealed class EmployeesRepository : CodeBehind.CodeBehindEmployeesRepository, IEmployeesRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public EmployeesRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context, IFileLinkRepository fileLinkRepository) 
		    : base(context, fileLinkRepository)
        {
        }
    }
}
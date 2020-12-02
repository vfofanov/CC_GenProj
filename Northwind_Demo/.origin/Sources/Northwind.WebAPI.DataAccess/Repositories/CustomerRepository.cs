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
    /// Repository for <see cref="CustomerRepository"/> objects
    /// </summary>
    public sealed class CustomerRepository : CodeBehind.CodeBehindCustomerRepository, ICustomerRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public CustomerRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context) 
		    : base(context)
        {
        }
    }
}
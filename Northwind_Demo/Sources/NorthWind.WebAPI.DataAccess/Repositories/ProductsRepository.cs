﻿using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories
{
    /// <summary>
    /// Repository for <see cref="ProductsRepository"/> objects
    /// </summary>
    public sealed class ProductsRepository : CodeBehind.CodeBehindProductsRepository, IProductsRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ProductsRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context) 
		    : base(context)
        {
        }
    }
}
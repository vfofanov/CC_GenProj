﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="VSalesByCategory"/> entity
    /// </summary>
    public interface IVSalesByCategoryRepository : IClassicEntityRepository<VSalesByCategory, int>
    {
    }
}
﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Supplier"/> entity
    /// </summary>
    public interface ISupplierRepository : IClassicEntityRepository<Supplier, int>
    {
    }
}
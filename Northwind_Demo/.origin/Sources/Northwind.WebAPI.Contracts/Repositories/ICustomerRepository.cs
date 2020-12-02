﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Customer"/> entity
    /// </summary>
    public interface ICustomerRepository : IClassicEntityRepository<Customer, int>
    {
    }
}
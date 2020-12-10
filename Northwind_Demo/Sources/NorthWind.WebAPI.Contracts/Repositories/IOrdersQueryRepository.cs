﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="OrdersQuery"/> entity
    /// </summary>
    public interface IOrdersQueryRepository : IClassicQueryRepository<OrdersQuery, int>
    {
    }
}
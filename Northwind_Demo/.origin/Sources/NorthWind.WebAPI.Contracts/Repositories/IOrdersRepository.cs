﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Orders"/> entity
    /// </summary>
    public interface IOrdersRepository : IClassicEntityRepository<Orders, int>
    {
    }
}
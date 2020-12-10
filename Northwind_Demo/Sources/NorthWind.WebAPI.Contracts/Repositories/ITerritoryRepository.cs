﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Territory"/> entity
    /// </summary>
    public interface ITerritoryRepository : IClassicEntityRepository<Territory, int>
    {
    }
}
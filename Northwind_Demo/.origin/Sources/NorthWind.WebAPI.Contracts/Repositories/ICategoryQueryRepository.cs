﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="CategoryQuery"/> entity
    /// </summary>
    public interface ICategoryQueryRepository : IClassicQueryRepository<CategoryQuery, int>
    {
    }
}
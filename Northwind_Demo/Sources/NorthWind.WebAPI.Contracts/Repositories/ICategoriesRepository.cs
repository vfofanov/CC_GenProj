using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Categories"/> entity
    /// </summary>
    public interface ICategoriesRepository : IClassicEntityRepository<Categories, int>
    {
    }
}
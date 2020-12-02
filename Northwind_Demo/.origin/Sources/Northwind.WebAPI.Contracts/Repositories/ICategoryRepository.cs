using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="Category"/> entity
    /// </summary>
    public interface ICategoryRepository : IClassicEntityRepository<Category, int>
    {
    }
}
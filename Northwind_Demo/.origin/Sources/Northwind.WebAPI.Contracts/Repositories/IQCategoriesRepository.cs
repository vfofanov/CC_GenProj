using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QCategories"/> entity
    /// </summary>
    public interface IQCategoriesRepository : IClassicQueryRepository<QCategories, int>
    {
    }
}
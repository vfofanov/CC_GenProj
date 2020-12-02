using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QShippers"/> entity
    /// </summary>
    public interface IQShippersRepository : IClassicQueryRepository<QShippers, int>
    {
    }
}
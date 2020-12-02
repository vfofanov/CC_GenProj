using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="QSuppliers"/> entity
    /// </summary>
    public interface IQSuppliersRepository : IClassicQueryRepository<QSuppliers, int>
    {
    }
}
using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="CustomerQuery"/> entity
    /// </summary>
    public interface ICustomerQueryRepository : IClassicQueryRepository<CustomerQuery, int>
    {
    }
}
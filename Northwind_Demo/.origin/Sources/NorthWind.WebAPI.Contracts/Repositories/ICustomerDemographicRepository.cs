using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="CustomerDemographic"/> entity
    /// </summary>
    public interface ICustomerDemographicRepository : IClassicEntityRepository<CustomerDemographic, int>
    {
    }
}
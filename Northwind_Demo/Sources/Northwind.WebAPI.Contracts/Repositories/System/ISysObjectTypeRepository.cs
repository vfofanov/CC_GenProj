using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysObjectType"/> entity
    /// </summary>
    public interface ISysObjectTypeRepository : IClassicEntityRepository<SysObjectType, int>
    {
    }
}
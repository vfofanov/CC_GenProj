using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysObject"/> entity
    /// </summary>
    public interface ISysObjectRepository : IClassicEntityRepository<SysObject, int>
    {
    }
}
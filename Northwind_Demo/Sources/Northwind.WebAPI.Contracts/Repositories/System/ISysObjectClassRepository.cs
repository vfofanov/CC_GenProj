using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysObjectClass"/> entity
    /// </summary>
    public interface ISysObjectClassRepository : IClassicEntityRepository<SysObjectClass, byte>
    {
    }
}
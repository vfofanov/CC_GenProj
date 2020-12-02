using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysSettingProperty"/> entity
    /// </summary>
    public interface ISysSettingPropertyRepository : IClassicEntityRepository<SysSettingProperty, int>
    {
    }
}
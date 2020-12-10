using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysSettingProperty"/> entity
    /// </summary>
    public interface ISysSettingPropertyRepository : IClassicEntityRepository<SysSettingProperty, int>
    {
    }
}
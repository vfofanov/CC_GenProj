using System;
using System.Collections.Generic;
using NorthWind.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Data;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    public interface ISysSettingRepository : IClassicEntityRepository<SysSetting, int>
    {
        string GetGlobalPropertyValue(string propertyName);
    }
}
using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysObjectClass"/> entity
    /// </summary>
    public interface ISysObjectClassRepository : IClassicEntityRepository<SysObjectClass, byte>
    {
    }
}
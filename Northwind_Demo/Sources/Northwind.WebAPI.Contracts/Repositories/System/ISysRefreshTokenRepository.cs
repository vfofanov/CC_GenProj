using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysRefreshToken"/> entity
    /// </summary>
    public interface ISysRefreshTokenRepository : IEntityRepository<SysRefreshToken, SysRefreshTokenKey>
    {
    }
}
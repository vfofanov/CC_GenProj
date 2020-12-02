using System;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysRefreshToken"/> entity
    /// </summary>
    public interface ISysRefreshTokenRepository : IEntityRepository<SysRefreshToken, SysRefreshTokenKey>
    {
    }
}
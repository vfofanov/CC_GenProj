using System;
using System.Collections.Generic;
using NorthWind.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Data;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    public interface ISysUserRepository : IClassicEntityRepository<SysUser, int>
    {
        SysUser GetByAccountNameOrEmail(string identifier);
        IList<int> GetUserPermissions(int userId);
    }
}
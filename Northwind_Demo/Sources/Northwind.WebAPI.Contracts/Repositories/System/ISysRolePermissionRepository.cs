﻿using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="SysRolePermission"/> entity
    /// </summary>
    public interface ISysRolePermissionRepository : IClassicEntityRepository<SysRolePermission, int>
    {
    }
}
using System;
using System.Collections.Generic;
using Northwind.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Data;

namespace Northwind.WebAPI.Contracts.Repositories
{
    public interface ISysResetPasswordTokenRepository: IClassicEntityRepository<SysResetPasswordToken, int>
    {
        SysResetPasswordToken Resolve(string token);
    }
}

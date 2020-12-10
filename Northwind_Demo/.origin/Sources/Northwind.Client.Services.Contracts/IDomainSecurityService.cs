﻿using BusinessFramework.Client.Contracts.Services.Security;
using NorthWind.Contracts;

namespace NorthWind.Common
{
    /// <summary>
    /// Domain security service
    /// </summary>
    public interface IDomainSecurityService: ISecurityService<PublicDomainPermissions>
    {
    }
}
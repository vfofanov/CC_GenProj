﻿using System.Linq;
using BusinessFramework.WebAPI.Common.Security;
using NorthWind.WebAPI.Contracts;

namespace NorthWind.WebAPI.Controllers
{
    /// <summary>
    ///     Mark check authorization by rule
    /// </summary>
    public sealed class AuthorizationAttribute : AuthorizationBaseAttribute
    {
        /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="permissions"></param>
        public AuthorizationAttribute(params DomainPermissions[] permissions)
            : base(permissions.Cast<int>().ToArray())
        {
        }
    }
}
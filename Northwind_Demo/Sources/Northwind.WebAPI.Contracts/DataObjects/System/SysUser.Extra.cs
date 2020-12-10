﻿using BusinessFramework.WebAPI.Contracts.Security;

namespace NorthWind.WebAPI.Contracts.DataObjects
{
    partial class SysUser : ISysUser
    {
        /// <summary>
        ///     DB unbound field for transfer password to server
        /// </summary>
        public virtual string Password { get; set; }
    }
}
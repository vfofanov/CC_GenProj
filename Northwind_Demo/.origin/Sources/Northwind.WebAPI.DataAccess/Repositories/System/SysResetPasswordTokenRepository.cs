using System;
using System.Data.Entity;
using System.Linq;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories
{
    /// <summary>
    /// Repository for <see cref="SysResetPasswordTokenRepository"/> objects
    /// </summary>
    public sealed class SysResetPasswordTokenRepository : CodeBehind.CodeBehindSysResetPasswordTokenRepository, ISysResetPasswordTokenRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public SysResetPasswordTokenRepository(
            //--  custom dependencies
            //-- /custom dependencies
            IApiDbContext context) 
		    : base(context)
        {
        }

        /// <inheritdoc />
        public SysResetPasswordToken Resolve(string token)
        {
            return Set().FirstOrDefault(p => !p.IsExecuted && p.Token == token && DbFunctions.AddDays(p.ValidFrom, -1) < DateTimeOffset.Now);
        }
    }
}
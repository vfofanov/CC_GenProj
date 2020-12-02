using System;
using System.Data.Entity;
using System.Linq;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories
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
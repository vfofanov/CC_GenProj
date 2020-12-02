using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.Contracts.DataObjects;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindSysRefreshTokenRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysRefreshTokenRepository : EntityRepository<SysRefreshToken, SysRefreshTokenKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysRefreshTokenRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override SysRefreshToken GetByKey(SysRefreshTokenKey key)
        {
            return Set().FirstOrDefault(entity => entity.UserId == key.UserId && entity.ClientId == key.ClientId);
        }
    
    }
}
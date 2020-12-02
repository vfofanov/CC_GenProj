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
    /// Repository for <see cref="CodeBehindSysUserPermissionsDisplayViewRepository"/> objects
    /// </summary>
    public abstract class CodeBehindSysUserPermissionsDisplayViewRepository : EntityRepository<SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindSysUserPermissionsDisplayViewRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override SysUserPermissionsDisplayView GetByKey(SysUserPermissionsDisplayViewKey key)
        {
            return Set().FirstOrDefault(entity => entity.UserId == key.UserId && entity.PermissionId == key.PermissionId);
        }
    
    }
}
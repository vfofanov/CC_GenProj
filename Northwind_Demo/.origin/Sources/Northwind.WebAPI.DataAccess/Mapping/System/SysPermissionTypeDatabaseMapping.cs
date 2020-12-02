using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysPermissionType"/> to table CCSystem.PermissionTypes
    /// </summary>
    internal sealed class SysPermissionTypeDatabaseMapping : CodeBehind.CodeBehindSysPermissionTypeDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysPermissionTypeDatabaseMapping()
        {            
        }
    }
}

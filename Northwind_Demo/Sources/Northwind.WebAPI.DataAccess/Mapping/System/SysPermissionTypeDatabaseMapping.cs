using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
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

using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysUser"/> to table CCSystem.Users
    /// </summary>
    internal sealed class SysUserDatabaseMapping : CodeBehind.CodeBehindSysUserDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysUserDatabaseMapping()
        {            
            Ignore(t => t.Password);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysUsersDisplayView"/> to table CCSystem.UsersDisplayView
    /// </summary>
    internal sealed class SysUsersDisplayViewDatabaseMapping : CodeBehind.CodeBehindSysUsersDisplayViewDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysUsersDisplayViewDatabaseMapping()
        {            
        }
    }
}

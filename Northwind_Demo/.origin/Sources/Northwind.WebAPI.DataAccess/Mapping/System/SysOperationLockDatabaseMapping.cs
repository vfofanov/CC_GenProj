using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysOperationLock"/> to table CCSystem.OperationLocks
    /// </summary>
    internal sealed class SysOperationLockDatabaseMapping : CodeBehind.CodeBehindSysOperationLockDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysOperationLockDatabaseMapping()
        {            
        }
    }
}

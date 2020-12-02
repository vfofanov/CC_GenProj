using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysOperationResult"/> to table CCSystem.OperationResult
    /// </summary>
    internal sealed class SysOperationResultDatabaseMapping : CodeBehind.CodeBehindSysOperationResultDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysOperationResultDatabaseMapping()
        {            
        }
    }
}

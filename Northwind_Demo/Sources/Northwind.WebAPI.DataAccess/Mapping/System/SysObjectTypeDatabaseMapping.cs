using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysObjectType"/> to table CCSystem.ObjectTypes
    /// </summary>
    internal sealed class SysObjectTypeDatabaseMapping : CodeBehind.CodeBehindSysObjectTypeDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysObjectTypeDatabaseMapping()
        {            
        }
    }
}

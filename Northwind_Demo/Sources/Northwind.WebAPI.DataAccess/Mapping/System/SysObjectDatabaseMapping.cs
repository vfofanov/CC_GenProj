using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysObject"/> to table CCSystem.SysObjects
    /// </summary>
    internal sealed class SysObjectDatabaseMapping : CodeBehind.CodeBehindSysObjectDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysObjectDatabaseMapping()
        {            
        }
    }
}

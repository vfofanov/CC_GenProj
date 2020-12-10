using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysSettingProperty"/> to table CCSystem.SettingProperties
    /// </summary>
    internal sealed class SysSettingPropertyDatabaseMapping : CodeBehind.CodeBehindSysSettingPropertyDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysSettingPropertyDatabaseMapping()
        {            
        }
    }
}

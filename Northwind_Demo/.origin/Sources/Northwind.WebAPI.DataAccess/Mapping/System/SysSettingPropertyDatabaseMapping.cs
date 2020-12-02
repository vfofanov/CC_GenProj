using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
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

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysSetting"/> to table CCSystem.Settings
    /// </summary>
    internal sealed class SysSettingDatabaseMapping : CodeBehind.CodeBehindSysSettingDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysSettingDatabaseMapping()
        {            
        }
    }
}

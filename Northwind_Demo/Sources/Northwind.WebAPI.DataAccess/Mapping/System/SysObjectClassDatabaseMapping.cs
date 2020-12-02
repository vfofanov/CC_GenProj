using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    /// <summary>
    /// Database mapping for <see cref="SysObjectClass"/> to table CCSystem.SysObjectClasses
    /// </summary>
    internal sealed class SysObjectClassDatabaseMapping : CodeBehind.CodeBehindSysObjectClassDatabaseMapping
    {
	    /// <summary>
        /// Instance constructor
        /// </summary>
        public SysObjectClassDatabaseMapping()
        {            
        }
    }
}

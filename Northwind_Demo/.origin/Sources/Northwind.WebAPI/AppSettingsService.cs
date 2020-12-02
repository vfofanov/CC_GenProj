using System.Configuration;
using BusinessFramework.Contracts.Services;
using BusinessFramework.WebAPI.Services;
using Northwind.WebAPI.Contracts;

namespace Northwind.WebAPI
{
    /// <summary>
    /// App settings service
    /// </summary>
    public sealed class AppSettingsService : WebApiSettingsService, IAppSettingsService
    {
        /// <summary>
        /// Server instance name
        /// </summary>
        public string InstanceName
        {
            get
            {
                return GetValue("InstanceName");
            }
        }
    }
}
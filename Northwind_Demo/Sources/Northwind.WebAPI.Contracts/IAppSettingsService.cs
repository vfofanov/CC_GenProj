using BusinessFramework.WebAPI.Contracts.Services;

namespace Northwind.WebAPI.Contracts
{
    public interface IAppSettingsService: IWebApiSettingsService
    {
        /// <summary>
        /// Server instance name
        /// </summary>
        string InstanceName { get; }
    }
}
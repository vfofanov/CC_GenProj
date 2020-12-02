using BusinessFramework.WebAPI.Contracts.Files.Storage;
using FutureTechnologies.DI.Contracts;
using Northwind.WebAPI.File;


namespace Northwind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureFileStorageSaveOptions(IServerContainerRegistrator registrator)
        {
		    registrator.PerRequest<IFileStorageSaveOptionsSwitcher, FileStorageSaveOptionsSwitcher>();            
        }
    }
}
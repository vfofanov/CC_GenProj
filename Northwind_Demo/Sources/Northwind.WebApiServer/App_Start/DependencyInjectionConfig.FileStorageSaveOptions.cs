using BusinessFramework.WebAPI.Contracts.Files.Storage;
using FutureTechnologies.DI.Contracts;
using NorthWind.WebAPI.File;


namespace NorthWind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureFileStorageSaveOptions(IServerContainerRegistrator registrator)
        {
		    registrator.PerRequest<IFileStorageSaveOptionsSwitcher, FileStorageSaveOptionsSwitcher>();            
            registrator.PerRequest<EmployeesFileStorageSaveOptionsResolver>();
        }
    }
}
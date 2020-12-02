using FutureTechnologies.DI.Contracts;
using Northwind.Client.ActionServices.Client;
using Northwind.Client.Services.Contracts.ActionServices;


namespace Northwind.Console
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureClientServices(IClientContainerRegistrator registrator)
        {
            registrator.PerSession<IClientOrderManagerService, ClientOrderManagerService>();
        }
    }
}
using FutureTechnologies.DI.Contracts;
using Northwind.Client.ServerServices.ActionServices.Server;
using Northwind.Client.Services.Contracts.ActionServices;


namespace Northwind.Client.ServerServices
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureServerServices(IClientContainerRegistrator registrator)
        {
            registrator.PerSession<ITestDynamicColumnsActionService, TestDynamicColumnsActionService>();
        }
    }
}
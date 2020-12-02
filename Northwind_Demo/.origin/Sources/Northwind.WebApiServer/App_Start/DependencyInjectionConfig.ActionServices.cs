using FutureTechnologies.DI.Contracts;
using Northwind.WebAPI.ActionServices;
using Northwind.WebAPI.Contracts.ActionServices;


namespace Northwind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureActionServices(IServerContainerRegistrator registrator)
        {
            registrator.PerRequest<ITestDynamicColumnsActionService, TestDynamicColumnsActionService>();
        }
    }
}
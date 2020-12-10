using FutureTechnologies.DI.Contracts;
using NorthWind.Client.ServerServices.ActionServices.Server;
using NorthWind.Client.Services.Contracts.ActionServices;


namespace NorthWind.Client.ServerServices
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureServerServices(IClientContainerRegistrator registrator)
        {
            registrator.PerSession<IReportService, ReportService>();
        }
    }
}
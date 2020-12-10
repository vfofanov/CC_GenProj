using FutureTechnologies.DI.Contracts;
using NorthWind.WebAPI.ActionServices;
using NorthWind.WebAPI.Contracts.ActionServices;


namespace NorthWind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureActionServices(IServerContainerRegistrator registrator)
        {
            registrator.PerRequest<IReportService, ReportService>();
        }
    }
}
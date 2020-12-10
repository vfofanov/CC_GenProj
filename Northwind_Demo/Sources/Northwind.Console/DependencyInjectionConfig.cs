using System;
using System.Configuration;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Client.Contracts.Wizards;
using BusinessFramework.Contracts;
using FutureTechnologies.DI.Contracts;
using ReportingFramework.Client;
using NorthWind.Client.Reporting;
using NorthWind.Console.Services;

namespace NorthWind.Console
{
    internal static partial class DependencyInjectionConfig
    {
        public static void Configure(IClientContainerRegistrator registrator)
        {
            Client.ServerServices.DependencyInjectionConfig.Configure(registrator,GetRootUri, GetClientId, GetClientSecret, GetRequestTimeout);

            ConfigureCommon(registrator);
            ConfigureCommonGui(registrator);
            ConfigureClientContexts(registrator);
            ConfigureReporting(registrator);
            ConfigureCustom(registrator);

            ReportingDependencyInjection.Configure(registrator);
            registrator.Singleton<BusinessFramework.Client.Contracts.Reporting.ReportController, ReportController>();
			
            registrator.PerSession<IWizardsService, WizardsService>();
            ConfigureWizards(registrator);

            ConfigureClientServices(registrator);
            ConfigureScreens(registrator);
        }

        private static string GetClientId(IScope scope)
        {
            return "win_client";
        }

        private static string GetClientSecret(IScope scope)
        {
            return "secret";
        }

        private static string GetRootUri(IScope resolver)
        {
            var value = ConfigurationManager.ConnectionStrings["CentralServiceUri"];

            var logger = resolver.Resolve<ILogger>();
            if (value != null)
            {
                logger.Trace("Server connection from app.config. CentralServiceUri:{0}", value.ConnectionString);
                return value.ConnectionString;
            }

            const string message = "Can't find connection string 'CentralServiceUri' in app settings. Connect to server failed";
            resolver.Resolve<ILogger>().Critical(message);
            throw new Exception(message);
        }

        private static int GetRequestTimeout(IScope resolver)
        {
            return resolver.Resolve<IAppSettingsService>().RequestTimeout;
        }
    }
}
using System;
using BusinessFramework.Client.Startup;
using FutureTechnologies.DI.Contracts;
using FutureTechnologies.DI.UnityContainer;

namespace NorthWind.Console
{
    public class Program
    {
        private static ApplicationBootstrapper _bootstrapper;
        /// <summary> The main entry point for the application. </summary>
        [STAThread]
        private static void Main()
        {
            var registrator = GetRegistrator();
            DependencyInjectionConfig.Configure(registrator);

            _bootstrapper = new ApplicationBootstrapper(registrator, "NorthWind");
            _bootstrapper.Run();
        }

        private static IClientContainerRegistrator GetRegistrator()
        {
            return new UnityContainerRegistrator();
        }
    }
}
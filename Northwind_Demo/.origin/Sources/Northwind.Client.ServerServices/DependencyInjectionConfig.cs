using System;
using BusinessFramework.Client.Common.Services;
using BusinessFramework.Client.Connection;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using FutureTechnologies.DI.Contracts;
using NorthWind.Client.ServerServices.DomainModel;

namespace NorthWind.Client.ServerServices
{
    public static partial class DependencyInjectionConfig
    {
        public static void Configure(IClientContainerRegistrator registrator,
            Func<IScope, string> getRootUriFunc,
            Func<IScope, string> getClientIdFunc,
            Func<IScope, string> getClientSecretFunc,
            Func<IScope, int> getRequestTimeoutFunc)
        {
            if (getRootUriFunc == null)
            {
                throw new ArgumentNullException(nameof(getRootUriFunc));
            }
            if (getRequestTimeoutFunc == null)
            {
                throw new ArgumentNullException(nameof(getRequestTimeoutFunc));
            }

            //Need to resolve
            //ILogger
            //IMessageDialogService

            registrator.Singleton<IMessageBoxService, MessageBoxService>();
            registrator.Singleton<ICultureService, CultureService>();

            //NOTE: Connection
            registrator.PerSession<ISession, Session>(
                new Parameter("rootUri", scope => (object) getRootUriFunc(scope)),
                new Parameter("clientId", scope => (object) getClientIdFunc(scope)),
                new Parameter("clientSecret", scope => (object) getClientSecretFunc(scope)));

            registrator.PerSession<IHttpClientFactory, HttpClientFactory>(
                new Parameter("culture", GetCultureName),
                new Parameter("timeout", scope => (object) getRequestTimeoutFunc(scope)));

            registrator.PerSession<IControllerClientFactory, ControllerClientFactory>();
            registrator.Singleton<IODataClientFactory, DomainODataClientFactory>();

            ConfigureServerContexts(registrator);

            registrator.PerSession<ICollectionManagersService, CollectionManagersService>();
            ConfigureDomainCollectionManagers(registrator);

            ConfigureServerServices(registrator);
        }

        private static object GetCultureName(IScope resolver)
        {
            return resolver.Resolve<ICultureService>().CurrentCulture.Name;
        }
    }
}
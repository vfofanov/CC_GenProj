using BusinessFramework.Contracts.Security.Hash;
using BusinessFramework.WebAPI.Security;
using BusinessFramework.WebAPI.Contracts.Security;
using BusinessFramework.WebAPI.Contracts.Security.Hash;
using FutureTechnologies.DI.Contracts;
using Northwind.WebApiServer.Security;
using Northwind.WebAPI;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.Security;
using Northwind.WebAPI.Security;

namespace Northwind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        private static void ConfigureSecurity(IServerContainerRegistrator registrator)
        {
            registrator.Singleton<IHashProvider, DefaultHashProvider>();
            registrator.Singleton<IPasswordHashProvider, PasswordHashProvider>();
            registrator.Singleton<IBearerAuthenticationOptionProvider, BearerAuthenticationOptionProvider>();
            registrator.Singleton<ITokenConfigurationService, TokenConfigurationService>();

            registrator.PerRequest<IPrincipalManager, PrincipalManager>();
            registrator.PerRequest<IEmailConfirmationService, EmailConfirmationService>();
            registrator.PerRequest<ISecurityService, ICommonSecurityService, SecurityService>();
            registrator.PerRequest<ITokenGenerationService, TokenGenerationService>();
            registrator.PerRequest<IPostRegistrationActionService, PostRegistrationActionService>();
            registrator.PerRequest<ISysUserService, SysUserService>();
        }
    }
}
using System;
using System.IO;
using BusinessFramework.Client.Common;
using BusinessFramework.Client.Common.Files;
using BusinessFramework.Client.Common.GuiSettings;
using BusinessFramework.Client.Common.Services;
using BusinessFramework.Client.Common.Services.MailNotifier;
using BusinessFramework.Client.Common.Services.Security;
using BusinessFramework.Client.Common.Services.Shell;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.Files;
using BusinessFramework.Client.Contracts.GuiSettings;
using BusinessFramework.Client.Contracts.Screens;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Client.Contracts.Services.MailNotifier;
using BusinessFramework.Client.Contracts.Services.Security;
using BusinessFramework.Client.Contracts.Services.Settings;
using BusinessFramework.Client.Startup.Services;
using BusinessFramework.Contracts;
using BusinessFramework.EnterpriseLibrary.Logging;
using FutureTechnologies.DI.Contracts;
using Northwind.Client.Services;
using Northwind.Common;
using Northwind.Common.Settings;
using Northwind.Console.Services;
using Northwind.Contracts;

namespace Northwind.Console
{
    internal partial class DependencyInjectionConfig
    {
        public static void ConfigureCommon(IClientContainerRegistrator registrator)
        {
            registrator.Singleton<IEnvironmentService, EnvironmentService>(
                new Parameter("applicationName", "Northwind"),
                new Parameter("applicationVersion", "1.0.0.0"),
                new Parameter("applicationPath", AppDomain.CurrentDomain.BaseDirectory));

            registrator.Singleton<IAppSettingsService, AppSettingsService>();
            registrator.Singleton<ILocalSettingsService, LocalSettingsService>();
            registrator.Singleton<IShellService, ShellService>();
            registrator.Singleton<ITempService, TempService>();
            registrator.Singleton<ICrashReportService, CrashReportService>();
            registrator.Singleton<IDeploymentManifestService, DeploymentManifestService>();

            registrator.Singleton<ILogger, Logger>(
                new Parameter("configurationPath",
                    resolver => Path.Combine(resolver.Resolve<IEnvironmentService>().ApplicationPath, "logging.config")));
            registrator.Singleton<IExceptionHandler, ExceptionHandler>();

            //NOTE: Security
            registrator.PerSession<ISecurityService, ISecurityService<PublicDomainPermissions>, IDomainSecurityService, DomainSecurityService>();
            registrator.Singleton<IPasswordService, PasswordService>();
            registrator.Singleton<ILoginService, LoginService>(
                new Parameter("integratedSecurity", resolver => resolver.Resolve<IAppSettingsService>().IntegratedSecurity));

            //NOTE: Settings
            registrator.PerSession<ISessionSettingsService, SessionSettingsService>(new Parameter("accessLevels", GetSessionSettingsAccessLevels));

            //NOTE: Notifier
            registrator.PerSession<ISMTPMailNotifierService, SMTPMailNotifierService>();
            registrator.PerSession<IMAPIMailNotifierService, MAPIMailNotifierService>();
            registrator.PerSession<IMailNotifierService, MailNotifierSwitcherService>();
            registrator.PerSession<ISendErrorReportService, SendErrorReportService>();

            //NOTE:Data
            registrator.PerSession<IEntityManagementService, EntityManagementService>();
            registrator.PerSession<IOperationLockService, OperationLockService>();
            registrator.PerSession<IFileLinkService, FileLinkService>();

            //Wizards
            registrator.PerSession<IWizardInitializationService, WizardInitializationService>();

            registrator.PerSession<IMainMenuSettingsManager, MainMenuSettingsManager>();
            registrator.PerSession<IScreenSettingsManagerFactory, ScreenSettingsManagerFactory>();
            registrator.PerSession<IScreenViewModelFactory, ScreenViewModelFactory>();
        }

        private static object GetSessionSettingsAccessLevels(IScope scope)
        {
            if (scope.Resolve<IDomainSecurityService>().Authorize(PublicDomainPermissions.SettingManagement))
            {
                return SessionSettingsAccessLevels.Base | SessionSettingsAccessLevels.WriteValue |
                       SessionSettingsAccessLevels.WriteDefaultValue | SessionSettingsAccessLevels.AllUsersAccess;
            }
            return SessionSettingsAccessLevels.Base | SessionSettingsAccessLevels.WriteValue;
        }
    }
}
using System;
using System.Drawing;
using System.Reflection;
using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Common.Services;
using BusinessFramework.Client.Common.Wizards;
using BusinessFramework.Client.Contracts.Files;
using BusinessFramework.Client.Contracts.Screens.Render;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Client.Contracts.Wizards;
using BusinessFramework.Client.WinForms;
using BusinessFramework.Client.WinForms.IG.Services;
using BusinessFramework.Client.WinForms.Services;
using BusinessFramework.Client.WinForms.IG.Explorer;
using BusinessFramework.Client.WinForms.IG.Forms;
using BusinessFramework.Client.WinForms.IG.Screens;
using BusinessFramework.Contracts.Formatting;
using FutureTechnologies.DI.Contracts;
using Northwind.Client;
using Northwind.Console.Services;

namespace Northwind.Console
{
    partial class DependencyInjectionConfig
    {
        public static void ConfigureCommonGui(IClientContainerRegistrator registrator)
        {
            BaseForm.SetIcon(GetFormIcon());

            registrator.Singleton<IGuiPlatformService, WinFormsGuiPlatformService>();
            registrator.Singleton<IApplicationStyleService, ApplicationStyleService>();
            registrator.Singleton<IMessageDialogServiceImageResolver, MessageDialogServiceImageResolver>();
            registrator.Singleton<IMessageDialogService, MessageDialogService>();
            registrator.Singleton<IModalFormService, ModalFormService>();
            registrator.Singleton<ISplashService, SplashService>(new Parameter("backgroundImageFunc", GetSplashImage));
            registrator.Singleton<IResourceImageService, ResourceImageService>();

            registrator.Singleton<ILoginDialogService, LoginDialogService>();
            registrator.Singleton<IFileDialogService, WinFormsFileDialogService>();

            registrator.PerSession<IStartupService, StartupService>(
                new Parameter("minimizeToTray",
                    resolver => resolver.Resolve<IAppSettingsService>().MinimizeToTray));

            registrator.PerSession<IWorkspaceService, WorkspaceService>();
            registrator.PerSession<IMainMenuService, MainMenuService>();
            registrator.PerSession<ISendErrorReportDialogService, SendErrorReportDialogService>();
            registrator.PerSession<IScreenCommandFactory, ScreenCommandFactory>();
			registrator.PerSession<IValueFormattingService, ValueFormattingService>();
			registrator.PerSession<IScreenExplorerNodeService, ScreenExplorerNodeService>();
            registrator.PerSession<IScreenExplorerService, ScreenExplorerService>();
            registrator.PerSession<IServerActionRunService, ServerActionRunService>();
            registrator.PerSession<IMessageDialogServiceExceptionResolver, MessageDialogServiceExceptionResolver>();


            registrator.PerSession<ISelectItemsDialogService, SelectItemsDialogService>();
			
            registrator.PerSession<IWizardDialogService, WizardDialogService>();
            registrator.PerSession<IControlRender, InfragisticsControlRender>();
            registrator.PerSession<IScreenRender, ScreenRender>();
            //NOTE: Options
        }

        private static Func<Image> GetSplashImage(IScope resolver)
        {
            return () => Image.FromStream(Assembly.GetEntryAssembly()
                .GetManifestResourceStream("Northwind.Console.Resources.Images.SplashBackground.png"));
        }
        private static Icon GetFormIcon()
        {
            return new Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("Northwind.Console.app.ico"));
        }
    }
}
using System.Collections.Generic;
using BusinessFramework;
using BusinessFramework.Client.Contracts.Actions;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Client.Contracts.Properties;
using BusinessFramework.Client.Contracts.Services.Security;
using BusinessFramework.Client.WinForms.IG.Explorer;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Common;
using NorthWind.Contracts;

namespace NorthWind.Console.Services
{
    internal sealed class MainMenuService : IMainMenuService
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public MainMenuService(IScreenExplorerService screenExplorerService, IWorkspaceService workspaceService, IDomainSecurityService securityService)
        {
            ScreenExplorerService = screenExplorerService;
            WorkspaceService = workspaceService;
            SecurityService = securityService;
        }

        private IScreenExplorerService ScreenExplorerService { get; set; }
        private IWorkspaceService WorkspaceService { get; set; }
        private IDomainSecurityService SecurityService { get; set; }

        public IReadOnlyCollection<IActionItem> GetActions()
        {
            var result = new List<IActionItem>();

            #region File menu
            {
                var group = result.AddGroup(Resources.MainMenu_FileGroup);
                group.AddActionCommand(ShowOptions, Resources.MainMenu_Options, StandardImageNames.Options);
                group.AddSeparator();

                group.AddActionCommand(Logout, Resources.MainMenu_Logout, StandardImageNames.Logout);
                group.AddActionCommand(Exit, Resources.MainMenu_Exit);
            }
            #endregion
            #region View
            {
                var group = result.AddGroup(Resources.MainMenu_ViewGroup);

                foreach (var explorerGroup in ScreenExplorerService.GetGroups())
                {
                    group.AddSeparator();
                    foreach (var explorerNode in explorerGroup.Nodes)
                    {
                        var node = explorerNode;

                        group.AddActionCommand(() => WorkspaceService.GoToScreen(node.Key),
                            node.Title,
                            node.ImageResourceName);
                    }
                }
            }
            #endregion
            #region Help
            {
                var group = result.AddGroup(Resources.MainMenu_About);
                group.AddActionCommand(ShowAbout, Resources.MainMenu_About, StandardImageNames.About);
            }
            #endregion

            return result;
        }

        private void Logout()
        {
            WorkspaceService.Logout();
        }

        private void Exit()
        {
            WorkspaceService.Exit();
        }
        
        private void ShowOptions()
        {
            WorkspaceService.ShowOptions();
        }

        private void ShowAbout()
        {
            WorkspaceService.ShowAbout();
        }
    }
}
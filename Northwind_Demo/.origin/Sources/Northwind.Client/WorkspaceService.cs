using System;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Client.WinForms.IG.Forms;
using FutureTechnologies.DI.Contracts;
using Northwind.Client.Forms;
using Northwind.Client.Forms.Security;

namespace Northwind.Client
{
    public sealed class WorkspaceService : IWorkspaceService
    {
        //TODO: Refactor it for avoid using scope directly
        public WorkspaceService(IScope scope)
        {
            Scope = scope;
        }

        private IScope Scope { get; }

        public MainForm MainForm { get; private set; }

        //TODO: Client v.2: Need refactor this
        object IWorkspaceService.MainForm
        {
            get => MainForm;
            set => MainForm = (MainForm) value;
        }

        public void GoToScreen(string screenKey)
        {
            MainForm.GoToNode(screenKey);
        }
        public void Logout()
        {
            MainForm.Logout();
        }
        public void Exit(Exception exc=null)
        {
            MainForm.Exit(exc);
        }
        public void ShowOptions()
        {
            using (var optionsForm = Scope.Resolve<OptionsForm>())
            {
                optionsForm.ShowDialog();
            }
        }
        public void ShowAbout()
        {
            AboutForm.ShowAbout(Scope.Resolve<ISession>(), Scope.Resolve<IDeploymentManifestService>(), MainForm.Text);
        }
    }
}
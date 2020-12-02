using System;
using System.Windows.Forms;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Client.Contracts.Services.Security;
using Northwind.Client.Forms.Security;

namespace BusinessFramework.Client.WinForms.IG.Services
{
    public sealed class LoginDialogService : ILoginDialogService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public LoginDialogService(IPasswordService passwordService, IModalFormService modalFormService)
        {
            PasswordService = passwordService;
            ModalFormService = modalFormService;
        }
        #region Dependencies
        private IPasswordService PasswordService { get; set; }
        private IModalFormService ModalFormService { get; set; }
        #endregion
        public bool ShowDialog(ISession session, string lastLogin)
        {
            try
            {
                using (var form = new LoginForm(session, PasswordService, lastLogin))
                {
                    var owner = ModalFormService.CurrentForm as IWin32Window;

                    if (owner != null)
                    {
                        var ownerForm = (Form) owner;
                        ownerForm.Invoke(new Action(() =>
                        {
                            form.ShowDialog(owner);
                            ModalFormService.Push(form);
                        }));
                    }
                    else
                    {
                        form.ShowDialog();
                    }
                    //TODO: Need deep research bechavior with login dialog and splash in background
                    //HACK: We freeze main thread here by waiting DialogResult
                    return form.DialogResult == System.Windows.Forms.DialogResult.OK;
                }
            }
            finally
            {
                ModalFormService.Pop();
            }
        }
    }
}
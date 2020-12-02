using System;
using System.Windows.Forms;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Properties;
using BusinessFramework.Client.Contracts.Services.Security;
using BusinessFramework.Client.WinForms.IG.Forms;

namespace Northwind.Client.Forms.Security
{
    internal partial class LoginForm : CcDialogBase
    {
        private int _attempt = 1;

        public LoginForm(ISession session, IPasswordService passwordService, string lastLogin)
        {
            InitializeComponent();

            Session = session;
            PasswordService = passwordService;

            RefreshButtons();
            loginTextBox.Text = lastLogin;

            changePasswordButton.Visible = !GlobalServices.AppSettings.IntegratedSecurity;
            newPasswordPanel.Visible = false;
            Height -= newPasswordPanel.Height;


            //461	Security: Introduce Change password action for any user
            //TODO remove next line when 
            changePasswordButton.Visible = false;
        }

        private ISession Session { get; set; }
        private IPasswordService PasswordService { get; set; }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (loginTextBox.Text.Length > 0)
            {
                //does not work :(
                passwordTextBox.Focus();
            }
        }


        private string Login
        {
            get { return loginTextBox.Text; }
        }

        private string Password
        {
            get { return passwordTextBox.Text; }
        }

        private string NewPassword
        {
            get { return newPasswordPanel.Visible ? newPasswordTextBox.Text : null; }
        }

        private string RepeatNewPassword
        {
            get { return newPasswordPanel.Visible ? repeatNewPasswordTextBox.Text : null; }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (NewPassword != null && RepeatNewPassword != null)
                {
                    ValidateNewPassword();
                }

                string errorMessage;
                try
                {
                    Cursor = Cursors.WaitCursor;
                    if (TryAuthenticate(out errorMessage))
                    {
                        return;
                    }

                    System.Threading.Thread.Sleep(++_attempt*1000);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }

                System.Windows.Forms.MessageBox.Show(this, errorMessage ?? Resources.ErrorMessageTitle, Resources.ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }

            var result = System.Windows.Forms.MessageBox.Show(this, Resources.MainForm_OnClosing_Do_you_want_to_exit_application, Resources.ExitMessageTitle, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private string ValidateNewPassword()
        {
            if (NewPassword != RepeatNewPassword)
            {
                return "New password does not match";
            }

            string validationError;
            return !PasswordService.IsValidPassword(NewPassword, out validationError) ? validationError : null;
        }

        private bool TryAuthenticate(out string errorMessage)
        {
            var authenticated = Session.Authenticate(Login, Password, out errorMessage);
            // this part is unfinished
            //461	Security: Introduce Change password action for any user
            //if (authenticated && NewPassword != null)
            //{
            //    TODO TODO TODO TODO TODO TODO TODO TODO DomainModel.GetManager<ISysUserCollectionManager>().ChangePassword(NewPassword);
            //}
            return authenticated;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void RefreshButtons()
        {
            okButton.Enabled = !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password);
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (newPasswordPanel.Visible)
            {
                newPasswordPanel.Visible = false;
                Height -= newPasswordPanel.Height;
            }
            else
            {
                Height += newPasswordPanel.Height;
                newPasswordPanel.Visible = true;
            }
        }
    }
}
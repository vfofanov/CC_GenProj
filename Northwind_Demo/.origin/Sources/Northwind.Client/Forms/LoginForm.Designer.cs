using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;

namespace NorthWind.Client.Forms.Security
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            var appearance1 = new global::Infragistics.Win.Appearance();
            var appearance2 = new global::Infragistics.Win.Appearance();
            this.newPasswordPanel = new CcPanel();
            this.newPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.repeatNewPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ccLabel1 = new CcLabel();
            this.ccLabel2 = new CcLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changePasswordButton = new CcButton(this.components);
            this.newPasswordPanel.ClientArea.SuspendLayout();
            this.newPasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            // 
            // newPasswordPanel
            // 
            resources.ApplyResources(this.newPasswordPanel, "newPasswordPanel");
            // 
            // newPasswordPanel.ClientArea
            // 
            resources.ApplyResources(this.newPasswordPanel.ClientArea, "newPasswordPanel.ClientArea");
            this.newPasswordPanel.ClientArea.Controls.Add(this.newPasswordTextBox);
            this.newPasswordPanel.ClientArea.Controls.Add(this.repeatNewPasswordTextBox);
            this.newPasswordPanel.ClientArea.Controls.Add(this.ccLabel1);
            this.newPasswordPanel.ClientArea.Controls.Add(this.ccLabel2);
            this.newPasswordPanel.Name = "newPasswordPanel";
            // 
            // newPasswordTextBox
            // 
            resources.ApplyResources(this.newPasswordTextBox, "newPasswordTextBox");
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            // 
            // repeatNewPasswordTextBox
            // 
            resources.ApplyResources(this.repeatNewPasswordTextBox, "repeatNewPasswordTextBox");
            this.repeatNewPasswordTextBox.Name = "repeatNewPasswordTextBox";
            this.repeatNewPasswordTextBox.PasswordChar = '*';
            // 
            // ccLabel1
            // 
            resources.ApplyResources(this.ccLabel1, "ccLabel1");
            appearance1.FontData.BoldAsString = resources.GetString("resource.BoldAsString");
            appearance1.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString");
            appearance1.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString");
            appearance1.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString");
            resources.ApplyResources(appearance1, "appearance1");
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Padding = new Padding(2);
            // 
            // ccLabel2
            // 
            resources.ApplyResources(this.ccLabel2, "ccLabel2");
            appearance2.FontData.BoldAsString = resources.GetString("resource.BoldAsString1");
            appearance2.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString1");
            appearance2.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString1");
            appearance2.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString1");
            resources.ApplyResources(appearance2, "appearance2");
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Padding = new Padding(2);
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.Name = "loginLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // loginTextBox
            // 
            resources.ApplyResources(this.loginTextBox, "loginTextBox");
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // changePasswordButton
            // 
            resources.ApplyResources(this.changePasswordButton, "changePasswordButton");
            this.changePasswordButton.AlwaysEnabled = false;
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.newPasswordPanel);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Controls.SetChildIndex(this.loginLabel, 0);
            this.Controls.SetChildIndex(this.passwordLabel, 0);
            this.Controls.SetChildIndex(this.loginTextBox, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.changePasswordButton, 0);
            this.Controls.SetChildIndex(this.newPasswordPanel, 0);
            this.newPasswordPanel.ClientArea.ResumeLayout(false);
            this.newPasswordPanel.ClientArea.PerformLayout();
            this.newPasswordPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CcButton changePasswordButton;
        private CcPanel newPasswordPanel;
        private System.Windows.Forms.MaskedTextBox newPasswordTextBox;
        private System.Windows.Forms.MaskedTextBox repeatNewPasswordTextBox;
        private CcLabel ccLabel1;
        private CcLabel ccLabel2;
    }
}
using BusinessFramework.Client.WinForms.IG.Controls;
using BusinessFramework.Client.WinForms.IG.Controls.PropertyGridEx;

namespace Northwind.Client.CustomSettings
{
	partial class SettingsTreeControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsTreeControl));
            var appearance1 = new global::Infragistics.Win.Appearance();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new CcLabel();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.propertyGrid = new PropertyGridEx();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxUsers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.propertyGrid, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxUsers
            // 
            resources.ApplyResources(this.comboBoxUsers, "comboBoxUsers");
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUsersSelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.AutoSizeProperties = true;
            this.tableLayoutPanel1.SetColumnSpan(this.propertyGrid, 2);
            // 
            // 
            // 
            this.propertyGrid.DocCommentDescription.AutoEllipsis = true;
            this.propertyGrid.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGrid.DocCommentDescription.Location = ((System.Drawing.Point)(resources.GetObject("propertyGrid.DocCommentDescription.Location")));
            this.propertyGrid.DocCommentDescription.Name = "";
            this.propertyGrid.DocCommentDescription.Size = ((System.Drawing.Size)(resources.GetObject("propertyGrid.DocCommentDescription.Size")));
            this.propertyGrid.DocCommentDescription.TabIndex = ((int)(resources.GetObject("propertyGrid.DocCommentDescription.TabIndex")));
            this.propertyGrid.DocCommentImage = null;
            // 
            // 
            // 
            this.propertyGrid.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGrid.DocCommentTitle.Font = ((System.Drawing.Font)(resources.GetObject("propertyGrid.DocCommentTitle.Font")));
            this.propertyGrid.DocCommentTitle.Location = ((System.Drawing.Point)(resources.GetObject("propertyGrid.DocCommentTitle.Location")));
            this.propertyGrid.DocCommentTitle.Name = "";
            this.propertyGrid.DocCommentTitle.Size = ((System.Drawing.Size)(resources.GetObject("propertyGrid.DocCommentTitle.Size")));
            this.propertyGrid.DocCommentTitle.TabIndex = ((int)(resources.GetObject("propertyGrid.DocCommentTitle.TabIndex")));
            this.propertyGrid.DocCommentTitle.UseMnemonic = false;
            resources.ApplyResources(this.propertyGrid, "propertyGrid");
            this.propertyGrid.Name = "propertyGrid";
            // 
            // 
            // 
            this.propertyGrid.ToolStrip.AccessibleName = resources.GetString("propertyGrid.ToolStrip.AccessibleName");
            this.propertyGrid.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.propertyGrid.ToolStrip.AllowMerge = false;
            this.propertyGrid.ToolStrip.AutoSize = ((bool)(resources.GetObject("propertyGrid.ToolStrip.AutoSize")));
            this.propertyGrid.ToolStrip.CanOverflow = false;
            this.propertyGrid.ToolStrip.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("propertyGrid.ToolStrip.Dock")));
            this.propertyGrid.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.propertyGrid.ToolStrip.Location = ((System.Drawing.Point)(resources.GetObject("propertyGrid.ToolStrip.Location")));
            this.propertyGrid.ToolStrip.Name = "";
            this.propertyGrid.ToolStrip.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("propertyGrid.ToolStrip.Padding")));
            this.propertyGrid.ToolStrip.Size = ((System.Drawing.Size)(resources.GetObject("propertyGrid.ToolStrip.Size")));
            this.propertyGrid.ToolStrip.TabIndex = ((int)(resources.GetObject("propertyGrid.ToolStrip.TabIndex")));
            this.propertyGrid.ToolStrip.TabStop = true;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyValueChanged);
            // 
            // SettingsTreeControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsTreeControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private CcLabel label1;
		private System.Windows.Forms.ComboBox comboBoxUsers;
		private PropertyGridEx propertyGrid;
	}
}

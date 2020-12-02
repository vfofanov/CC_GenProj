using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace Northwind.Client.Wizards.CustomersWizard
{
    partial class Page1
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

            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();

			this._companynameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._companynameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._contactnameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._contactnameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._contacttitleCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._contacttitleCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._phoneCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._phoneCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._faxCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._faxCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();

			((System.ComponentModel.ISupportInitialize)(this._companynameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._contactnameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._contacttitleCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._phoneCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._faxCcTextEditor)).BeginInit();

            this.tableLayout.SuspendLayout();
            this.SuspendLayout();

             // 
            // tableLayout
            // 
            this.tableLayout.AutoSize = true;
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 6;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this._companynameCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._companynameCcTextEditor, 1, 0);
            this.tableLayout.Controls.Add(this._contactnameCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._contactnameCcTextEditor, 1, 1);
            this.tableLayout.Controls.Add(this._contacttitleCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._contacttitleCcTextEditor, 1, 2);
            this.tableLayout.Controls.Add(this._phoneCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._phoneCcTextEditor, 1, 3);
            this.tableLayout.Controls.Add(this._faxCcLabel, 0, 4);
            this.tableLayout.Controls.Add(this._faxCcTextEditor, 1, 4);

            // 
            // _companynameCcLabel
            // 
            this._companynameCcLabel.Text = "Company Name" + ":";
		    this._companynameCcLabel.Name = "_companynameCcLabel";
            this._companynameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._companynameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _companynameCcTextEditor
            // 
		    this._companynameCcTextEditor.Name = "_companynameCcTextEditor";
            this._companynameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._companynameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._companynameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "CompanyName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._companynameCcTextEditor.TabIndex = 0;


            // 
            // _contactnameCcLabel
            // 
            this._contactnameCcLabel.Text = "Contact Name" + ":";
		    this._contactnameCcLabel.Name = "_contactnameCcLabel";
            this._contactnameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._contactnameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _contactnameCcTextEditor
            // 
		    this._contactnameCcTextEditor.Name = "_contactnameCcTextEditor";
            this._contactnameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._contactnameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._contactnameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ContactName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._contactnameCcTextEditor.TabIndex = 1;


            // 
            // _contacttitleCcLabel
            // 
            this._contacttitleCcLabel.Text = "Contact Title" + ":";
		    this._contacttitleCcLabel.Name = "_contacttitleCcLabel";
            this._contacttitleCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._contacttitleCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _contacttitleCcTextEditor
            // 
		    this._contacttitleCcTextEditor.Name = "_contacttitleCcTextEditor";
            this._contacttitleCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._contacttitleCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._contacttitleCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ContactTitle", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._contacttitleCcTextEditor.TabIndex = 2;


            // 
            // _phoneCcLabel
            // 
            this._phoneCcLabel.Text = "Phone" + ":";
		    this._phoneCcLabel.Name = "_phoneCcLabel";
            this._phoneCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._phoneCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _phoneCcTextEditor
            // 
		    this._phoneCcTextEditor.Name = "_phoneCcTextEditor";
            this._phoneCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._phoneCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._phoneCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Phone", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._phoneCcTextEditor.TabIndex = 3;


            // 
            // _faxCcLabel
            // 
            this._faxCcLabel.Text = "Fax" + ":";
		    this._faxCcLabel.Name = "_faxCcLabel";
            this._faxCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._faxCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _faxCcTextEditor
            // 
		    this._faxCcTextEditor.Name = "_faxCcTextEditor";
            this._faxCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._faxCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._faxCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Fax", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._faxCcTextEditor.TabIndex = 4;




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._companynameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._contactnameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._contacttitleCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._phoneCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._faxCcTextEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _companynameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _companynameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _contactnameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _contactnameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _contacttitleCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _contacttitleCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _phoneCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _phoneCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _faxCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _faxCcTextEditor;
		
    }
}


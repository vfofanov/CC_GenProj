using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace Northwind.Client.Wizards.SuppliersWizard
{
    partial class Page2
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

			this._addressCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._addressCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._cityCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._cityCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._countryCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._countryCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._faxCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._faxCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._homepageCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._homepageCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._phoneCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._phoneCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._postalcodeCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._postalcodeCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._regionCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._regionCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();

			((System.ComponentModel.ISupportInitialize)(this._addressCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._cityCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._countryCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._faxCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._homepageCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._phoneCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._postalcodeCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._regionCcTextEditor)).BeginInit();

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
            this.tableLayout.RowCount = 9;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this._addressCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._addressCcTextEditor, 1, 0);
            this.tableLayout.Controls.Add(this._cityCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._cityCcTextEditor, 1, 1);
            this.tableLayout.Controls.Add(this._countryCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._countryCcTextEditor, 1, 2);
            this.tableLayout.Controls.Add(this._faxCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._faxCcTextEditor, 1, 3);
            this.tableLayout.Controls.Add(this._homepageCcLabel, 0, 4);
            this.tableLayout.Controls.Add(this._homepageCcTextEditor, 1, 4);
            this.tableLayout.Controls.Add(this._phoneCcLabel, 0, 5);
            this.tableLayout.Controls.Add(this._phoneCcTextEditor, 1, 5);
            this.tableLayout.Controls.Add(this._postalcodeCcLabel, 0, 6);
            this.tableLayout.Controls.Add(this._postalcodeCcTextEditor, 1, 6);
            this.tableLayout.Controls.Add(this._regionCcLabel, 0, 7);
            this.tableLayout.Controls.Add(this._regionCcTextEditor, 1, 7);

            // 
            // _addressCcLabel
            // 
            this._addressCcLabel.Text = "Address" + ":";
		    this._addressCcLabel.Name = "_addressCcLabel";
            this._addressCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._addressCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _addressCcTextEditor
            // 
		    this._addressCcTextEditor.Name = "_addressCcTextEditor";
            this._addressCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._addressCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._addressCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Address", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._addressCcTextEditor.TabIndex = 0;


            // 
            // _cityCcLabel
            // 
            this._cityCcLabel.Text = "City" + ":";
		    this._cityCcLabel.Name = "_cityCcLabel";
            this._cityCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._cityCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _cityCcTextEditor
            // 
		    this._cityCcTextEditor.Name = "_cityCcTextEditor";
            this._cityCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._cityCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._cityCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "City", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._cityCcTextEditor.TabIndex = 1;


            // 
            // _countryCcLabel
            // 
            this._countryCcLabel.Text = "Country" + ":";
		    this._countryCcLabel.Name = "_countryCcLabel";
            this._countryCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._countryCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _countryCcTextEditor
            // 
		    this._countryCcTextEditor.Name = "_countryCcTextEditor";
            this._countryCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._countryCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._countryCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Country", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._countryCcTextEditor.TabIndex = 2;


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
		    this._faxCcTextEditor.TabIndex = 3;


            // 
            // _homepageCcLabel
            // 
            this._homepageCcLabel.Text = "Home Page" + ":";
		    this._homepageCcLabel.Name = "_homepageCcLabel";
            this._homepageCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._homepageCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _homepageCcTextEditor
            // 
		    this._homepageCcTextEditor.Name = "_homepageCcTextEditor";
            this._homepageCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._homepageCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._homepageCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "HomePage", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._homepageCcTextEditor.TabIndex = 4;


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
		    this._phoneCcTextEditor.TabIndex = 5;


            // 
            // _postalcodeCcLabel
            // 
            this._postalcodeCcLabel.Text = "Postal Code" + ":";
		    this._postalcodeCcLabel.Name = "_postalcodeCcLabel";
            this._postalcodeCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._postalcodeCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _postalcodeCcTextEditor
            // 
		    this._postalcodeCcTextEditor.Name = "_postalcodeCcTextEditor";
            this._postalcodeCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._postalcodeCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._postalcodeCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "PostalCode", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._postalcodeCcTextEditor.TabIndex = 6;


            // 
            // _regionCcLabel
            // 
            this._regionCcLabel.Text = "Region" + ":";
		    this._regionCcLabel.Name = "_regionCcLabel";
            this._regionCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._regionCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _regionCcTextEditor
            // 
		    this._regionCcTextEditor.Name = "_regionCcTextEditor";
            this._regionCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._regionCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._regionCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Region", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._regionCcTextEditor.TabIndex = 7;




            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page2";                    
			((System.ComponentModel.ISupportInitialize)(this._addressCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._cityCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._countryCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._faxCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._homepageCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._phoneCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._postalcodeCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._regionCcTextEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _addressCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _addressCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _cityCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _cityCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _countryCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _countryCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _faxCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _faxCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _homepageCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _homepageCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _phoneCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _phoneCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _postalcodeCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _postalcodeCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _regionCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _regionCcTextEditor;
		
    }
}


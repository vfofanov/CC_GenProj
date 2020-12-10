using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.OrderWizard
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

			this._shipviaCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shipviaCcComboBox = new CcComboBox();
			this._shippeddateCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shippeddateCcDateEditor = new CcDateEditor();
			this._freightCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._freightCcNumericEditor = new CcNumericEditor();
			this._shipnameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shipnameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._shipaddressCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shipaddressCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._shipcityCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shipcityCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._shipregionCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shipregionCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._shippostalcodeCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shippostalcodeCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._shipcountryCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._shipcountryCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();

			((System.ComponentModel.ISupportInitialize)(this._shipviaCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shippeddateCcDateEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._freightCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shipnameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shipaddressCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shipcityCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shipregionCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shippostalcodeCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shipcountryCcTextEditor)).BeginInit();

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
            this.tableLayout.RowCount = 10;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this._shipviaCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._shipviaCcComboBox, 1, 0);
            this.tableLayout.Controls.Add(this._shippeddateCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._shippeddateCcDateEditor, 1, 1);
            this.tableLayout.Controls.Add(this._freightCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._freightCcNumericEditor, 1, 2);
            this.tableLayout.Controls.Add(this._shipnameCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._shipnameCcTextEditor, 1, 3);
            this.tableLayout.Controls.Add(this._shipaddressCcLabel, 0, 4);
            this.tableLayout.Controls.Add(this._shipaddressCcTextEditor, 1, 4);
            this.tableLayout.Controls.Add(this._shipcityCcLabel, 0, 5);
            this.tableLayout.Controls.Add(this._shipcityCcTextEditor, 1, 5);
            this.tableLayout.Controls.Add(this._shipregionCcLabel, 0, 6);
            this.tableLayout.Controls.Add(this._shipregionCcTextEditor, 1, 6);
            this.tableLayout.Controls.Add(this._shippostalcodeCcLabel, 0, 7);
            this.tableLayout.Controls.Add(this._shippostalcodeCcTextEditor, 1, 7);
            this.tableLayout.Controls.Add(this._shipcountryCcLabel, 0, 8);
            this.tableLayout.Controls.Add(this._shipcountryCcTextEditor, 1, 8);

            // 
            // _shipviaCcLabel
            // 
            this._shipviaCcLabel.Text = "Shipper Company Name" + ":";
		    this._shipviaCcLabel.Name = "_shipviaCcLabel";
            this._shipviaCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shipviaCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shipviaCcComboBox
            // 
		    this._shipviaCcComboBox.Name = "_shipviaCcComboBox";
            this._shipviaCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shipviaCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shipviaCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "ShipVia", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shipviaCcComboBox.TabIndex = 0;
            this._shipviaCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._shipviaCcComboBoxBindingSource.IsPagingEnabled = false;

            this._shipviaCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this._shipviaCcComboBox.IsSearchable = false;
            this._shipviaCcComboBox.DisplayMember = "CompanyName";
            this._shipviaCcComboBox.ValueMember = "Id";
            this._shipviaCcComboBox.DataSource = _shipviaCcComboBoxBindingSource;


            // 
            // _shippeddateCcLabel
            // 
            this._shippeddateCcLabel.Text = "Shipped Date" + ":";
		    this._shippeddateCcLabel.Name = "_shippeddateCcLabel";
            this._shippeddateCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shippeddateCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shippeddateCcDateEditor
            // 
		    this._shippeddateCcDateEditor.Name = "_shippeddateCcDateEditor";
            this._shippeddateCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shippeddateCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shippeddateCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "ShippedDate", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shippeddateCcDateEditor.TabIndex = 1;
            this._shippeddateCcDateEditor.MaskInput = "{date}";


            // 
            // _freightCcLabel
            // 
            this._freightCcLabel.Text = "Freight" + ":";
		    this._freightCcLabel.Name = "_freightCcLabel";
            this._freightCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._freightCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _freightCcNumericEditor
            // 
		    this._freightCcNumericEditor.Name = "_freightCcNumericEditor";
            this._freightCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._freightCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._freightCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "Freight", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._freightCcNumericEditor.TabIndex = 2;
this._freightCcNumericEditor.Nullable = true;


            // 
            // _shipnameCcLabel
            // 
            this._shipnameCcLabel.Text = "Ship Name" + ":";
		    this._shipnameCcLabel.Name = "_shipnameCcLabel";
            this._shipnameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shipnameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shipnameCcTextEditor
            // 
		    this._shipnameCcTextEditor.Name = "_shipnameCcTextEditor";
            this._shipnameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shipnameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shipnameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ShipName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shipnameCcTextEditor.TabIndex = 3;


            // 
            // _shipaddressCcLabel
            // 
            this._shipaddressCcLabel.Text = "Ship Address" + ":";
		    this._shipaddressCcLabel.Name = "_shipaddressCcLabel";
            this._shipaddressCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shipaddressCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shipaddressCcTextEditor
            // 
		    this._shipaddressCcTextEditor.Name = "_shipaddressCcTextEditor";
            this._shipaddressCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shipaddressCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shipaddressCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ShipAddress", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shipaddressCcTextEditor.TabIndex = 4;


            // 
            // _shipcityCcLabel
            // 
            this._shipcityCcLabel.Text = "Ship City" + ":";
		    this._shipcityCcLabel.Name = "_shipcityCcLabel";
            this._shipcityCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shipcityCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shipcityCcTextEditor
            // 
		    this._shipcityCcTextEditor.Name = "_shipcityCcTextEditor";
            this._shipcityCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shipcityCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shipcityCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ShipCity", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shipcityCcTextEditor.TabIndex = 5;


            // 
            // _shipregionCcLabel
            // 
            this._shipregionCcLabel.Text = "Ship Region" + ":";
		    this._shipregionCcLabel.Name = "_shipregionCcLabel";
            this._shipregionCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shipregionCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shipregionCcTextEditor
            // 
		    this._shipregionCcTextEditor.Name = "_shipregionCcTextEditor";
            this._shipregionCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shipregionCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shipregionCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ShipRegion", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shipregionCcTextEditor.TabIndex = 6;


            // 
            // _shippostalcodeCcLabel
            // 
            this._shippostalcodeCcLabel.Text = "Ship Postal Code" + ":";
		    this._shippostalcodeCcLabel.Name = "_shippostalcodeCcLabel";
            this._shippostalcodeCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shippostalcodeCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shippostalcodeCcTextEditor
            // 
		    this._shippostalcodeCcTextEditor.Name = "_shippostalcodeCcTextEditor";
            this._shippostalcodeCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shippostalcodeCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shippostalcodeCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ShipPostalCode", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shippostalcodeCcTextEditor.TabIndex = 7;


            // 
            // _shipcountryCcLabel
            // 
            this._shipcountryCcLabel.Text = "Ship Country" + ":";
		    this._shipcountryCcLabel.Name = "_shipcountryCcLabel";
            this._shipcountryCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._shipcountryCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _shipcountryCcTextEditor
            // 
		    this._shipcountryCcTextEditor.Name = "_shipcountryCcTextEditor";
            this._shipcountryCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._shipcountryCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._shipcountryCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ShipCountry", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._shipcountryCcTextEditor.TabIndex = 8;




            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page2";                    
			((System.ComponentModel.ISupportInitialize)(this._shipviaCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shippeddateCcDateEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._freightCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shipnameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shipaddressCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shipcityCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shipregionCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shippostalcodeCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shipcountryCcTextEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shipviaCcLabel;
		private CcComboBox _shipviaCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shippeddateCcLabel;
		private CcDateEditor _shippeddateCcDateEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _freightCcLabel;
		private CcNumericEditor _freightCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shipnameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _shipnameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shipaddressCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _shipaddressCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shipcityCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _shipcityCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shipregionCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _shipregionCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shippostalcodeCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _shippostalcodeCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _shipcountryCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _shipcountryCcTextEditor;
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _shipviaCcComboBoxBindingSource;
		
		
		
    }
}


using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.ProductWizard
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

			this._productnameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._productnameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._categoryidCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._categoryidCcComboBox = new CcComboBox();
			this._quantityperunitCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._quantityperunitCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._unitpriceCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._unitpriceCcNumericEditor = new CcNumericEditor();
			this._unitsinstockCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._unitsinstockCcNumericEditor = new CcNumericEditor();
			this._unitsonorderCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._unitsonorderCcNumericEditor = new CcNumericEditor();
			this._reorderlevelCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._reorderlevelCcNumericEditor = new CcNumericEditor();
			this._discontinuedCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._discontinuedCcCheckBox = new BusinessFramework.Client.WinForms.IG.Controls.CcCheckBox();
			this._supplieridCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._supplieridCcComboBox = new CcComboBox();

			((System.ComponentModel.ISupportInitialize)(this._productnameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._categoryidCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._quantityperunitCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._unitpriceCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._unitsinstockCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._unitsonorderCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._reorderlevelCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._discontinuedCcCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._supplieridCcComboBox)).BeginInit();

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
            this.tableLayout.Controls.Add(this._productnameCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._productnameCcTextEditor, 1, 0);
            this.tableLayout.Controls.Add(this._categoryidCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._categoryidCcComboBox, 1, 1);
            this.tableLayout.Controls.Add(this._quantityperunitCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._quantityperunitCcTextEditor, 1, 2);
            this.tableLayout.Controls.Add(this._unitpriceCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._unitpriceCcNumericEditor, 1, 3);
            this.tableLayout.Controls.Add(this._unitsinstockCcLabel, 0, 4);
            this.tableLayout.Controls.Add(this._unitsinstockCcNumericEditor, 1, 4);
            this.tableLayout.Controls.Add(this._unitsonorderCcLabel, 0, 5);
            this.tableLayout.Controls.Add(this._unitsonorderCcNumericEditor, 1, 5);
            this.tableLayout.Controls.Add(this._reorderlevelCcLabel, 0, 6);
            this.tableLayout.Controls.Add(this._reorderlevelCcNumericEditor, 1, 6);
            this.tableLayout.Controls.Add(this._discontinuedCcLabel, 0, 7);
            this.tableLayout.Controls.Add(this._discontinuedCcCheckBox, 1, 7);
            this.tableLayout.Controls.Add(this._supplieridCcLabel, 0, 8);
            this.tableLayout.Controls.Add(this._supplieridCcComboBox, 1, 8);

            // 
            // _productnameCcLabel
            // 
            this._productnameCcLabel.Text = "Product Name" + ":";
		    this._productnameCcLabel.Name = "_productnameCcLabel";
            this._productnameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._productnameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _productnameCcTextEditor
            // 
		    this._productnameCcTextEditor.Name = "_productnameCcTextEditor";
            this._productnameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._productnameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._productnameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "ProductName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._productnameCcTextEditor.TabIndex = 0;


            // 
            // _categoryidCcLabel
            // 
            this._categoryidCcLabel.Text = "Category" + ":";
		    this._categoryidCcLabel.Name = "_categoryidCcLabel";
            this._categoryidCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._categoryidCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _categoryidCcComboBox
            // 
		    this._categoryidCcComboBox.Name = "_categoryidCcComboBox";
            this._categoryidCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._categoryidCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._categoryidCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "CategoryID", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._categoryidCcComboBox.TabIndex = 1;
            this._categoryidCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._categoryidCcComboBoxBindingSource.IsPagingEnabled = false;

            this._categoryidCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this._categoryidCcComboBox.IsSearchable = false;
            this._categoryidCcComboBox.DisplayMember = "CategoryName";
            this._categoryidCcComboBox.ValueMember = "Id";
            this._categoryidCcComboBox.DataSource = _categoryidCcComboBoxBindingSource;


            // 
            // _quantityperunitCcLabel
            // 
            this._quantityperunitCcLabel.Text = "Quantity Per Unit" + ":";
		    this._quantityperunitCcLabel.Name = "_quantityperunitCcLabel";
            this._quantityperunitCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._quantityperunitCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _quantityperunitCcTextEditor
            // 
		    this._quantityperunitCcTextEditor.Name = "_quantityperunitCcTextEditor";
            this._quantityperunitCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._quantityperunitCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._quantityperunitCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "QuantityPerUnit", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._quantityperunitCcTextEditor.TabIndex = 2;


            // 
            // _unitpriceCcLabel
            // 
            this._unitpriceCcLabel.Text = "Unit Price" + ":";
		    this._unitpriceCcLabel.Name = "_unitpriceCcLabel";
            this._unitpriceCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._unitpriceCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _unitpriceCcNumericEditor
            // 
		    this._unitpriceCcNumericEditor.Name = "_unitpriceCcNumericEditor";
            this._unitpriceCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._unitpriceCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._unitpriceCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "UnitPrice", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._unitpriceCcNumericEditor.TabIndex = 3;
this._unitpriceCcNumericEditor.Nullable = true;


            // 
            // _unitsinstockCcLabel
            // 
            this._unitsinstockCcLabel.Text = "Units In Stock" + ":";
		    this._unitsinstockCcLabel.Name = "_unitsinstockCcLabel";
            this._unitsinstockCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._unitsinstockCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _unitsinstockCcNumericEditor
            // 
		    this._unitsinstockCcNumericEditor.Name = "_unitsinstockCcNumericEditor";
            this._unitsinstockCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._unitsinstockCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._unitsinstockCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "UnitsInStock", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._unitsinstockCcNumericEditor.TabIndex = 4;
this._unitsinstockCcNumericEditor.Nullable = true;


            // 
            // _unitsonorderCcLabel
            // 
            this._unitsonorderCcLabel.Text = "Units On Order" + ":";
		    this._unitsonorderCcLabel.Name = "_unitsonorderCcLabel";
            this._unitsonorderCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._unitsonorderCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _unitsonorderCcNumericEditor
            // 
		    this._unitsonorderCcNumericEditor.Name = "_unitsonorderCcNumericEditor";
            this._unitsonorderCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._unitsonorderCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._unitsonorderCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "UnitsOnOrder", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._unitsonorderCcNumericEditor.TabIndex = 5;
this._unitsonorderCcNumericEditor.Nullable = true;


            // 
            // _reorderlevelCcLabel
            // 
            this._reorderlevelCcLabel.Text = "Reorder Level" + ":";
		    this._reorderlevelCcLabel.Name = "_reorderlevelCcLabel";
            this._reorderlevelCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._reorderlevelCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _reorderlevelCcNumericEditor
            // 
		    this._reorderlevelCcNumericEditor.Name = "_reorderlevelCcNumericEditor";
            this._reorderlevelCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._reorderlevelCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._reorderlevelCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "ReorderLevel", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._reorderlevelCcNumericEditor.TabIndex = 6;
this._reorderlevelCcNumericEditor.Nullable = true;


            // 
            // _discontinuedCcLabel
            // 
            this._discontinuedCcLabel.Text = "Discontinued" + ":";
		    this._discontinuedCcLabel.Name = "_discontinuedCcLabel";
            this._discontinuedCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._discontinuedCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _discontinuedCcCheckBox
            // 
		    this._discontinuedCcCheckBox.Name = "_discontinuedCcCheckBox";
            this._discontinuedCcCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 5);
            this._discontinuedCcCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._discontinuedCcCheckBox.DataBindings.Add(new Binding("Checked", this.dataObjectBindingSource, "Discontinued", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._discontinuedCcCheckBox.TabIndex = 7;


            // 
            // _supplieridCcLabel
            // 
            this._supplieridCcLabel.Text = "Supplier" + ":";
		    this._supplieridCcLabel.Name = "_supplieridCcLabel";
            this._supplieridCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._supplieridCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _supplieridCcComboBox
            // 
		    this._supplieridCcComboBox.Name = "_supplieridCcComboBox";
            this._supplieridCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._supplieridCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._supplieridCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "SupplierID", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._supplieridCcComboBox.TabIndex = 8;
            this._supplieridCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._supplieridCcComboBoxBindingSource.IsPagingEnabled = false;

            this._supplieridCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this._supplieridCcComboBox.IsSearchable = false;
            this._supplieridCcComboBox.DisplayMember = "CompanyName";
            this._supplieridCcComboBox.ValueMember = "Id";
            this._supplieridCcComboBox.DataSource = _supplieridCcComboBoxBindingSource;




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._productnameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._categoryidCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._quantityperunitCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._unitpriceCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._unitsinstockCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._unitsonorderCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._reorderlevelCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._discontinuedCcCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._supplieridCcComboBox)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _productnameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _productnameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _categoryidCcLabel;
		private CcComboBox _categoryidCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _quantityperunitCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _quantityperunitCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _unitpriceCcLabel;
		private CcNumericEditor _unitpriceCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _unitsinstockCcLabel;
		private CcNumericEditor _unitsinstockCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _unitsonorderCcLabel;
		private CcNumericEditor _unitsonorderCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _reorderlevelCcLabel;
		private CcNumericEditor _reorderlevelCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _discontinuedCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcCheckBox _discontinuedCcCheckBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _supplieridCcLabel;
		private CcComboBox _supplieridCcComboBox;
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _categoryidCcComboBoxBindingSource;
		
		
		
		
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _supplieridCcComboBoxBindingSource;
		
    }
}


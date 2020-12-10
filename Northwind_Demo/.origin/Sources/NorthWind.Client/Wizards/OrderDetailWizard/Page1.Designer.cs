using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.OrderDetailWizard
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

			this._productidCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._productidCcComboBox = new CcComboBox();
			this._unitpriceCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._unitpriceCcCurrencyEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcCurrencyEditor();
			this._quantityCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._quantityCcNumericEditor = new CcNumericEditor();
			this._discountCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._discountCcNumericEditor = new CcNumericEditor();

			((System.ComponentModel.ISupportInitialize)(this._productidCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._unitpriceCcCurrencyEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._quantityCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._discountCcNumericEditor)).BeginInit();

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
            this.tableLayout.RowCount = 5;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this._productidCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._productidCcComboBox, 1, 0);
            this.tableLayout.Controls.Add(this._unitpriceCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._unitpriceCcCurrencyEditor, 1, 1);
            this.tableLayout.Controls.Add(this._quantityCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._quantityCcNumericEditor, 1, 2);
            this.tableLayout.Controls.Add(this._discountCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._discountCcNumericEditor, 1, 3);

            // 
            // _productidCcLabel
            // 
            this._productidCcLabel.Text = "Product Name" + ":";
		    this._productidCcLabel.Name = "_productidCcLabel";
            this._productidCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._productidCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _productidCcComboBox
            // 
		    this._productidCcComboBox.Name = "_productidCcComboBox";
            this._productidCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._productidCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._productidCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "ProductID", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._productidCcComboBox.TabIndex = 0;
            this._productidCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._productidCcComboBoxBindingSource.IsPagingEnabled = false;

            this._productidCcComboBox.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this._productidCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDown;
            this._productidCcComboBox.IsSearchable = true;
            this._productidCcComboBox.OnNeedUpdateDataSource += UpdateDataSourceProductIDDataSource;
            this._productidCcComboBox.TextCounter = 2;
            this._productidCcComboBox.TimeCounter = 1000;
            this._productidCcComboBox.TopItems = 8;
            this._productidCcComboBox.DisplayMember = "ProductName";
            this._productidCcComboBox.ValueMember = "Id";
            this._productidCcComboBox.DataSource = _productidCcComboBoxBindingSource;


            // 
            // _unitpriceCcLabel
            // 
            this._unitpriceCcLabel.Text = "Unit Price" + ":";
		    this._unitpriceCcLabel.Name = "_unitpriceCcLabel";
            this._unitpriceCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._unitpriceCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _unitpriceCcCurrencyEditor
            // 
		    this._unitpriceCcCurrencyEditor.Name = "_unitpriceCcCurrencyEditor";
            this._unitpriceCcCurrencyEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._unitpriceCcCurrencyEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._unitpriceCcCurrencyEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "UnitPrice", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._unitpriceCcCurrencyEditor.TabIndex = 1;
this._unitpriceCcCurrencyEditor.FormatProvider = System.Globalization.CultureInfo.CreateSpecificCulture( "en-US");


            // 
            // _quantityCcLabel
            // 
            this._quantityCcLabel.Text = "Quantity" + ":";
		    this._quantityCcLabel.Name = "_quantityCcLabel";
            this._quantityCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._quantityCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _quantityCcNumericEditor
            // 
		    this._quantityCcNumericEditor.Name = "_quantityCcNumericEditor";
            this._quantityCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._quantityCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._quantityCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._quantityCcNumericEditor.TabIndex = 2;


            // 
            // _discountCcLabel
            // 
            this._discountCcLabel.Text = "Discount, %" + ":";
		    this._discountCcLabel.Name = "_discountCcLabel";
            this._discountCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._discountCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _discountCcNumericEditor
            // 
		    this._discountCcNumericEditor.Name = "_discountCcNumericEditor";
            this._discountCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._discountCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._discountCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "Discount", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._discountCcNumericEditor.TabIndex = 3;
this._discountCcNumericEditor.MaskInput = "nnnnnnnnnnnnnnn.nn";




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._productidCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._unitpriceCcCurrencyEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._quantityCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._discountCcNumericEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _productidCcLabel;
		private CcComboBox _productidCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _unitpriceCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcCurrencyEditor _unitpriceCcCurrencyEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _quantityCcLabel;
		private CcNumericEditor _quantityCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _discountCcLabel;
		private CcNumericEditor _discountCcNumericEditor;
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _productidCcComboBoxBindingSource;
		
		
		
		
    }
}


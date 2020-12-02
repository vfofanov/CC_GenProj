using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace Northwind.Client.Wizards.OrdersWizard
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

			this._orderdateCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._orderdateCcDateEditor = new CcDateEditor();
			this._customeridCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._customeridCcComboBox = new CcComboBox();
			this._employeeidCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._employeeidCcComboBox = new CcComboBox();
			this._requireddateCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._requireddateCcDateEditor = new CcDateEditor();

			((System.ComponentModel.ISupportInitialize)(this._orderdateCcDateEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._customeridCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._employeeidCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._requireddateCcDateEditor)).BeginInit();

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
            this.tableLayout.Controls.Add(this._orderdateCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._orderdateCcDateEditor, 1, 0);
            this.tableLayout.Controls.Add(this._customeridCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._customeridCcComboBox, 1, 1);
            this.tableLayout.Controls.Add(this._employeeidCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._employeeidCcComboBox, 1, 2);
            this.tableLayout.Controls.Add(this._requireddateCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._requireddateCcDateEditor, 1, 3);

            // 
            // _orderdateCcLabel
            // 
            this._orderdateCcLabel.Text = "Order Date" + ":";
		    this._orderdateCcLabel.Name = "_orderdateCcLabel";
            this._orderdateCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._orderdateCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _orderdateCcDateEditor
            // 
		    this._orderdateCcDateEditor.Name = "_orderdateCcDateEditor";
            this._orderdateCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._orderdateCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._orderdateCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "OrderDate", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._orderdateCcDateEditor.TabIndex = 0;
            this._orderdateCcDateEditor.MaskInput = "{date}";


            // 
            // _customeridCcLabel
            // 
            this._customeridCcLabel.Text = "Customer Company Name" + ":";
		    this._customeridCcLabel.Name = "_customeridCcLabel";
            this._customeridCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._customeridCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _customeridCcComboBox
            // 
		    this._customeridCcComboBox.Name = "_customeridCcComboBox";
            this._customeridCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._customeridCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._customeridCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "CustomerID", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._customeridCcComboBox.TabIndex = 1;
            this._customeridCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._customeridCcComboBoxBindingSource.IsPagingEnabled = false;

            this._customeridCcComboBox.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this._customeridCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDown;
            this._customeridCcComboBox.IsSearchable = true;
            this._customeridCcComboBox.OnNeedUpdateDataSource += UpdateDataSourceCustomerIDDataSource;
            this._customeridCcComboBox.TextCounter = 1;
            this._customeridCcComboBox.TimeCounter = 50;
            this._customeridCcComboBox.TopItems = 20;
            this._customeridCcComboBox.DisplayMember = "CompanyName";
            this._customeridCcComboBox.ValueMember = "Id";
            this._customeridCcComboBox.DataSource = _customeridCcComboBoxBindingSource;


            // 
            // _employeeidCcLabel
            // 
            this._employeeidCcLabel.Text = "Employee" + ":";
		    this._employeeidCcLabel.Name = "_employeeidCcLabel";
            this._employeeidCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._employeeidCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _employeeidCcComboBox
            // 
		    this._employeeidCcComboBox.Name = "_employeeidCcComboBox";
            this._employeeidCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._employeeidCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._employeeidCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "EmployeeID", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._employeeidCcComboBox.TabIndex = 2;
            this._employeeidCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._employeeidCcComboBoxBindingSource.IsPagingEnabled = false;

            this._employeeidCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this._employeeidCcComboBox.IsSearchable = false;
            this._employeeidCcComboBox.DisplayMember = "Employee_FullName";
            this._employeeidCcComboBox.ValueMember = "Id";
            this._employeeidCcComboBox.DataSource = _employeeidCcComboBoxBindingSource;


            // 
            // _requireddateCcLabel
            // 
            this._requireddateCcLabel.Text = "Required Date" + ":";
		    this._requireddateCcLabel.Name = "_requireddateCcLabel";
            this._requireddateCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._requireddateCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _requireddateCcDateEditor
            // 
		    this._requireddateCcDateEditor.Name = "_requireddateCcDateEditor";
            this._requireddateCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._requireddateCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._requireddateCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "RequiredDate", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._requireddateCcDateEditor.TabIndex = 3;
            this._requireddateCcDateEditor.MaskInput = "{date}";




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._orderdateCcDateEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._customeridCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._employeeidCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._requireddateCcDateEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _orderdateCcLabel;
		private CcDateEditor _orderdateCcDateEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _customeridCcLabel;
		private CcComboBox _customeridCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _employeeidCcLabel;
		private CcComboBox _employeeidCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _requireddateCcLabel;
		private CcDateEditor _requireddateCcDateEditor;
		
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _customeridCcComboBoxBindingSource;
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _employeeidCcComboBoxBindingSource;
		
		
    }
}


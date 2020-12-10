using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.ReportFormQueryWizard
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

			this._employeeidCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._employeeidCcComboBox = new CcComboBox();
			this._customeridCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._customeridCcComboBox = new CcComboBox();
			this._fromCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._fromCcDateEditor = new CcDateEditor();
			this._toCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._toCcDateEditor = new CcDateEditor();
			this._useexcelCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._useexcelCcCheckBox = new BusinessFramework.Client.WinForms.IG.Controls.CcCheckBox();

			((System.ComponentModel.ISupportInitialize)(this._employeeidCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._customeridCcComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._fromCcDateEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._toCcDateEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._useexcelCcCheckBox)).BeginInit();

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
            this.tableLayout.Controls.Add(this._employeeidCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._employeeidCcComboBox, 1, 0);
            this.tableLayout.Controls.Add(this._customeridCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._customeridCcComboBox, 1, 1);
            this.tableLayout.Controls.Add(this._fromCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._fromCcDateEditor, 1, 2);
            this.tableLayout.Controls.Add(this._toCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._toCcDateEditor, 1, 3);
            this.tableLayout.Controls.Add(this._useexcelCcLabel, 0, 4);
            this.tableLayout.Controls.Add(this._useexcelCcCheckBox, 1, 4);

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
		    this._employeeidCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._employeeidCcComboBox.TabIndex = 0;
            this._employeeidCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._employeeidCcComboBoxBindingSource.IsPagingEnabled = false;

            this._employeeidCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this._employeeidCcComboBox.IsSearchable = false;
            this._employeeidCcComboBox.DisplayMember = "FirstName";
            this._employeeidCcComboBox.ValueMember = "Id";
            this._employeeidCcComboBox.DataSource = _employeeidCcComboBoxBindingSource;


            // 
            // _customeridCcLabel
            // 
            this._customeridCcLabel.Text = "Customer" + ":";
		    this._customeridCcLabel.Name = "_customeridCcLabel";
            this._customeridCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._customeridCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _customeridCcComboBox
            // 
		    this._customeridCcComboBox.Name = "_customeridCcComboBox";
            this._customeridCcComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._customeridCcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._customeridCcComboBox.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "CustomerId", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._customeridCcComboBox.TabIndex = 1;
            this._customeridCcComboBoxBindingSource = new BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy();

            this._customeridCcComboBoxBindingSource.IsPagingEnabled = false;

            this._customeridCcComboBox.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this._customeridCcComboBox.DropDownStyle = Infragistics.Win.DropDownStyle.DropDown;
            this._customeridCcComboBox.IsSearchable = true;
            this._customeridCcComboBox.OnNeedUpdateDataSource += UpdateDataSourceCustomerIdDataSource;
            this._customeridCcComboBox.TextCounter = 0;
            this._customeridCcComboBox.TimeCounter = 0;
            this._customeridCcComboBox.TopItems = 0;
            this._customeridCcComboBox.DisplayMember = "CompanyName";
            this._customeridCcComboBox.ValueMember = "Id";
            this._customeridCcComboBox.DataSource = _customeridCcComboBoxBindingSource;


            // 
            // _fromCcLabel
            // 
            this._fromCcLabel.Text = "From" + ":";
		    this._fromCcLabel.Name = "_fromCcLabel";
            this._fromCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._fromCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _fromCcDateEditor
            // 
		    this._fromCcDateEditor.Name = "_fromCcDateEditor";
            this._fromCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._fromCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._fromCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "From", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._fromCcDateEditor.TabIndex = 2;
            this._fromCcDateEditor.MaskInput = "{date}";


            // 
            // _toCcLabel
            // 
            this._toCcLabel.Text = "To" + ":";
		    this._toCcLabel.Name = "_toCcLabel";
            this._toCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._toCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _toCcDateEditor
            // 
		    this._toCcDateEditor.Name = "_toCcDateEditor";
            this._toCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._toCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._toCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "To", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._toCcDateEditor.TabIndex = 3;
            this._toCcDateEditor.MaskInput = "{date}";


            // 
            // _useexcelCcLabel
            // 
            this._useexcelCcLabel.Text = "Use Excel Format" + ":";
		    this._useexcelCcLabel.Name = "_useexcelCcLabel";
            this._useexcelCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._useexcelCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _useexcelCcCheckBox
            // 
		    this._useexcelCcCheckBox.Name = "_useexcelCcCheckBox";
            this._useexcelCcCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 5);
            this._useexcelCcCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._useexcelCcCheckBox.DataBindings.Add(new Binding("Checked", this.dataObjectBindingSource, "useExcel", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._useexcelCcCheckBox.TabIndex = 4;




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._employeeidCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._customeridCcComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._fromCcDateEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._toCcDateEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._useexcelCcCheckBox)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _employeeidCcLabel;
		private CcComboBox _employeeidCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _customeridCcLabel;
		private CcComboBox _customeridCcComboBox;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _fromCcLabel;
		private CcDateEditor _fromCcDateEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _toCcLabel;
		private CcDateEditor _toCcDateEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _useexcelCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcCheckBox _useexcelCcCheckBox;
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _employeeidCcComboBoxBindingSource;
		private BusinessFramework.Client.WinForms.Utils.QueryableBindingSourceLegacy _customeridCcComboBoxBindingSource;
		
		
		
    }
}


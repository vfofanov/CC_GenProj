using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.EmployeeWizard
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

			this._lastnameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._lastnameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._firstnameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._firstnameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._titleCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._titleCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._titleofcourtesyCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._titleofcourtesyCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._birthdateCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._birthdateCcDateEditor = new CcDateEditor();
			this._hiredateCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._hiredateCcDateEditor = new CcDateEditor();
			this._photoCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._photoPictureControl = new BusinessFramework.Client.WinForms.IG.Controls.PictureControl.PictureControl();
			this._notesCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._notesCcMultilineTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcMultilineTextEditor();
			this._documentscanfileidCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._documentscanfileidPictureControl = new BusinessFramework.Client.WinForms.IG.Controls.PictureControl.PictureControl();

			((System.ComponentModel.ISupportInitialize)(this._lastnameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._firstnameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._titleCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._titleofcourtesyCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._birthdateCcDateEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._hiredateCcDateEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._notesCcMultilineTextEditor)).BeginInit();

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
            this.tableLayout.Controls.Add(this._lastnameCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._lastnameCcTextEditor, 1, 0);
            this.tableLayout.Controls.Add(this._firstnameCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._firstnameCcTextEditor, 1, 1);
            this.tableLayout.Controls.Add(this._titleCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._titleCcTextEditor, 1, 2);
            this.tableLayout.Controls.Add(this._titleofcourtesyCcLabel, 0, 3);
            this.tableLayout.Controls.Add(this._titleofcourtesyCcTextEditor, 1, 3);
            this.tableLayout.Controls.Add(this._birthdateCcLabel, 0, 4);
            this.tableLayout.Controls.Add(this._birthdateCcDateEditor, 1, 4);
            this.tableLayout.Controls.Add(this._hiredateCcLabel, 0, 5);
            this.tableLayout.Controls.Add(this._hiredateCcDateEditor, 1, 5);
            this.tableLayout.Controls.Add(this._photoCcLabel, 0, 6);
            this.tableLayout.Controls.Add(this._photoPictureControl, 1, 6);
            this.tableLayout.Controls.Add(this._notesCcLabel, 0, 7);
            this.tableLayout.Controls.Add(this._notesCcMultilineTextEditor, 1, 7);
            this.tableLayout.Controls.Add(this._documentscanfileidCcLabel, 0, 8);
            this.tableLayout.Controls.Add(this._documentscanfileidPictureControl, 1, 8);

            // 
            // _lastnameCcLabel
            // 
            this._lastnameCcLabel.Text = "Last Name" + ":";
		    this._lastnameCcLabel.Name = "_lastnameCcLabel";
            this._lastnameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._lastnameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _lastnameCcTextEditor
            // 
		    this._lastnameCcTextEditor.Name = "_lastnameCcTextEditor";
            this._lastnameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._lastnameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._lastnameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "LastName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._lastnameCcTextEditor.TabIndex = 0;


            // 
            // _firstnameCcLabel
            // 
            this._firstnameCcLabel.Text = "First Name" + ":";
		    this._firstnameCcLabel.Name = "_firstnameCcLabel";
            this._firstnameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._firstnameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _firstnameCcTextEditor
            // 
		    this._firstnameCcTextEditor.Name = "_firstnameCcTextEditor";
            this._firstnameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._firstnameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._firstnameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._firstnameCcTextEditor.TabIndex = 1;


            // 
            // _titleCcLabel
            // 
            this._titleCcLabel.Text = "Title" + ":";
		    this._titleCcLabel.Name = "_titleCcLabel";
            this._titleCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._titleCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _titleCcTextEditor
            // 
		    this._titleCcTextEditor.Name = "_titleCcTextEditor";
            this._titleCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._titleCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._titleCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._titleCcTextEditor.TabIndex = 2;


            // 
            // _titleofcourtesyCcLabel
            // 
            this._titleofcourtesyCcLabel.Text = "Title Of Courtesy" + ":";
		    this._titleofcourtesyCcLabel.Name = "_titleofcourtesyCcLabel";
            this._titleofcourtesyCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._titleofcourtesyCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _titleofcourtesyCcTextEditor
            // 
		    this._titleofcourtesyCcTextEditor.Name = "_titleofcourtesyCcTextEditor";
            this._titleofcourtesyCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._titleofcourtesyCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._titleofcourtesyCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "TitleOfCourtesy", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._titleofcourtesyCcTextEditor.TabIndex = 3;


            // 
            // _birthdateCcLabel
            // 
            this._birthdateCcLabel.Text = "Birth Date" + ":";
		    this._birthdateCcLabel.Name = "_birthdateCcLabel";
            this._birthdateCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._birthdateCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _birthdateCcDateEditor
            // 
		    this._birthdateCcDateEditor.Name = "_birthdateCcDateEditor";
            this._birthdateCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._birthdateCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._birthdateCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "BirthDate", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._birthdateCcDateEditor.TabIndex = 4;
            this._birthdateCcDateEditor.MaskInput = "{date}";


            // 
            // _hiredateCcLabel
            // 
            this._hiredateCcLabel.Text = "Hire Date" + ":";
		    this._hiredateCcLabel.Name = "_hiredateCcLabel";
            this._hiredateCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._hiredateCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _hiredateCcDateEditor
            // 
		    this._hiredateCcDateEditor.Name = "_hiredateCcDateEditor";
            this._hiredateCcDateEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._hiredateCcDateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._hiredateCcDateEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "HireDate", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._hiredateCcDateEditor.TabIndex = 5;
            this._hiredateCcDateEditor.MaskInput = "{date}";


            // 
            // _photoCcLabel
            // 
            this._photoCcLabel.Text = "Photo" + ":";
		    this._photoCcLabel.Name = "_photoCcLabel";
            this._photoCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._photoCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _photoPictureControl
            // 
		    this._photoPictureControl.Name = "_photoPictureControl";
            this._photoPictureControl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._photoPictureControl.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._photoPictureControl.DataBindings.Add(new Binding("Data", this.dataObjectBindingSource, "Photo", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._photoPictureControl.TabIndex = 6;


            // 
            // _notesCcLabel
            // 
            this._notesCcLabel.Text = "Notes" + ":";
		    this._notesCcLabel.Name = "_notesCcLabel";
            this._notesCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._notesCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _notesCcMultilineTextEditor
            // 
		    this._notesCcMultilineTextEditor.Name = "_notesCcMultilineTextEditor";
            this._notesCcMultilineTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._notesCcMultilineTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._notesCcMultilineTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Notes", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._notesCcMultilineTextEditor.TabIndex = 7;
this._notesCcMultilineTextEditor.MinimumSize = new System.Drawing.Size(100, 125);


            // 
            // _documentscanfileidCcLabel
            // 
            this._documentscanfileidCcLabel.Text = "Document scan file" + ":";
		    this._documentscanfileidCcLabel.Name = "_documentscanfileidCcLabel";
            this._documentscanfileidCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._documentscanfileidCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _documentscanfileidPictureControl
            // 
		    this._documentscanfileidPictureControl.Name = "_documentscanfileidPictureControl";
            this._documentscanfileidPictureControl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._documentscanfileidPictureControl.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._documentscanfileidPictureControl.DataBindings.Add(new Binding("Data", this.dataObjectBindingSource, "DocumentScanFileId", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._documentscanfileidPictureControl.TabIndex = 8;




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._lastnameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._firstnameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._titleCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._titleofcourtesyCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._birthdateCcDateEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._hiredateCcDateEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._notesCcMultilineTextEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _lastnameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _lastnameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _firstnameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _firstnameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _titleCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _titleCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _titleofcourtesyCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _titleofcourtesyCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _birthdateCcLabel;
		private CcDateEditor _birthdateCcDateEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _hiredateCcLabel;
		private CcDateEditor _hiredateCcDateEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _photoCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.PictureControl.PictureControl _photoPictureControl;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _notesCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcMultilineTextEditor _notesCcMultilineTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _documentscanfileidCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.PictureControl.PictureControl _documentscanfileidPictureControl;
		
		
		
		
    }
}


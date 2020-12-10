using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.RegionWizard
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

			this._idCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._idCcNumericEditor = new CcNumericEditor();
			this._regiondescriptionCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._regiondescriptionCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();

			((System.ComponentModel.ISupportInitialize)(this._idCcNumericEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._regiondescriptionCcTextEditor)).BeginInit();

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
            this.tableLayout.RowCount = 3;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this._idCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._idCcNumericEditor, 1, 0);
            this.tableLayout.Controls.Add(this._regiondescriptionCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._regiondescriptionCcTextEditor, 1, 1);

            // 
            // _idCcLabel
            // 
            this._idCcLabel.Text = "Region id" + ":";
		    this._idCcLabel.Name = "_idCcLabel";
            this._idCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._idCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _idCcNumericEditor
            // 
		    this._idCcNumericEditor.Name = "_idCcNumericEditor";
            this._idCcNumericEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._idCcNumericEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._idCcNumericEditor.DataBindings.Add(new Binding("Value", this.dataObjectBindingSource, "Id", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._idCcNumericEditor.TabIndex = 0;


            // 
            // _regiondescriptionCcLabel
            // 
            this._regiondescriptionCcLabel.Text = "Region description" + ":";
		    this._regiondescriptionCcLabel.Name = "_regiondescriptionCcLabel";
            this._regiondescriptionCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._regiondescriptionCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _regiondescriptionCcTextEditor
            // 
		    this._regiondescriptionCcTextEditor.Name = "_regiondescriptionCcTextEditor";
            this._regiondescriptionCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._regiondescriptionCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._regiondescriptionCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "RegionDescription", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._regiondescriptionCcTextEditor.TabIndex = 1;




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._idCcNumericEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._regiondescriptionCcTextEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _idCcLabel;
		private CcNumericEditor _idCcNumericEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _regiondescriptionCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _regiondescriptionCcTextEditor;
		
		
    }
}


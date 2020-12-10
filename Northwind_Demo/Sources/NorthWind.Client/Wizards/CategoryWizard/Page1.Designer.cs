using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Controls;
using Infragistics.Win.UltraWinEditors;


namespace NorthWind.Client.Wizards.CategoryWizard
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

			this._categorynameCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._categorynameCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._descriptionCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._descriptionCcTextEditor = new BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor();
			this._pictureCcLabel = new BusinessFramework.Client.WinForms.IG.Controls.CcLabel();
			this._picturePictureControl = new BusinessFramework.Client.WinForms.IG.Controls.PictureControl.PictureControl();

			((System.ComponentModel.ISupportInitialize)(this._categorynameCcTextEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._descriptionCcTextEditor)).BeginInit();

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
            this.tableLayout.RowCount = 4;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this._categorynameCcLabel, 0, 0);
            this.tableLayout.Controls.Add(this._categorynameCcTextEditor, 1, 0);
            this.tableLayout.Controls.Add(this._descriptionCcLabel, 0, 1);
            this.tableLayout.Controls.Add(this._descriptionCcTextEditor, 1, 1);
            this.tableLayout.Controls.Add(this._pictureCcLabel, 0, 2);
            this.tableLayout.Controls.Add(this._picturePictureControl, 1, 2);

            // 
            // _categorynameCcLabel
            // 
            this._categorynameCcLabel.Text = "Category Name" + ":";
		    this._categorynameCcLabel.Name = "_categorynameCcLabel";
            this._categorynameCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._categorynameCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _categorynameCcTextEditor
            // 
		    this._categorynameCcTextEditor.Name = "_categorynameCcTextEditor";
            this._categorynameCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._categorynameCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._categorynameCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "CategoryName", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._categorynameCcTextEditor.TabIndex = 0;


            // 
            // _descriptionCcLabel
            // 
            this._descriptionCcLabel.Text = "Description" + ":";
		    this._descriptionCcLabel.Name = "_descriptionCcLabel";
            this._descriptionCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._descriptionCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _descriptionCcTextEditor
            // 
		    this._descriptionCcTextEditor.Name = "_descriptionCcTextEditor";
            this._descriptionCcTextEditor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._descriptionCcTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._descriptionCcTextEditor.DataBindings.Add(new Binding("Text", this.dataObjectBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._descriptionCcTextEditor.TabIndex = 1;


            // 
            // _pictureCcLabel
            // 
            this._pictureCcLabel.Text = "Picture" + ":";
		    this._pictureCcLabel.Name = "_pictureCcLabel";
            this._pictureCcLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._pictureCcLabel.Dock = System.Windows.Forms.DockStyle.None;


            // 
            // _picturePictureControl
            // 
		    this._picturePictureControl.Name = "_picturePictureControl";
            this._picturePictureControl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this._picturePictureControl.Dock = System.Windows.Forms.DockStyle.Fill;
		    this._picturePictureControl.DataBindings.Add(new Binding("Data", this.dataObjectBindingSource, "Picture", true, DataSourceUpdateMode.OnPropertyChanged));
		    this._picturePictureControl.TabIndex = 2;




            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "Page1";                    
			((System.ComponentModel.ISupportInitialize)(this._categorynameCcTextEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._descriptionCcTextEditor)).EndInit();

		    this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _categorynameCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _categorynameCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _descriptionCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.CcTextEditor _descriptionCcTextEditor;
		private BusinessFramework.Client.WinForms.IG.Controls.CcLabel _pictureCcLabel;
		private BusinessFramework.Client.WinForms.IG.Controls.PictureControl.PictureControl _picturePictureControl;
		
    }
}


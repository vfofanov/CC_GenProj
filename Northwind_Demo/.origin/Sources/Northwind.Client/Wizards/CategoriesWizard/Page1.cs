using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using BusinessFramework.Client.Contracts.Controls;
using BusinessFramework.Client.WinForms.IG.Controls;
using BusinessFramework.Client.WinForms.IG.Controls.DataGrid;
using BusinessFramework.Client.WinForms.IG.Controls.PictureControl;
using BusinessFramework.Client.WinForms.IG.Utils;
using BusinessFramework.Client.WinForms.IG.Wizard;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Wizards;
using Northwind.Contracts.Enums;


namespace Northwind.Client.Wizards.CategoriesWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            CategoryNameHolder = new PropertyControlHolder<CcTextEditor>(_categorynameCcLabel, _categorynameCcTextEditor, errorProvider, "CategoryName");
            DescriptionHolder = new PropertyControlHolder<CcTextEditor>(_descriptionCcLabel, _descriptionCcTextEditor, errorProvider, "Description");
            PictureHolder = new PropertyControlHolder<PictureControl>(_pictureCcLabel, _picturePictureControl, errorProvider, "Picture");

        }

        public PropertyControlHolder<CcTextEditor> CategoryNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> DescriptionHolder { get; private set; }
        public PropertyControlHolder<PictureControl> PictureHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 CategoryNameHolder,
                 DescriptionHolder,
                 PictureHolder,
            };
        }

        public Category CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Category)dataObjectBindingSource.DataSource; }            
        }


        public CategoriesWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (CategoriesWizardParameters)parametersBindingSource.DataSource; }            
        }

        #region Acessibility
        public void SetAcessibility_categorynameCcTextEditor(bool value)
        {
            _categorynameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_descriptionCcTextEditor(bool value)
        {
            _descriptionCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_picturePictureControl(bool value)
        {
            _picturePictureControl.SetReadOnly(!value);
        }
        #endregion
    }
}

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
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.Enums;


namespace NorthWind.Client.Wizards.SupplierWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            CompanyNameHolder = new PropertyControlHolder<CcTextEditor>(_companynameCcLabel, _companynameCcTextEditor, errorProvider, "CompanyName");
            ContactNameHolder = new PropertyControlHolder<CcTextEditor>(_contactnameCcLabel, _contactnameCcTextEditor, errorProvider, "ContactName");
            ContactTitleHolder = new PropertyControlHolder<CcTextEditor>(_contacttitleCcLabel, _contacttitleCcTextEditor, errorProvider, "ContactTitle");

        }

        public PropertyControlHolder<CcTextEditor> CompanyNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ContactNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ContactTitleHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 CompanyNameHolder,
                 ContactNameHolder,
                 ContactTitleHolder,
            };
        }

        public Suppliers CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Suppliers)dataObjectBindingSource.DataSource; }            
        }


        public SupplierWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (SupplierWizardParameters)parametersBindingSource.DataSource; }            
        }

        #region Acessibility
        public void SetAcessibility_companynameCcTextEditor(bool value)
        {
            _companynameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_contactnameCcTextEditor(bool value)
        {
            _contactnameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_contacttitleCcTextEditor(bool value)
        {
            _contacttitleCcTextEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

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


namespace NorthWind.Client.Wizards.ShipperWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            CompanyNameHolder = new PropertyControlHolder<CcTextEditor>(_companynameCcLabel, _companynameCcTextEditor, errorProvider, "CompanyName");
            PhoneHolder = new PropertyControlHolder<CcTextEditor>(_phoneCcLabel, _phoneCcTextEditor, errorProvider, "Phone");

        }

        public PropertyControlHolder<CcTextEditor> CompanyNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> PhoneHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 CompanyNameHolder,
                 PhoneHolder,
            };
        }

        public Shippers CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Shippers)dataObjectBindingSource.DataSource; }            
        }


        public ShipperWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (ShipperWizardParameters)parametersBindingSource.DataSource; }            
        }

        #region Acessibility
        public void SetAcessibility_companynameCcTextEditor(bool value)
        {
            _companynameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_phoneCcTextEditor(bool value)
        {
            _phoneCcTextEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

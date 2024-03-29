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


namespace NorthWind.Client.Wizards.RegionWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            IdHolder = new PropertyControlHolder<CcNumericEditor>(_idCcLabel, _idCcNumericEditor, errorProvider, "Id");
            RegionDescriptionHolder = new PropertyControlHolder<CcTextEditor>(_regiondescriptionCcLabel, _regiondescriptionCcTextEditor, errorProvider, "RegionDescription");

        }

        public PropertyControlHolder<CcNumericEditor> IdHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> RegionDescriptionHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 IdHolder,
                 RegionDescriptionHolder,
            };
        }

        public Region CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Region)dataObjectBindingSource.DataSource; }            
        }


        public RegionWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (RegionWizardParameters)parametersBindingSource.DataSource; }            
        }

        #region Acessibility
        public void SetAcessibility_idCcNumericEditor(bool value)
        {
            _idCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_regiondescriptionCcTextEditor(bool value)
        {
            _regiondescriptionCcTextEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

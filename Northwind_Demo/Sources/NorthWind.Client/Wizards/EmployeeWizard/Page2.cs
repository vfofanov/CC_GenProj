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


namespace NorthWind.Client.Wizards.EmployeeWizard
{
    [ToolboxItem(false)]
    public partial class Page2 : BaseWizardPage
    {
        public Page2()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            AddressHolder = new PropertyControlHolder<CcTextEditor>(_addressCcLabel, _addressCcTextEditor, errorProvider, "Address");
            CityHolder = new PropertyControlHolder<CcTextEditor>(_cityCcLabel, _cityCcTextEditor, errorProvider, "City");
            RegionHolder = new PropertyControlHolder<CcTextEditor>(_regionCcLabel, _regionCcTextEditor, errorProvider, "Region");
            PostalCodeHolder = new PropertyControlHolder<CcTextEditor>(_postalcodeCcLabel, _postalcodeCcTextEditor, errorProvider, "PostalCode");
            CountryHolder = new PropertyControlHolder<CcTextEditor>(_countryCcLabel, _countryCcTextEditor, errorProvider, "Country");
            HomePhoneHolder = new PropertyControlHolder<CcTextEditor>(_homephoneCcLabel, _homephoneCcTextEditor, errorProvider, "HomePhone");

        }

        public PropertyControlHolder<CcTextEditor> AddressHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> CityHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> RegionHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> PostalCodeHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> CountryHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> HomePhoneHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 AddressHolder,
                 CityHolder,
                 RegionHolder,
                 PostalCodeHolder,
                 CountryHolder,
                 HomePhoneHolder,
            };
        }

        public Employees CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Employees)dataObjectBindingSource.DataSource; }            
        }


        public EmployeeWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (EmployeeWizardParameters)parametersBindingSource.DataSource; }            
        }

        #region Acessibility
        public void SetAcessibility_addressCcTextEditor(bool value)
        {
            _addressCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_cityCcTextEditor(bool value)
        {
            _cityCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_regionCcTextEditor(bool value)
        {
            _regionCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_postalcodeCcTextEditor(bool value)
        {
            _postalcodeCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_countryCcTextEditor(bool value)
        {
            _countryCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_homephoneCcTextEditor(bool value)
        {
            _homephoneCcTextEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

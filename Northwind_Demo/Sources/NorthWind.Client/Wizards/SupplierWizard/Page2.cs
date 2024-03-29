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
    public partial class Page2 : BaseWizardPage
    {
        public Page2()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            AddressHolder = new PropertyControlHolder<CcTextEditor>(_addressCcLabel, _addressCcTextEditor, errorProvider, "Address");
            CityHolder = new PropertyControlHolder<CcTextEditor>(_cityCcLabel, _cityCcTextEditor, errorProvider, "City");
            CountryHolder = new PropertyControlHolder<CcTextEditor>(_countryCcLabel, _countryCcTextEditor, errorProvider, "Country");
            FaxHolder = new PropertyControlHolder<CcTextEditor>(_faxCcLabel, _faxCcTextEditor, errorProvider, "Fax");
            HomePageHolder = new PropertyControlHolder<CcTextEditor>(_homepageCcLabel, _homepageCcTextEditor, errorProvider, "HomePage");
            PhoneHolder = new PropertyControlHolder<CcTextEditor>(_phoneCcLabel, _phoneCcTextEditor, errorProvider, "Phone");
            PostalCodeHolder = new PropertyControlHolder<CcTextEditor>(_postalcodeCcLabel, _postalcodeCcTextEditor, errorProvider, "PostalCode");
            RegionHolder = new PropertyControlHolder<CcTextEditor>(_regionCcLabel, _regionCcTextEditor, errorProvider, "Region");

        }

        public PropertyControlHolder<CcTextEditor> AddressHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> CityHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> CountryHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> FaxHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> HomePageHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> PhoneHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> PostalCodeHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> RegionHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 AddressHolder,
                 CityHolder,
                 CountryHolder,
                 FaxHolder,
                 HomePageHolder,
                 PhoneHolder,
                 PostalCodeHolder,
                 RegionHolder,
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
        public void SetAcessibility_addressCcTextEditor(bool value)
        {
            _addressCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_cityCcTextEditor(bool value)
        {
            _cityCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_countryCcTextEditor(bool value)
        {
            _countryCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_faxCcTextEditor(bool value)
        {
            _faxCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_homepageCcTextEditor(bool value)
        {
            _homepageCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_phoneCcTextEditor(bool value)
        {
            _phoneCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_postalcodeCcTextEditor(bool value)
        {
            _postalcodeCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_regionCcTextEditor(bool value)
        {
            _regionCcTextEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

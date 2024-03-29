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


namespace NorthWind.Client.Wizards.OrderWizard
{
    [ToolboxItem(false)]
    public partial class Page2 : BaseWizardPage
    {
        public Page2()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            ShipViaHolder = new PropertyControlHolder<CcComboBox>(_shipviaCcLabel, _shipviaCcComboBox, errorProvider, "ShipVia");
            ShippedDateHolder = new PropertyControlHolder<CcDateEditor>(_shippeddateCcLabel, _shippeddateCcDateEditor, errorProvider, "ShippedDate");
            FreightHolder = new PropertyControlHolder<CcNumericEditor>(_freightCcLabel, _freightCcNumericEditor, errorProvider, "Freight");
            ShipNameHolder = new PropertyControlHolder<CcTextEditor>(_shipnameCcLabel, _shipnameCcTextEditor, errorProvider, "ShipName");
            ShipAddressHolder = new PropertyControlHolder<CcTextEditor>(_shipaddressCcLabel, _shipaddressCcTextEditor, errorProvider, "ShipAddress");
            ShipCityHolder = new PropertyControlHolder<CcTextEditor>(_shipcityCcLabel, _shipcityCcTextEditor, errorProvider, "ShipCity");
            ShipRegionHolder = new PropertyControlHolder<CcTextEditor>(_shipregionCcLabel, _shipregionCcTextEditor, errorProvider, "ShipRegion");
            ShipPostalCodeHolder = new PropertyControlHolder<CcTextEditor>(_shippostalcodeCcLabel, _shippostalcodeCcTextEditor, errorProvider, "ShipPostalCode");
            ShipCountryHolder = new PropertyControlHolder<CcTextEditor>(_shipcountryCcLabel, _shipcountryCcTextEditor, errorProvider, "ShipCountry");

        
            _shipviaCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<Shippers>(outs => outs.ToList());
        }

        public PropertyControlHolder<CcComboBox> ShipViaHolder { get; private set; }
        public PropertyControlHolder<CcDateEditor> ShippedDateHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> FreightHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ShipNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ShipAddressHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ShipCityHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ShipRegionHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ShipPostalCodeHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> ShipCountryHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 ShipViaHolder,
                 ShippedDateHolder,
                 FreightHolder,
                 ShipNameHolder,
                 ShipAddressHolder,
                 ShipCityHolder,
                 ShipRegionHolder,
                 ShipPostalCodeHolder,
                 ShipCountryHolder,
            };
        }

        public Orders CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Orders)dataObjectBindingSource.DataSource; }            
        }


        public OrderWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (OrderWizardParameters)parametersBindingSource.DataSource; }            
        }


        public Shippers ShipViaDataSourceComboBoxValue
        {
            get { return (Shippers)_shipviaCcComboBox.SelectedBoundObject; }
        }

        public void SetShipViaDataSource(IQueryable<Shippers> items)
        {
            _shipviaCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _shipviaCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetShipViaDataSourceNewItemAction(Action action)
        {
            _shipviaCcComboBox.SetNewItemAction(action);
        }


        #region Acessibility
        public void SetAcessibility_shipviaCcComboBox(bool value)
        {
            _shipviaCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_shippeddateCcDateEditor(bool value)
        {
            _shippeddateCcDateEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_freightCcNumericEditor(bool value)
        {
            _freightCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_shipnameCcTextEditor(bool value)
        {
            _shipnameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_shipaddressCcTextEditor(bool value)
        {
            _shipaddressCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_shipcityCcTextEditor(bool value)
        {
            _shipcityCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_shipregionCcTextEditor(bool value)
        {
            _shipregionCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_shippostalcodeCcTextEditor(bool value)
        {
            _shippostalcodeCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_shipcountryCcTextEditor(bool value)
        {
            _shipcountryCcTextEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

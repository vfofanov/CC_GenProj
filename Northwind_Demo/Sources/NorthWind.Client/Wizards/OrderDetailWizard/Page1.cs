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


namespace NorthWind.Client.Wizards.OrderDetailWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            ProductIDHolder = new PropertyControlHolder<CcComboBox>(_productidCcLabel, _productidCcComboBox, errorProvider, "ProductID");
            UnitPriceHolder = new PropertyControlHolder<CcCurrencyEditor>(_unitpriceCcLabel, _unitpriceCcCurrencyEditor, errorProvider, "UnitPrice");
            QuantityHolder = new PropertyControlHolder<CcNumericEditor>(_quantityCcLabel, _quantityCcNumericEditor, errorProvider, "Quantity");
            DiscountHolder = new PropertyControlHolder<CcNumericEditor>(_discountCcLabel, _discountCcNumericEditor, errorProvider, "Discount");

        
            _productidCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<ProductQuery>(outs => 
                { 
                    if (!string.IsNullOrWhiteSpace(args.FilterText)) 
                    {
                        return outs.Where(t => t.ProductName.Contains(args.FilterText)).ToList();
                    }
                    if (CurrentObject == null)
                    {
                        return new ProductQuery[0];
                    }  
                    return outs.Where(o => o.Id == CurrentObject.ProductID).ToList();    
                });
        }

        public PropertyControlHolder<CcComboBox> ProductIDHolder { get; private set; }
        public PropertyControlHolder<CcCurrencyEditor> UnitPriceHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> QuantityHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> DiscountHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 ProductIDHolder,
                 UnitPriceHolder,
                 QuantityHolder,
                 DiscountHolder,
            };
        }

        public OrderDetails CurrentObject
        {
            [DebuggerStepThrough]
            get { return (OrderDetails)dataObjectBindingSource.DataSource; }            
        }


        public OrderDetailWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (OrderDetailWizardParameters)parametersBindingSource.DataSource; }            
        }


        public void UpdateDataSourceProductIDDataSource(object o, CcComboBox.NeedUpdateDataSource needUpdateDataSource)
        {
            _productidCcComboBoxBindingSource.RefreshSource(needUpdateDataSource.TextToSearch);
        }

        public ProductQuery ProductIDDataSourceComboBoxValue
        {
            get { return (ProductQuery)_productidCcComboBox.SelectedBoundObject; }
        }

        public void SetProductIDDataSource(IQueryable<ProductQuery> items)
        {
            _productidCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _productidCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetProductIDDataSourceNewItemAction(Action action)
        {
            _productidCcComboBox.SetNewItemAction(action);
        }


        #region Acessibility
        public void SetAcessibility_productidCcComboBox(bool value)
        {
            _productidCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_unitpriceCcCurrencyEditor(bool value)
        {
            _unitpriceCcCurrencyEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_quantityCcNumericEditor(bool value)
        {
            _quantityCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_discountCcNumericEditor(bool value)
        {
            _discountCcNumericEditor.SetReadOnly(!value);
        }
        #endregion
    }
}

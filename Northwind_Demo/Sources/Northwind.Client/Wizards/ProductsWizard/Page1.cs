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


namespace Northwind.Client.Wizards.ProductsWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            ProductNameHolder = new PropertyControlHolder<CcTextEditor>(_productnameCcLabel, _productnameCcTextEditor, errorProvider, "ProductName");
            CategoryIDHolder = new PropertyControlHolder<CcComboBox>(_categoryidCcLabel, _categoryidCcComboBox, errorProvider, "CategoryID");
            QuantityPerUnitHolder = new PropertyControlHolder<CcTextEditor>(_quantityperunitCcLabel, _quantityperunitCcTextEditor, errorProvider, "QuantityPerUnit");
            UnitPriceHolder = new PropertyControlHolder<CcNumericEditor>(_unitpriceCcLabel, _unitpriceCcNumericEditor, errorProvider, "UnitPrice");
            UnitsInStockHolder = new PropertyControlHolder<CcNumericEditor>(_unitsinstockCcLabel, _unitsinstockCcNumericEditor, errorProvider, "UnitsInStock");
            UnitsOnOrderHolder = new PropertyControlHolder<CcNumericEditor>(_unitsonorderCcLabel, _unitsonorderCcNumericEditor, errorProvider, "UnitsOnOrder");
            ReorderLevelHolder = new PropertyControlHolder<CcNumericEditor>(_reorderlevelCcLabel, _reorderlevelCcNumericEditor, errorProvider, "ReorderLevel");
            DiscontinuedHolder = new PropertyControlHolder<CcCheckBox>(_discontinuedCcLabel, _discontinuedCcCheckBox, errorProvider, "Discontinued");
            SupplierIDHolder = new PropertyControlHolder<CcComboBox>(_supplieridCcLabel, _supplieridCcComboBox, errorProvider, "SupplierID");

        
            _categoryidCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<Category>(outs => outs.ToList());
        
            _supplieridCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<Supplier>(outs => outs.ToList());
        }

        public PropertyControlHolder<CcTextEditor> ProductNameHolder { get; private set; }
        public PropertyControlHolder<CcComboBox> CategoryIDHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> QuantityPerUnitHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> UnitPriceHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> UnitsInStockHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> UnitsOnOrderHolder { get; private set; }
        public PropertyControlHolder<CcNumericEditor> ReorderLevelHolder { get; private set; }
        public PropertyControlHolder<CcCheckBox> DiscontinuedHolder { get; private set; }
        public PropertyControlHolder<CcComboBox> SupplierIDHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 ProductNameHolder,
                 CategoryIDHolder,
                 QuantityPerUnitHolder,
                 UnitPriceHolder,
                 UnitsInStockHolder,
                 UnitsOnOrderHolder,
                 ReorderLevelHolder,
                 DiscontinuedHolder,
                 SupplierIDHolder,
            };
        }

        public Product CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Product)dataObjectBindingSource.DataSource; }            
        }


        public ProductsWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (ProductsWizardParameters)parametersBindingSource.DataSource; }            
        }


        public Category CategoryIDDataSourceComboBoxValue
        {
            get { return (Category)_categoryidCcComboBox.SelectedBoundObject; }
        }

        public void SetCategoryIDDataSource(IQueryable<Category> items)
        {
            _categoryidCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _categoryidCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetCategoryIDDataSourceNewItemAction(Action action)
        {
            _categoryidCcComboBox.SetNewItemAction(action);
        }



        public Supplier SupplierIDDataSourceComboBoxValue
        {
            get { return (Supplier)_supplieridCcComboBox.SelectedBoundObject; }
        }

        public void SetSupplierIDDataSource(IQueryable<Supplier> items)
        {
            _supplieridCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _supplieridCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetSupplierIDDataSourceNewItemAction(Action action)
        {
            _supplieridCcComboBox.SetNewItemAction(action);
        }


        #region Acessibility
        public void SetAcessibility_productnameCcTextEditor(bool value)
        {
            _productnameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_categoryidCcComboBox(bool value)
        {
            _categoryidCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_quantityperunitCcTextEditor(bool value)
        {
            _quantityperunitCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_unitpriceCcNumericEditor(bool value)
        {
            _unitpriceCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_unitsinstockCcNumericEditor(bool value)
        {
            _unitsinstockCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_unitsonorderCcNumericEditor(bool value)
        {
            _unitsonorderCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_reorderlevelCcNumericEditor(bool value)
        {
            _reorderlevelCcNumericEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_discontinuedCcCheckBox(bool value)
        {
            _discontinuedCcCheckBox.SetReadOnly(!value);
        }
        public void SetAcessibility_supplieridCcComboBox(bool value)
        {
            _supplieridCcComboBox.SetReadOnly(!value);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.WinForms.IG.Wizard;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Client.Wizards.ProductsWizard
{
    internal abstract class CodeBehindProductsWizardPresenter : BaseWizardPresenter<Product, int, ProductsWizard>
    {

        protected override void OnObjectChanged()
        {
            RefreshCategoryIDDataSourceOnPage1();
            RefreshSupplierIDDataSourceOnPage1();
			
        }

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "ProductName":
                Wizard.Page1.ProductNameHolder.Error = GetPage1_ProductNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "CategoryID":
                Wizard.Page1.CategoryIDHolder.Error = GetPage1_CategoryIDValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "QuantityPerUnit":
                Wizard.Page1.QuantityPerUnitHolder.Error = GetPage1_QuantityPerUnitValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "UnitPrice":
                Wizard.Page1.UnitPriceHolder.Error = GetPage1_UnitPriceValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "UnitsInStock":
                Wizard.Page1.UnitsInStockHolder.Error = GetPage1_UnitsInStockValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "UnitsOnOrder":
                Wizard.Page1.UnitsOnOrderHolder.Error = GetPage1_UnitsOnOrderValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "ReorderLevel":
                Wizard.Page1.ReorderLevelHolder.Error = GetPage1_ReorderLevelValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Discontinued":
                Wizard.Page1.DiscontinuedHolder.Error = GetPage1_DiscontinuedValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "SupplierID":
                Wizard.Page1.SupplierIDHolder.Error = GetPage1_SupplierIDValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            }
            Wizard.Page1.ResumeLayout(true);

        }

        protected override void OnWizardParameterChanged(PropertyChangedEventArgs e)
        {

        }


        protected void RefreshCategoryIDDataSourceOnPage1()
        {
            Wizard.Page1.SetCategoryIDDataSource(GetCategoryIDDataSourceOnPage1());
        }
        protected virtual IQueryable<Category> GetCategoryIDDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<Category,int>().GetAllObjects();
        }

        protected void RefreshSupplierIDDataSourceOnPage1()
        {
            Wizard.Page1.SetSupplierIDDataSource(GetSupplierIDDataSourceOnPage1());
        }
        protected virtual IQueryable<Supplier> GetSupplierIDDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<Supplier,int>().GetAllObjects();
        }
	
        protected sealed override void RefreshVisibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.ProductNameHolder.Visible = GetPage1_ProductNameVisibility();
            Wizard.Page1.CategoryIDHolder.Visible = GetPage1_CategoryIDVisibility();
            Wizard.Page1.QuantityPerUnitHolder.Visible = GetPage1_QuantityPerUnitVisibility();
            Wizard.Page1.UnitPriceHolder.Visible = GetPage1_UnitPriceVisibility();
            Wizard.Page1.UnitsInStockHolder.Visible = GetPage1_UnitsInStockVisibility();
            Wizard.Page1.UnitsOnOrderHolder.Visible = GetPage1_UnitsOnOrderVisibility();
            Wizard.Page1.ReorderLevelHolder.Visible = GetPage1_ReorderLevelVisibility();
            Wizard.Page1.DiscontinuedHolder.Visible = GetPage1_DiscontinuedVisibility();
            Wizard.Page1.SupplierIDHolder.Visible = GetPage1_SupplierIDVisibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.ProductNameHolder.ReadOnly = !GetPage1_ProductNameAcessibility();
            Wizard.Page1.CategoryIDHolder.ReadOnly = !GetPage1_CategoryIDAcessibility();
            Wizard.Page1.QuantityPerUnitHolder.ReadOnly = !GetPage1_QuantityPerUnitAcessibility();
            Wizard.Page1.UnitPriceHolder.ReadOnly = !GetPage1_UnitPriceAcessibility();
            Wizard.Page1.UnitsInStockHolder.ReadOnly = !GetPage1_UnitsInStockAcessibility();
            Wizard.Page1.UnitsOnOrderHolder.ReadOnly = !GetPage1_UnitsOnOrderAcessibility();
            Wizard.Page1.ReorderLevelHolder.ReadOnly = !GetPage1_ReorderLevelAcessibility();
            Wizard.Page1.DiscontinuedHolder.ReadOnly = !GetPage1_DiscontinuedAcessibility();
            Wizard.Page1.SupplierIDHolder.ReadOnly = !GetPage1_SupplierIDAcessibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.ProductNameHolder.RequiredStyle = GetPage1_ProductNameRequiredStyle();
            Wizard.Page1.CategoryIDHolder.RequiredStyle = GetPage1_CategoryIDRequiredStyle();
            Wizard.Page1.QuantityPerUnitHolder.RequiredStyle = GetPage1_QuantityPerUnitRequiredStyle();
            Wizard.Page1.UnitPriceHolder.RequiredStyle = GetPage1_UnitPriceRequiredStyle();
            Wizard.Page1.UnitsInStockHolder.RequiredStyle = GetPage1_UnitsInStockRequiredStyle();
            Wizard.Page1.UnitsOnOrderHolder.RequiredStyle = GetPage1_UnitsOnOrderRequiredStyle();
            Wizard.Page1.ReorderLevelHolder.RequiredStyle = GetPage1_ReorderLevelRequiredStyle();
            Wizard.Page1.DiscontinuedHolder.RequiredStyle = GetPage1_DiscontinuedRequiredStyle();
            Wizard.Page1.SupplierIDHolder.RequiredStyle = GetPage1_SupplierIDRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.ProductNameHolder.Error = GetPage1_ProductNameValidate();
                Wizard.Page1.CategoryIDHolder.Error = GetPage1_CategoryIDValidate();
                Wizard.Page1.QuantityPerUnitHolder.Error = GetPage1_QuantityPerUnitValidate();
                Wizard.Page1.UnitPriceHolder.Error = GetPage1_UnitPriceValidate();
                Wizard.Page1.UnitsInStockHolder.Error = GetPage1_UnitsInStockValidate();
                Wizard.Page1.UnitsOnOrderHolder.Error = GetPage1_UnitsOnOrderValidate();
                Wizard.Page1.ReorderLevelHolder.Error = GetPage1_ReorderLevelValidate();
                Wizard.Page1.DiscontinuedHolder.Error = GetPage1_DiscontinuedValidate();
                Wizard.Page1.SupplierIDHolder.Error = GetPage1_SupplierIDValidate();
                Wizard.Page1.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_ProductNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("ProductName");
        }

        protected virtual bool GetPage1_ProductNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_ProductNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ProductName");
        }

        protected virtual string GetPage1_ProductNameValidate()
        {
            return CurrentObject.GetPropertyValidation("ProductName");
        }
        protected virtual bool GetPage1_CategoryIDVisibility()
        {
            return CurrentObject.IsPropertyVisible("CategoryID");
        }

        protected virtual bool GetPage1_CategoryIDAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_CategoryIDRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("CategoryID");
        }

        protected virtual string GetPage1_CategoryIDValidate()
        {
            return CurrentObject.GetPropertyValidation("CategoryID");
        }
        protected virtual bool GetPage1_QuantityPerUnitVisibility()
        {
            return CurrentObject.IsPropertyVisible("QuantityPerUnit");
        }

        protected virtual bool GetPage1_QuantityPerUnitAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_QuantityPerUnitRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("QuantityPerUnit");
        }

        protected virtual string GetPage1_QuantityPerUnitValidate()
        {
            return CurrentObject.GetPropertyValidation("QuantityPerUnit");
        }
        protected virtual bool GetPage1_UnitPriceVisibility()
        {
            return CurrentObject.IsPropertyVisible("UnitPrice");
        }

        protected virtual bool GetPage1_UnitPriceAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_UnitPriceRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("UnitPrice");
        }

        protected virtual string GetPage1_UnitPriceValidate()
        {
            return CurrentObject.GetPropertyValidation("UnitPrice");
        }
        protected virtual bool GetPage1_UnitsInStockVisibility()
        {
            return CurrentObject.IsPropertyVisible("UnitsInStock");
        }

        protected virtual bool GetPage1_UnitsInStockAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_UnitsInStockRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("UnitsInStock");
        }

        protected virtual string GetPage1_UnitsInStockValidate()
        {
            return CurrentObject.GetPropertyValidation("UnitsInStock");
        }
        protected virtual bool GetPage1_UnitsOnOrderVisibility()
        {
            return CurrentObject.IsPropertyVisible("UnitsOnOrder");
        }

        protected virtual bool GetPage1_UnitsOnOrderAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_UnitsOnOrderRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("UnitsOnOrder");
        }

        protected virtual string GetPage1_UnitsOnOrderValidate()
        {
            return CurrentObject.GetPropertyValidation("UnitsOnOrder");
        }
        protected virtual bool GetPage1_ReorderLevelVisibility()
        {
            return CurrentObject.IsPropertyVisible("ReorderLevel");
        }

        protected virtual bool GetPage1_ReorderLevelAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_ReorderLevelRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ReorderLevel");
        }

        protected virtual string GetPage1_ReorderLevelValidate()
        {
            return CurrentObject.GetPropertyValidation("ReorderLevel");
        }
        protected virtual bool GetPage1_DiscontinuedVisibility()
        {
            return CurrentObject.IsPropertyVisible("Discontinued");
        }

        protected virtual bool GetPage1_DiscontinuedAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_DiscontinuedRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Discontinued");
        }

        protected virtual string GetPage1_DiscontinuedValidate()
        {
            return CurrentObject.GetPropertyValidation("Discontinued");
        }
        protected virtual bool GetPage1_SupplierIDVisibility()
        {
            return CurrentObject.IsPropertyVisible("SupplierID");
        }

        protected virtual bool GetPage1_SupplierIDAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_SupplierIDRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("SupplierID");
        }

        protected virtual string GetPage1_SupplierIDValidate()
        {
            return CurrentObject.GetPropertyValidation("SupplierID");
        }
    }
}
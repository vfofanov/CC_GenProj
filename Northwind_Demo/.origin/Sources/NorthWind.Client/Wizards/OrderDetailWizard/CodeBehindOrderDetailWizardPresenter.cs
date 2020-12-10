using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.WinForms.IG.Wizard;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Client.Wizards.OrderDetailWizard
{
    internal abstract class CodeBehindOrderDetailWizardPresenter : BaseWizardPresenter<OrderDetails, OrderDetailsKey, OrderDetailWizard>
    {

        protected override void OnObjectChanged()
        {
            RefreshProductIDDataSourceOnPage1();
			
        }

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "ProductID":
                Wizard.Page1.ProductIDHolder.Error = GetPage1_ProductIDValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "UnitPrice":
                Wizard.Page1.UnitPriceHolder.Error = GetPage1_UnitPriceValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Quantity":
                Wizard.Page1.QuantityHolder.Error = GetPage1_QuantityValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Discount":
                Wizard.Page1.DiscountHolder.Error = GetPage1_DiscountValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            }
            Wizard.Page1.ResumeLayout(true);

        }

        protected override void OnWizardParameterChanged(PropertyChangedEventArgs e)
        {

        }


        protected void RefreshProductIDDataSourceOnPage1()
        {
            Wizard.Page1.SetProductIDDataSource(GetProductIDDataSourceOnPage1());
        }
        protected virtual IQueryable<ProductQuery> GetProductIDDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<ProductQuery,int>().GetAllObjects();
        }
	
        protected sealed override void RefreshVisibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.ProductIDHolder.Visible = GetPage1_ProductIDVisibility();
            Wizard.Page1.UnitPriceHolder.Visible = GetPage1_UnitPriceVisibility();
            Wizard.Page1.QuantityHolder.Visible = GetPage1_QuantityVisibility();
            Wizard.Page1.DiscountHolder.Visible = GetPage1_DiscountVisibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.ProductIDHolder.ReadOnly = !GetPage1_ProductIDAcessibility();
            Wizard.Page1.UnitPriceHolder.ReadOnly = !GetPage1_UnitPriceAcessibility();
            Wizard.Page1.QuantityHolder.ReadOnly = !GetPage1_QuantityAcessibility();
            Wizard.Page1.DiscountHolder.ReadOnly = !GetPage1_DiscountAcessibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.ProductIDHolder.RequiredStyle = GetPage1_ProductIDRequiredStyle();
            Wizard.Page1.UnitPriceHolder.RequiredStyle = GetPage1_UnitPriceRequiredStyle();
            Wizard.Page1.QuantityHolder.RequiredStyle = GetPage1_QuantityRequiredStyle();
            Wizard.Page1.DiscountHolder.RequiredStyle = GetPage1_DiscountRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.ProductIDHolder.Error = GetPage1_ProductIDValidate();
                Wizard.Page1.UnitPriceHolder.Error = GetPage1_UnitPriceValidate();
                Wizard.Page1.QuantityHolder.Error = GetPage1_QuantityValidate();
                Wizard.Page1.DiscountHolder.Error = GetPage1_DiscountValidate();
                Wizard.Page1.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_ProductIDVisibility()
        {
            return CurrentObject.IsPropertyVisible("ProductID");
        }

        protected virtual bool GetPage1_ProductIDAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_ProductIDRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ProductID");
        }

        protected virtual string GetPage1_ProductIDValidate()
        {
            return CurrentObject.GetPropertyValidation("ProductID");
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
        protected virtual bool GetPage1_QuantityVisibility()
        {
            return CurrentObject.IsPropertyVisible("Quantity");
        }

        protected virtual bool GetPage1_QuantityAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_QuantityRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Quantity");
        }

        protected virtual string GetPage1_QuantityValidate()
        {
            return CurrentObject.GetPropertyValidation("Quantity");
        }
        protected virtual bool GetPage1_DiscountVisibility()
        {
            return CurrentObject.IsPropertyVisible("Discount");
        }

        protected virtual bool GetPage1_DiscountAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_DiscountRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Discount");
        }

        protected virtual string GetPage1_DiscountValidate()
        {
            return CurrentObject.GetPropertyValidation("Discount");
        }
    }
}
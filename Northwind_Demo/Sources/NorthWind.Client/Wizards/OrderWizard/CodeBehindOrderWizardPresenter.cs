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


namespace NorthWind.Client.Wizards.OrderWizard
{
    internal abstract class CodeBehindOrderWizardPresenter : BaseWizardPresenter<Orders, int, OrderWizard>
    {

        protected override void OnObjectChanged()
        {
            RefreshCustomerIDDataSourceOnPage1();
            RefreshEmployeeIDDataSourceOnPage1();
            RefreshShipViaDataSourceOnPage2();
			
        }

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "OrderDate":
                Wizard.Page1.OrderDateHolder.Error = GetPage1_OrderDateValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "CustomerID":
                Wizard.Page1.CustomerIDHolder.Error = GetPage1_CustomerIDValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "EmployeeID":
                Wizard.Page1.EmployeeIDHolder.Error = GetPage1_EmployeeIDValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "RequiredDate":
                Wizard.Page1.RequiredDateHolder.Error = GetPage1_RequiredDateValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            }
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            switch(e.PropertyName)
            {
            case "ShipVia":
                Wizard.Page2.ShipViaHolder.Error = GetPage2_ShipViaValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShippedDate":
                Wizard.Page2.ShippedDateHolder.Error = GetPage2_ShippedDateValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "Freight":
                Wizard.Page2.FreightHolder.Error = GetPage2_FreightValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShipName":
                Wizard.Page2.ShipNameHolder.Error = GetPage2_ShipNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShipAddress":
                Wizard.Page2.ShipAddressHolder.Error = GetPage2_ShipAddressValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShipCity":
                Wizard.Page2.ShipCityHolder.Error = GetPage2_ShipCityValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShipRegion":
                Wizard.Page2.ShipRegionHolder.Error = GetPage2_ShipRegionValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShipPostalCode":
                Wizard.Page2.ShipPostalCodeHolder.Error = GetPage2_ShipPostalCodeValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "ShipCountry":
                Wizard.Page2.ShipCountryHolder.Error = GetPage2_ShipCountryValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            }
            Wizard.Page2.ResumeLayout(true);

        }

        protected override void OnWizardParameterChanged(PropertyChangedEventArgs e)
        {

        }


        protected void RefreshCustomerIDDataSourceOnPage1()
        {
            Wizard.Page1.SetCustomerIDDataSource(GetCustomerIDDataSourceOnPage1());
        }
        protected virtual IQueryable<CustomerQuery> GetCustomerIDDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<CustomerQuery,int>().GetAllObjects();
        }

        protected void RefreshEmployeeIDDataSourceOnPage1()
        {
            Wizard.Page1.SetEmployeeIDDataSource(GetEmployeeIDDataSourceOnPage1());
        }
        protected virtual IQueryable<EmployeeQuery> GetEmployeeIDDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<EmployeeQuery,int>().GetAllObjects();
        }

        protected void RefreshShipViaDataSourceOnPage2()
        {
            Wizard.Page2.SetShipViaDataSource(GetShipViaDataSourceOnPage2());
        }
        protected virtual IQueryable<Shippers> GetShipViaDataSourceOnPage2()
        {
            return SessionGlobalServices.GetManager<Shippers,int>().GetAllObjects().OrderBy(o => o.CompanyName);
        }
	
        protected sealed override void RefreshVisibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.OrderDateHolder.Visible = GetPage1_OrderDateVisibility();
            Wizard.Page1.CustomerIDHolder.Visible = GetPage1_CustomerIDVisibility();
            Wizard.Page1.EmployeeIDHolder.Visible = GetPage1_EmployeeIDVisibility();
            Wizard.Page1.RequiredDateHolder.Visible = GetPage1_RequiredDateVisibility();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.ShipViaHolder.Visible = GetPage2_ShipViaVisibility();
            Wizard.Page2.ShippedDateHolder.Visible = GetPage2_ShippedDateVisibility();
            Wizard.Page2.FreightHolder.Visible = GetPage2_FreightVisibility();
            Wizard.Page2.ShipNameHolder.Visible = GetPage2_ShipNameVisibility();
            Wizard.Page2.ShipAddressHolder.Visible = GetPage2_ShipAddressVisibility();
            Wizard.Page2.ShipCityHolder.Visible = GetPage2_ShipCityVisibility();
            Wizard.Page2.ShipRegionHolder.Visible = GetPage2_ShipRegionVisibility();
            Wizard.Page2.ShipPostalCodeHolder.Visible = GetPage2_ShipPostalCodeVisibility();
            Wizard.Page2.ShipCountryHolder.Visible = GetPage2_ShipCountryVisibility();
            Wizard.Page2.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.OrderDateHolder.ReadOnly = !GetPage1_OrderDateAcessibility();
            Wizard.Page1.CustomerIDHolder.ReadOnly = !GetPage1_CustomerIDAcessibility();
            Wizard.Page1.EmployeeIDHolder.ReadOnly = !GetPage1_EmployeeIDAcessibility();
            Wizard.Page1.RequiredDateHolder.ReadOnly = !GetPage1_RequiredDateAcessibility();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.ShipViaHolder.ReadOnly = !GetPage2_ShipViaAcessibility();
            Wizard.Page2.ShippedDateHolder.ReadOnly = !GetPage2_ShippedDateAcessibility();
            Wizard.Page2.FreightHolder.ReadOnly = !GetPage2_FreightAcessibility();
            Wizard.Page2.ShipNameHolder.ReadOnly = !GetPage2_ShipNameAcessibility();
            Wizard.Page2.ShipAddressHolder.ReadOnly = !GetPage2_ShipAddressAcessibility();
            Wizard.Page2.ShipCityHolder.ReadOnly = !GetPage2_ShipCityAcessibility();
            Wizard.Page2.ShipRegionHolder.ReadOnly = !GetPage2_ShipRegionAcessibility();
            Wizard.Page2.ShipPostalCodeHolder.ReadOnly = !GetPage2_ShipPostalCodeAcessibility();
            Wizard.Page2.ShipCountryHolder.ReadOnly = !GetPage2_ShipCountryAcessibility();
            Wizard.Page2.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.OrderDateHolder.RequiredStyle = GetPage1_OrderDateRequiredStyle();
            Wizard.Page1.CustomerIDHolder.RequiredStyle = GetPage1_CustomerIDRequiredStyle();
            Wizard.Page1.EmployeeIDHolder.RequiredStyle = GetPage1_EmployeeIDRequiredStyle();
            Wizard.Page1.RequiredDateHolder.RequiredStyle = GetPage1_RequiredDateRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.ShipViaHolder.RequiredStyle = GetPage2_ShipViaRequiredStyle();
            Wizard.Page2.ShippedDateHolder.RequiredStyle = GetPage2_ShippedDateRequiredStyle();
            Wizard.Page2.FreightHolder.RequiredStyle = GetPage2_FreightRequiredStyle();
            Wizard.Page2.ShipNameHolder.RequiredStyle = GetPage2_ShipNameRequiredStyle();
            Wizard.Page2.ShipAddressHolder.RequiredStyle = GetPage2_ShipAddressRequiredStyle();
            Wizard.Page2.ShipCityHolder.RequiredStyle = GetPage2_ShipCityRequiredStyle();
            Wizard.Page2.ShipRegionHolder.RequiredStyle = GetPage2_ShipRegionRequiredStyle();
            Wizard.Page2.ShipPostalCodeHolder.RequiredStyle = GetPage2_ShipPostalCodeRequiredStyle();
            Wizard.Page2.ShipCountryHolder.RequiredStyle = GetPage2_ShipCountryRequiredStyle();
            Wizard.Page2.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.OrderDateHolder.Error = GetPage1_OrderDateValidate();
                Wizard.Page1.CustomerIDHolder.Error = GetPage1_CustomerIDValidate();
                Wizard.Page1.EmployeeIDHolder.Error = GetPage1_EmployeeIDValidate();
                Wizard.Page1.RequiredDateHolder.Error = GetPage1_RequiredDateValidate();
                Wizard.Page1.ResumeLayout(true);
            }
            if (page == null || ReferenceEquals(Wizard.Page2, page))
            {
                Wizard.Page2.SuspendLayout();
                Wizard.Page2.ShipViaHolder.Error = GetPage2_ShipViaValidate();
                Wizard.Page2.ShippedDateHolder.Error = GetPage2_ShippedDateValidate();
                Wizard.Page2.FreightHolder.Error = GetPage2_FreightValidate();
                Wizard.Page2.ShipNameHolder.Error = GetPage2_ShipNameValidate();
                Wizard.Page2.ShipAddressHolder.Error = GetPage2_ShipAddressValidate();
                Wizard.Page2.ShipCityHolder.Error = GetPage2_ShipCityValidate();
                Wizard.Page2.ShipRegionHolder.Error = GetPage2_ShipRegionValidate();
                Wizard.Page2.ShipPostalCodeHolder.Error = GetPage2_ShipPostalCodeValidate();
                Wizard.Page2.ShipCountryHolder.Error = GetPage2_ShipCountryValidate();
                Wizard.Page2.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_OrderDateVisibility()
        {
            return CurrentObject.IsPropertyVisible("OrderDate");
        }

        protected virtual bool GetPage1_OrderDateAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_OrderDateRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("OrderDate");
        }

        protected virtual string GetPage1_OrderDateValidate()
        {
            return CurrentObject.GetPropertyValidation("OrderDate");
        }
        protected virtual bool GetPage1_CustomerIDVisibility()
        {
            return CurrentObject.IsPropertyVisible("CustomerID");
        }

        protected virtual bool GetPage1_CustomerIDAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_CustomerIDRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("CustomerID");
        }

        protected virtual string GetPage1_CustomerIDValidate()
        {
            return CurrentObject.GetPropertyValidation("CustomerID");
        }
        protected virtual bool GetPage1_EmployeeIDVisibility()
        {
            return CurrentObject.IsPropertyVisible("EmployeeID");
        }

        protected virtual bool GetPage1_EmployeeIDAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_EmployeeIDRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("EmployeeID");
        }

        protected virtual string GetPage1_EmployeeIDValidate()
        {
            return CurrentObject.GetPropertyValidation("EmployeeID");
        }
        protected virtual bool GetPage1_RequiredDateVisibility()
        {
            return CurrentObject.IsPropertyVisible("RequiredDate");
        }

        protected virtual bool GetPage1_RequiredDateAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_RequiredDateRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("RequiredDate");
        }

        protected virtual string GetPage1_RequiredDateValidate()
        {
            return CurrentObject.GetPropertyValidation("RequiredDate");
        }
        protected virtual bool GetPage2_ShipViaVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipVia");
        }

        protected virtual bool GetPage2_ShipViaAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipViaRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipVia");
        }

        protected virtual string GetPage2_ShipViaValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipVia");
        }
        protected virtual bool GetPage2_ShippedDateVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShippedDate");
        }

        protected virtual bool GetPage2_ShippedDateAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShippedDateRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShippedDate");
        }

        protected virtual string GetPage2_ShippedDateValidate()
        {
            return CurrentObject.GetPropertyValidation("ShippedDate");
        }
        protected virtual bool GetPage2_FreightVisibility()
        {
            return CurrentObject.IsPropertyVisible("Freight");
        }

        protected virtual bool GetPage2_FreightAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_FreightRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Freight");
        }

        protected virtual string GetPage2_FreightValidate()
        {
            return CurrentObject.GetPropertyValidation("Freight");
        }
        protected virtual bool GetPage2_ShipNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipName");
        }

        protected virtual bool GetPage2_ShipNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipName");
        }

        protected virtual string GetPage2_ShipNameValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipName");
        }
        protected virtual bool GetPage2_ShipAddressVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipAddress");
        }

        protected virtual bool GetPage2_ShipAddressAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipAddressRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipAddress");
        }

        protected virtual string GetPage2_ShipAddressValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipAddress");
        }
        protected virtual bool GetPage2_ShipCityVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipCity");
        }

        protected virtual bool GetPage2_ShipCityAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipCityRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipCity");
        }

        protected virtual string GetPage2_ShipCityValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipCity");
        }
        protected virtual bool GetPage2_ShipRegionVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipRegion");
        }

        protected virtual bool GetPage2_ShipRegionAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipRegionRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipRegion");
        }

        protected virtual string GetPage2_ShipRegionValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipRegion");
        }
        protected virtual bool GetPage2_ShipPostalCodeVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipPostalCode");
        }

        protected virtual bool GetPage2_ShipPostalCodeAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipPostalCodeRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipPostalCode");
        }

        protected virtual string GetPage2_ShipPostalCodeValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipPostalCode");
        }
        protected virtual bool GetPage2_ShipCountryVisibility()
        {
            return CurrentObject.IsPropertyVisible("ShipCountry");
        }

        protected virtual bool GetPage2_ShipCountryAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_ShipCountryRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ShipCountry");
        }

        protected virtual string GetPage2_ShipCountryValidate()
        {
            return CurrentObject.GetPropertyValidation("ShipCountry");
        }
    }
}
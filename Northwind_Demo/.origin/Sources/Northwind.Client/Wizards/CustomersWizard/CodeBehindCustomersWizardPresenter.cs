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


namespace Northwind.Client.Wizards.CustomersWizard
{
    internal abstract class CodeBehindCustomersWizardPresenter : BaseWizardPresenter<Customer, int, CustomersWizard>
    {

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "CompanyName":
                Wizard.Page1.CompanyNameHolder.Error = GetPage1_CompanyNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "ContactName":
                Wizard.Page1.ContactNameHolder.Error = GetPage1_ContactNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "ContactTitle":
                Wizard.Page1.ContactTitleHolder.Error = GetPage1_ContactTitleValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Phone":
                Wizard.Page1.PhoneHolder.Error = GetPage1_PhoneValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Fax":
                Wizard.Page1.FaxHolder.Error = GetPage1_FaxValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            }
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            switch(e.PropertyName)
            {
            case "Address":
                Wizard.Page2.AddressHolder.Error = GetPage2_AddressValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "City":
                Wizard.Page2.CityHolder.Error = GetPage2_CityValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "Region":
                Wizard.Page2.RegionHolder.Error = GetPage2_RegionValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "PostalCode":
                Wizard.Page2.PostalCodeHolder.Error = GetPage2_PostalCodeValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            case "Country":
                Wizard.Page2.CountryHolder.Error = GetPage2_CountryValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page2);
                break;
            }
            Wizard.Page2.ResumeLayout(true);

        }

        protected override void OnWizardParameterChanged(PropertyChangedEventArgs e)
        {

        }

	
        protected sealed override void RefreshVisibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CompanyNameHolder.Visible = GetPage1_CompanyNameVisibility();
            Wizard.Page1.ContactNameHolder.Visible = GetPage1_ContactNameVisibility();
            Wizard.Page1.ContactTitleHolder.Visible = GetPage1_ContactTitleVisibility();
            Wizard.Page1.PhoneHolder.Visible = GetPage1_PhoneVisibility();
            Wizard.Page1.FaxHolder.Visible = GetPage1_FaxVisibility();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.AddressHolder.Visible = GetPage2_AddressVisibility();
            Wizard.Page2.CityHolder.Visible = GetPage2_CityVisibility();
            Wizard.Page2.RegionHolder.Visible = GetPage2_RegionVisibility();
            Wizard.Page2.PostalCodeHolder.Visible = GetPage2_PostalCodeVisibility();
            Wizard.Page2.CountryHolder.Visible = GetPage2_CountryVisibility();
            Wizard.Page2.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CompanyNameHolder.ReadOnly = !GetPage1_CompanyNameAcessibility();
            Wizard.Page1.ContactNameHolder.ReadOnly = !GetPage1_ContactNameAcessibility();
            Wizard.Page1.ContactTitleHolder.ReadOnly = !GetPage1_ContactTitleAcessibility();
            Wizard.Page1.PhoneHolder.ReadOnly = !GetPage1_PhoneAcessibility();
            Wizard.Page1.FaxHolder.ReadOnly = !GetPage1_FaxAcessibility();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.AddressHolder.ReadOnly = !GetPage2_AddressAcessibility();
            Wizard.Page2.CityHolder.ReadOnly = !GetPage2_CityAcessibility();
            Wizard.Page2.RegionHolder.ReadOnly = !GetPage2_RegionAcessibility();
            Wizard.Page2.PostalCodeHolder.ReadOnly = !GetPage2_PostalCodeAcessibility();
            Wizard.Page2.CountryHolder.ReadOnly = !GetPage2_CountryAcessibility();
            Wizard.Page2.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CompanyNameHolder.RequiredStyle = GetPage1_CompanyNameRequiredStyle();
            Wizard.Page1.ContactNameHolder.RequiredStyle = GetPage1_ContactNameRequiredStyle();
            Wizard.Page1.ContactTitleHolder.RequiredStyle = GetPage1_ContactTitleRequiredStyle();
            Wizard.Page1.PhoneHolder.RequiredStyle = GetPage1_PhoneRequiredStyle();
            Wizard.Page1.FaxHolder.RequiredStyle = GetPage1_FaxRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.AddressHolder.RequiredStyle = GetPage2_AddressRequiredStyle();
            Wizard.Page2.CityHolder.RequiredStyle = GetPage2_CityRequiredStyle();
            Wizard.Page2.RegionHolder.RequiredStyle = GetPage2_RegionRequiredStyle();
            Wizard.Page2.PostalCodeHolder.RequiredStyle = GetPage2_PostalCodeRequiredStyle();
            Wizard.Page2.CountryHolder.RequiredStyle = GetPage2_CountryRequiredStyle();
            Wizard.Page2.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.CompanyNameHolder.Error = GetPage1_CompanyNameValidate();
                Wizard.Page1.ContactNameHolder.Error = GetPage1_ContactNameValidate();
                Wizard.Page1.ContactTitleHolder.Error = GetPage1_ContactTitleValidate();
                Wizard.Page1.PhoneHolder.Error = GetPage1_PhoneValidate();
                Wizard.Page1.FaxHolder.Error = GetPage1_FaxValidate();
                Wizard.Page1.ResumeLayout(true);
            }
            if (page == null || ReferenceEquals(Wizard.Page2, page))
            {
                Wizard.Page2.SuspendLayout();
                Wizard.Page2.AddressHolder.Error = GetPage2_AddressValidate();
                Wizard.Page2.CityHolder.Error = GetPage2_CityValidate();
                Wizard.Page2.RegionHolder.Error = GetPage2_RegionValidate();
                Wizard.Page2.PostalCodeHolder.Error = GetPage2_PostalCodeValidate();
                Wizard.Page2.CountryHolder.Error = GetPage2_CountryValidate();
                Wizard.Page2.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_CompanyNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("CompanyName");
        }

        protected virtual bool GetPage1_CompanyNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_CompanyNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("CompanyName");
        }

        protected virtual string GetPage1_CompanyNameValidate()
        {
            return CurrentObject.GetPropertyValidation("CompanyName");
        }
        protected virtual bool GetPage1_ContactNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("ContactName");
        }

        protected virtual bool GetPage1_ContactNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_ContactNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ContactName");
        }

        protected virtual string GetPage1_ContactNameValidate()
        {
            return CurrentObject.GetPropertyValidation("ContactName");
        }
        protected virtual bool GetPage1_ContactTitleVisibility()
        {
            return CurrentObject.IsPropertyVisible("ContactTitle");
        }

        protected virtual bool GetPage1_ContactTitleAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_ContactTitleRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("ContactTitle");
        }

        protected virtual string GetPage1_ContactTitleValidate()
        {
            return CurrentObject.GetPropertyValidation("ContactTitle");
        }
        protected virtual bool GetPage1_PhoneVisibility()
        {
            return CurrentObject.IsPropertyVisible("Phone");
        }

        protected virtual bool GetPage1_PhoneAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_PhoneRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Phone");
        }

        protected virtual string GetPage1_PhoneValidate()
        {
            return CurrentObject.GetPropertyValidation("Phone");
        }
        protected virtual bool GetPage1_FaxVisibility()
        {
            return CurrentObject.IsPropertyVisible("Fax");
        }

        protected virtual bool GetPage1_FaxAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_FaxRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Fax");
        }

        protected virtual string GetPage1_FaxValidate()
        {
            return CurrentObject.GetPropertyValidation("Fax");
        }
        protected virtual bool GetPage2_AddressVisibility()
        {
            return CurrentObject.IsPropertyVisible("Address");
        }

        protected virtual bool GetPage2_AddressAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_AddressRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Address");
        }

        protected virtual string GetPage2_AddressValidate()
        {
            return CurrentObject.GetPropertyValidation("Address");
        }
        protected virtual bool GetPage2_CityVisibility()
        {
            return CurrentObject.IsPropertyVisible("City");
        }

        protected virtual bool GetPage2_CityAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_CityRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("City");
        }

        protected virtual string GetPage2_CityValidate()
        {
            return CurrentObject.GetPropertyValidation("City");
        }
        protected virtual bool GetPage2_RegionVisibility()
        {
            return CurrentObject.IsPropertyVisible("Region");
        }

        protected virtual bool GetPage2_RegionAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_RegionRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Region");
        }

        protected virtual string GetPage2_RegionValidate()
        {
            return CurrentObject.GetPropertyValidation("Region");
        }
        protected virtual bool GetPage2_PostalCodeVisibility()
        {
            return CurrentObject.IsPropertyVisible("PostalCode");
        }

        protected virtual bool GetPage2_PostalCodeAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_PostalCodeRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("PostalCode");
        }

        protected virtual string GetPage2_PostalCodeValidate()
        {
            return CurrentObject.GetPropertyValidation("PostalCode");
        }
        protected virtual bool GetPage2_CountryVisibility()
        {
            return CurrentObject.IsPropertyVisible("Country");
        }

        protected virtual bool GetPage2_CountryAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_CountryRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Country");
        }

        protected virtual string GetPage2_CountryValidate()
        {
            return CurrentObject.GetPropertyValidation("Country");
        }
    }
}
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


namespace NorthWind.Client.Wizards.CustomerCompactWizard
{
    internal abstract class CodeBehindCustomerCompactWizardPresenter : BaseWizardPresenter<Customers, int, CustomerCompactWizard>
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
    }
}
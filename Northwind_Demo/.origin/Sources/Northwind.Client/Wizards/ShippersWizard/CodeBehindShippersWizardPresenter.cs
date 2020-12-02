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


namespace Northwind.Client.Wizards.ShippersWizard
{
    internal abstract class CodeBehindShippersWizardPresenter : BaseWizardPresenter<Shipper, int, ShippersWizard>
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
            case "Phone":
                Wizard.Page1.PhoneHolder.Error = GetPage1_PhoneValidate();
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
            Wizard.Page1.PhoneHolder.Visible = GetPage1_PhoneVisibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CompanyNameHolder.ReadOnly = !GetPage1_CompanyNameAcessibility();
            Wizard.Page1.PhoneHolder.ReadOnly = !GetPage1_PhoneAcessibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CompanyNameHolder.RequiredStyle = GetPage1_CompanyNameRequiredStyle();
            Wizard.Page1.PhoneHolder.RequiredStyle = GetPage1_PhoneRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.CompanyNameHolder.Error = GetPage1_CompanyNameValidate();
                Wizard.Page1.PhoneHolder.Error = GetPage1_PhoneValidate();
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
    }
}
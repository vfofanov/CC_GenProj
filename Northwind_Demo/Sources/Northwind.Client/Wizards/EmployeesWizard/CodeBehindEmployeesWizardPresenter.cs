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


namespace Northwind.Client.Wizards.EmployeesWizard
{
    internal abstract class CodeBehindEmployeesWizardPresenter : BaseWizardPresenter<Employee, int, EmployeesWizard>
    {

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "LastName":
                Wizard.Page1.LastNameHolder.Error = GetPage1_LastNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "FirstName":
                Wizard.Page1.FirstNameHolder.Error = GetPage1_FirstNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Title":
                Wizard.Page1.TitleHolder.Error = GetPage1_TitleValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "TitleOfCourtesy":
                Wizard.Page1.TitleOfCourtesyHolder.Error = GetPage1_TitleOfCourtesyValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "BirthDate":
                Wizard.Page1.BirthDateHolder.Error = GetPage1_BirthDateValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "HireDate":
                Wizard.Page1.HireDateHolder.Error = GetPage1_HireDateValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Photo":
                Wizard.Page1.PhotoHolder.Error = GetPage1_PhotoValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Notes":
                Wizard.Page1.NotesHolder.Error = GetPage1_NotesValidate();
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
            case "HomePhone":
                Wizard.Page2.HomePhoneHolder.Error = GetPage2_HomePhoneValidate();
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
            Wizard.Page1.LastNameHolder.Visible = GetPage1_LastNameVisibility();
            Wizard.Page1.FirstNameHolder.Visible = GetPage1_FirstNameVisibility();
            Wizard.Page1.TitleHolder.Visible = GetPage1_TitleVisibility();
            Wizard.Page1.TitleOfCourtesyHolder.Visible = GetPage1_TitleOfCourtesyVisibility();
            Wizard.Page1.BirthDateHolder.Visible = GetPage1_BirthDateVisibility();
            Wizard.Page1.HireDateHolder.Visible = GetPage1_HireDateVisibility();
            Wizard.Page1.PhotoHolder.Visible = GetPage1_PhotoVisibility();
            Wizard.Page1.NotesHolder.Visible = GetPage1_NotesVisibility();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.AddressHolder.Visible = GetPage2_AddressVisibility();
            Wizard.Page2.CityHolder.Visible = GetPage2_CityVisibility();
            Wizard.Page2.RegionHolder.Visible = GetPage2_RegionVisibility();
            Wizard.Page2.PostalCodeHolder.Visible = GetPage2_PostalCodeVisibility();
            Wizard.Page2.CountryHolder.Visible = GetPage2_CountryVisibility();
            Wizard.Page2.HomePhoneHolder.Visible = GetPage2_HomePhoneVisibility();
            Wizard.Page2.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.LastNameHolder.ReadOnly = !GetPage1_LastNameAcessibility();
            Wizard.Page1.FirstNameHolder.ReadOnly = !GetPage1_FirstNameAcessibility();
            Wizard.Page1.TitleHolder.ReadOnly = !GetPage1_TitleAcessibility();
            Wizard.Page1.TitleOfCourtesyHolder.ReadOnly = !GetPage1_TitleOfCourtesyAcessibility();
            Wizard.Page1.BirthDateHolder.ReadOnly = !GetPage1_BirthDateAcessibility();
            Wizard.Page1.HireDateHolder.ReadOnly = !GetPage1_HireDateAcessibility();
            Wizard.Page1.PhotoHolder.ReadOnly = !GetPage1_PhotoAcessibility();
            Wizard.Page1.NotesHolder.ReadOnly = !GetPage1_NotesAcessibility();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.AddressHolder.ReadOnly = !GetPage2_AddressAcessibility();
            Wizard.Page2.CityHolder.ReadOnly = !GetPage2_CityAcessibility();
            Wizard.Page2.RegionHolder.ReadOnly = !GetPage2_RegionAcessibility();
            Wizard.Page2.PostalCodeHolder.ReadOnly = !GetPage2_PostalCodeAcessibility();
            Wizard.Page2.CountryHolder.ReadOnly = !GetPage2_CountryAcessibility();
            Wizard.Page2.HomePhoneHolder.ReadOnly = !GetPage2_HomePhoneAcessibility();
            Wizard.Page2.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.LastNameHolder.RequiredStyle = GetPage1_LastNameRequiredStyle();
            Wizard.Page1.FirstNameHolder.RequiredStyle = GetPage1_FirstNameRequiredStyle();
            Wizard.Page1.TitleHolder.RequiredStyle = GetPage1_TitleRequiredStyle();
            Wizard.Page1.TitleOfCourtesyHolder.RequiredStyle = GetPage1_TitleOfCourtesyRequiredStyle();
            Wizard.Page1.BirthDateHolder.RequiredStyle = GetPage1_BirthDateRequiredStyle();
            Wizard.Page1.HireDateHolder.RequiredStyle = GetPage1_HireDateRequiredStyle();
            Wizard.Page1.PhotoHolder.RequiredStyle = GetPage1_PhotoRequiredStyle();
            Wizard.Page1.NotesHolder.RequiredStyle = GetPage1_NotesRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

            Wizard.Page2.SuspendLayout();
            Wizard.Page2.AddressHolder.RequiredStyle = GetPage2_AddressRequiredStyle();
            Wizard.Page2.CityHolder.RequiredStyle = GetPage2_CityRequiredStyle();
            Wizard.Page2.RegionHolder.RequiredStyle = GetPage2_RegionRequiredStyle();
            Wizard.Page2.PostalCodeHolder.RequiredStyle = GetPage2_PostalCodeRequiredStyle();
            Wizard.Page2.CountryHolder.RequiredStyle = GetPage2_CountryRequiredStyle();
            Wizard.Page2.HomePhoneHolder.RequiredStyle = GetPage2_HomePhoneRequiredStyle();
            Wizard.Page2.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.LastNameHolder.Error = GetPage1_LastNameValidate();
                Wizard.Page1.FirstNameHolder.Error = GetPage1_FirstNameValidate();
                Wizard.Page1.TitleHolder.Error = GetPage1_TitleValidate();
                Wizard.Page1.TitleOfCourtesyHolder.Error = GetPage1_TitleOfCourtesyValidate();
                Wizard.Page1.BirthDateHolder.Error = GetPage1_BirthDateValidate();
                Wizard.Page1.HireDateHolder.Error = GetPage1_HireDateValidate();
                Wizard.Page1.PhotoHolder.Error = GetPage1_PhotoValidate();
                Wizard.Page1.NotesHolder.Error = GetPage1_NotesValidate();
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
                Wizard.Page2.HomePhoneHolder.Error = GetPage2_HomePhoneValidate();
                Wizard.Page2.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_LastNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("LastName");
        }

        protected virtual bool GetPage1_LastNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_LastNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("LastName");
        }

        protected virtual string GetPage1_LastNameValidate()
        {
            return CurrentObject.GetPropertyValidation("LastName");
        }
        protected virtual bool GetPage1_FirstNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("FirstName");
        }

        protected virtual bool GetPage1_FirstNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_FirstNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("FirstName");
        }

        protected virtual string GetPage1_FirstNameValidate()
        {
            return CurrentObject.GetPropertyValidation("FirstName");
        }
        protected virtual bool GetPage1_TitleVisibility()
        {
            return CurrentObject.IsPropertyVisible("Title");
        }

        protected virtual bool GetPage1_TitleAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_TitleRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Title");
        }

        protected virtual string GetPage1_TitleValidate()
        {
            return CurrentObject.GetPropertyValidation("Title");
        }
        protected virtual bool GetPage1_TitleOfCourtesyVisibility()
        {
            return CurrentObject.IsPropertyVisible("TitleOfCourtesy");
        }

        protected virtual bool GetPage1_TitleOfCourtesyAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_TitleOfCourtesyRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("TitleOfCourtesy");
        }

        protected virtual string GetPage1_TitleOfCourtesyValidate()
        {
            return CurrentObject.GetPropertyValidation("TitleOfCourtesy");
        }
        protected virtual bool GetPage1_BirthDateVisibility()
        {
            return CurrentObject.IsPropertyVisible("BirthDate");
        }

        protected virtual bool GetPage1_BirthDateAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_BirthDateRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("BirthDate");
        }

        protected virtual string GetPage1_BirthDateValidate()
        {
            return CurrentObject.GetPropertyValidation("BirthDate");
        }
        protected virtual bool GetPage1_HireDateVisibility()
        {
            return CurrentObject.IsPropertyVisible("HireDate");
        }

        protected virtual bool GetPage1_HireDateAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_HireDateRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("HireDate");
        }

        protected virtual string GetPage1_HireDateValidate()
        {
            return CurrentObject.GetPropertyValidation("HireDate");
        }
        protected virtual bool GetPage1_PhotoVisibility()
        {
            return CurrentObject.IsPropertyVisible("Photo");
        }

        protected virtual bool GetPage1_PhotoAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_PhotoRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Photo");
        }

        protected virtual string GetPage1_PhotoValidate()
        {
            return CurrentObject.GetPropertyValidation("Photo");
        }
        protected virtual bool GetPage1_NotesVisibility()
        {
            return CurrentObject.IsPropertyVisible("Notes");
        }

        protected virtual bool GetPage1_NotesAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_NotesRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Notes");
        }

        protected virtual string GetPage1_NotesValidate()
        {
            return CurrentObject.GetPropertyValidation("Notes");
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
        protected virtual bool GetPage2_HomePhoneVisibility()
        {
            return CurrentObject.IsPropertyVisible("HomePhone");
        }

        protected virtual bool GetPage2_HomePhoneAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage2_HomePhoneRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("HomePhone");
        }

        protected virtual string GetPage2_HomePhoneValidate()
        {
            return CurrentObject.GetPropertyValidation("HomePhone");
        }
    }
}
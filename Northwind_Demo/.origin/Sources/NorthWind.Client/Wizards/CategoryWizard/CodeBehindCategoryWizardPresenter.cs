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


namespace NorthWind.Client.Wizards.CategoryWizard
{
    internal abstract class CodeBehindCategoryWizardPresenter : BaseWizardPresenter<Categories, int, CategoryWizard>
    {

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "CategoryName":
                Wizard.Page1.CategoryNameHolder.Error = GetPage1_CategoryNameValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Description":
                Wizard.Page1.DescriptionHolder.Error = GetPage1_DescriptionValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "Picture":
                Wizard.Page1.PictureHolder.Error = GetPage1_PictureValidate();
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
            Wizard.Page1.CategoryNameHolder.Visible = GetPage1_CategoryNameVisibility();
            Wizard.Page1.DescriptionHolder.Visible = GetPage1_DescriptionVisibility();
            Wizard.Page1.PictureHolder.Visible = GetPage1_PictureVisibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CategoryNameHolder.ReadOnly = !GetPage1_CategoryNameAcessibility();
            Wizard.Page1.DescriptionHolder.ReadOnly = !GetPage1_DescriptionAcessibility();
            Wizard.Page1.PictureHolder.ReadOnly = !GetPage1_PictureAcessibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.CategoryNameHolder.RequiredStyle = GetPage1_CategoryNameRequiredStyle();
            Wizard.Page1.DescriptionHolder.RequiredStyle = GetPage1_DescriptionRequiredStyle();
            Wizard.Page1.PictureHolder.RequiredStyle = GetPage1_PictureRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.CategoryNameHolder.Error = GetPage1_CategoryNameValidate();
                Wizard.Page1.DescriptionHolder.Error = GetPage1_DescriptionValidate();
                Wizard.Page1.PictureHolder.Error = GetPage1_PictureValidate();
                Wizard.Page1.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_CategoryNameVisibility()
        {
            return CurrentObject.IsPropertyVisible("CategoryName");
        }

        protected virtual bool GetPage1_CategoryNameAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_CategoryNameRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("CategoryName");
        }

        protected virtual string GetPage1_CategoryNameValidate()
        {
            return CurrentObject.GetPropertyValidation("CategoryName");
        }
        protected virtual bool GetPage1_DescriptionVisibility()
        {
            return CurrentObject.IsPropertyVisible("Description");
        }

        protected virtual bool GetPage1_DescriptionAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_DescriptionRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Description");
        }

        protected virtual string GetPage1_DescriptionValidate()
        {
            return CurrentObject.GetPropertyValidation("Description");
        }
        protected virtual bool GetPage1_PictureVisibility()
        {
            return CurrentObject.IsPropertyVisible("Picture");
        }

        protected virtual bool GetPage1_PictureAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_PictureRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Picture");
        }

        protected virtual string GetPage1_PictureValidate()
        {
            return CurrentObject.GetPropertyValidation("Picture");
        }
    }
}
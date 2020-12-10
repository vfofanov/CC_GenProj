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


namespace NorthWind.Client.Wizards.RegionWizard
{
    internal abstract class CodeBehindRegionWizardPresenter : BaseWizardPresenter<Region, int, RegionWizard>
    {

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "Id":
                Wizard.Page1.IdHolder.Error = GetPage1_IdValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "RegionDescription":
                Wizard.Page1.RegionDescriptionHolder.Error = GetPage1_RegionDescriptionValidate();
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
            Wizard.Page1.IdHolder.Visible = GetPage1_IdVisibility();
            Wizard.Page1.RegionDescriptionHolder.Visible = GetPage1_RegionDescriptionVisibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.IdHolder.ReadOnly = !GetPage1_IdAcessibility();
            Wizard.Page1.RegionDescriptionHolder.ReadOnly = !GetPage1_RegionDescriptionAcessibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.IdHolder.RequiredStyle = GetPage1_IdRequiredStyle();
            Wizard.Page1.RegionDescriptionHolder.RequiredStyle = GetPage1_RegionDescriptionRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.IdHolder.Error = GetPage1_IdValidate();
                Wizard.Page1.RegionDescriptionHolder.Error = GetPage1_RegionDescriptionValidate();
                Wizard.Page1.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_IdVisibility()
        {
            return CurrentObject.IsPropertyVisible("Id");
        }

        protected virtual bool GetPage1_IdAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_IdRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("Id");
        }

        protected virtual string GetPage1_IdValidate()
        {
            return CurrentObject.GetPropertyValidation("Id");
        }
        protected virtual bool GetPage1_RegionDescriptionVisibility()
        {
            return CurrentObject.IsPropertyVisible("RegionDescription");
        }

        protected virtual bool GetPage1_RegionDescriptionAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_RegionDescriptionRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("RegionDescription");
        }

        protected virtual string GetPage1_RegionDescriptionValidate()
        {
            return CurrentObject.GetPropertyValidation("RegionDescription");
        }
    }
}
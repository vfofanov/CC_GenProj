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


namespace NorthWind.Client.Wizards.ReportFormQueryWizard
{
    internal abstract class CodeBehindReportFormQueryWizardPresenter : BaseWizardPresenter<ReportFormQuery, int, ReportFormQueryWizard>
    {

        protected override void OnObjectChanged()
        {
            RefreshEmployeeIdDataSourceOnPage1();
            RefreshCustomerIdDataSourceOnPage1();
			
        }

        protected override void OnObjectPropertyChanged(PropertyChangedEventArgs e)
        {

            Wizard.Page1.SuspendLayout();
            switch(e.PropertyName)
            {
            case "EmployeeId":
                Wizard.Page1.EmployeeIdHolder.Error = GetPage1_EmployeeIdValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "CustomerId":
                Wizard.Page1.CustomerIdHolder.Error = GetPage1_CustomerIdValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "From":
                Wizard.Page1.FromHolder.Error = GetPage1_FromValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "To":
                Wizard.Page1.ToHolder.Error = GetPage1_ToValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            case "useExcel":
                Wizard.Page1.useExcelHolder.Error = GetPage1_useExcelValidate();
                Wizard.RefreshStepValidationStyle(Wizard.Page1);
                break;
            }
            Wizard.Page1.ResumeLayout(true);

        }

        protected override void OnWizardParameterChanged(PropertyChangedEventArgs e)
        {

        }


        protected void RefreshEmployeeIdDataSourceOnPage1()
        {
            Wizard.Page1.SetEmployeeIdDataSource(GetEmployeeIdDataSourceOnPage1());
        }
        protected virtual IQueryable<Employees> GetEmployeeIdDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<Employees,int>().GetAllObjects();
        }

        protected void RefreshCustomerIdDataSourceOnPage1()
        {
            Wizard.Page1.SetCustomerIdDataSource(GetCustomerIdDataSourceOnPage1());
        }
        protected virtual IQueryable<Customers> GetCustomerIdDataSourceOnPage1()
        {
            return SessionGlobalServices.GetManager<Customers,int>().GetAllObjects();
        }
	
        protected sealed override void RefreshVisibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.EmployeeIdHolder.Visible = GetPage1_EmployeeIdVisibility();
            Wizard.Page1.CustomerIdHolder.Visible = GetPage1_CustomerIdVisibility();
            Wizard.Page1.FromHolder.Visible = GetPage1_FromVisibility();
            Wizard.Page1.ToHolder.Visible = GetPage1_ToVisibility();
            Wizard.Page1.useExcelHolder.Visible = GetPage1_useExcelVisibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshAccessibility()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.EmployeeIdHolder.ReadOnly = !GetPage1_EmployeeIdAcessibility();
            Wizard.Page1.CustomerIdHolder.ReadOnly = !GetPage1_CustomerIdAcessibility();
            Wizard.Page1.FromHolder.ReadOnly = !GetPage1_FromAcessibility();
            Wizard.Page1.ToHolder.ReadOnly = !GetPage1_ToAcessibility();
            Wizard.Page1.useExcelHolder.ReadOnly = !GetPage1_useExcelAcessibility();
            Wizard.Page1.ResumeLayout(true);

        }

        protected sealed override void RefreshRequiredStyles()
        {
            Wizard.Page1.SuspendLayout();
            Wizard.Page1.EmployeeIdHolder.RequiredStyle = GetPage1_EmployeeIdRequiredStyle();
            Wizard.Page1.CustomerIdHolder.RequiredStyle = GetPage1_CustomerIdRequiredStyle();
            Wizard.Page1.FromHolder.RequiredStyle = GetPage1_FromRequiredStyle();
            Wizard.Page1.ToHolder.RequiredStyle = GetPage1_ToRequiredStyle();
            Wizard.Page1.useExcelHolder.RequiredStyle = GetPage1_useExcelRequiredStyle();
            Wizard.Page1.ResumeLayout(true);

        }

        public sealed override void ValidateControls(BaseWizardPage page = null)
        {
            if (page == null || ReferenceEquals(Wizard.Page1, page))
            {
                Wizard.Page1.SuspendLayout();
                Wizard.Page1.EmployeeIdHolder.Error = GetPage1_EmployeeIdValidate();
                Wizard.Page1.CustomerIdHolder.Error = GetPage1_CustomerIdValidate();
                Wizard.Page1.FromHolder.Error = GetPage1_FromValidate();
                Wizard.Page1.ToHolder.Error = GetPage1_ToValidate();
                Wizard.Page1.useExcelHolder.Error = GetPage1_useExcelValidate();
                Wizard.Page1.ResumeLayout(true);
            }
        }

        protected virtual bool GetPage1_EmployeeIdVisibility()
        {
            return CurrentObject.IsPropertyVisible("EmployeeId");
        }

        protected virtual bool GetPage1_EmployeeIdAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_EmployeeIdRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("EmployeeId");
        }

        protected virtual string GetPage1_EmployeeIdValidate()
        {
            return CurrentObject.GetPropertyValidation("EmployeeId");
        }
        protected virtual bool GetPage1_CustomerIdVisibility()
        {
            return CurrentObject.IsPropertyVisible("CustomerId");
        }

        protected virtual bool GetPage1_CustomerIdAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_CustomerIdRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("CustomerId");
        }

        protected virtual string GetPage1_CustomerIdValidate()
        {
            return CurrentObject.GetPropertyValidation("CustomerId");
        }
        protected virtual bool GetPage1_FromVisibility()
        {
            return CurrentObject.IsPropertyVisible("From");
        }

        protected virtual bool GetPage1_FromAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_FromRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("From");
        }

        protected virtual string GetPage1_FromValidate()
        {
            return CurrentObject.GetPropertyValidation("From");
        }
        protected virtual bool GetPage1_ToVisibility()
        {
            return CurrentObject.IsPropertyVisible("To");
        }

        protected virtual bool GetPage1_ToAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_ToRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("To");
        }

        protected virtual string GetPage1_ToValidate()
        {
            return CurrentObject.GetPropertyValidation("To");
        }
        protected virtual bool GetPage1_useExcelVisibility()
        {
            return CurrentObject.IsPropertyVisible("useExcel");
        }

        protected virtual bool GetPage1_useExcelAcessibility()
        {
            return true;
        }

        protected virtual bool GetPage1_useExcelRequiredStyle()
        {
            return CurrentObject.IsPropertyRequired("useExcel");
        }

        protected virtual string GetPage1_useExcelValidate()
        {
            return CurrentObject.GetPropertyValidation("useExcel");
        }
    }
}
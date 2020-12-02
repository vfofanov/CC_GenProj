using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.EmployeesWizard
{
    /// <summary> Wizard for Employee </summary>
    public sealed class EmployeesWizard : ObjectWizard<Employee, EmployeesWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();
        private readonly Page2 _page2 = new Page2();

        private readonly EmployeesWizardPresenter _employeesWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _employeesWizardPresenter; } }

        public EmployeesWizard()
        {
            _employeesWizardPresenter = new EmployeesWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}
        public Page2 Page2
		{
		    get{ return _page2; }
		}

        protected override void InitPages(Employee businessObject)
        {
            Page1.Wizard = this;
            Page1.Init(businessObject, Parameters);
            Page2.Wizard = this;
            Page2.Init(businessObject, Parameters);
        }

        protected override bool CommitUnchangedObject
        {
            get { return  true; }
        }
		      
        protected override void PrepareForm(IWizardForm form)
        {
		    var objectTypeDisplayName = "Employee";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Employees", 48));			

            form.AddGroup("");
                form.AddStep("Main Info",
                        "Please add empolyee main info",
                        "Employee Main Info", 
                        Page1,
                        Page1.GetPropertyControlHolders());
                form.AddStep("Address",
                        "Please add employee address",
                        "Employee Address", 
                        Page2,
                        Page2.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.CustomersWizard
{
    /// <summary> Wizard for Customer </summary>
    public sealed class CustomersWizard : ObjectWizard<Customer, CustomersWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();
        private readonly Page2 _page2 = new Page2();

        private readonly CustomersWizardPresenter _customersWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _customersWizardPresenter; } }

        public CustomersWizard()
        {
            _customersWizardPresenter = new CustomersWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}
        public Page2 Page2
		{
		    get{ return _page2; }
		}

        protected override void InitPages(Customer businessObject)
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
		    var objectTypeDisplayName = "Customer";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Customers", 48));			

            form.AddGroup("");
                form.AddStep("Main Info",
                        "Please add customer main info",
                        "Customer Main Info", 
                        Page1,
                        Page1.GetPropertyControlHolders());
                form.AddStep("Address",
                        "Please add customer address",
                        "Customer Address", 
                        Page2,
                        Page2.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

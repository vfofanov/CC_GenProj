using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.CustomerCompactWizard
{
    /// <summary> Wizard for Customers </summary>
    public sealed class CustomerCompactWizard : ObjectWizard<Customers, CustomerCompactWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly CustomerCompactWizardPresenter _customerCompactWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _customerCompactWizardPresenter; } }

        public CustomerCompactWizard()
        {
            _customerCompactWizardPresenter = new CustomerCompactWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Customers businessObject)
        {
            Page1.Wizard = this;
            Page1.Init(businessObject, Parameters);
        }

        protected override bool CommitUnchangedObject
        {
            get { return  true; }
        }
		      
        protected override void PrepareForm(IWizardForm form)
        {
		    var objectTypeDisplayName = "Customers";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Customers", 48));			

            form.AddGroup("");
                form.AddStep("Main Info",
                        "Please add customer main info",
                        "Customer Main Info", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

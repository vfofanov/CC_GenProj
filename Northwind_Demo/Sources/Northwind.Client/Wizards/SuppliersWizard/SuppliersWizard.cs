using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.SuppliersWizard
{
    /// <summary> Wizard for Supplier </summary>
    public sealed class SuppliersWizard : ObjectWizard<Supplier, SuppliersWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();
        private readonly Page2 _page2 = new Page2();

        private readonly SuppliersWizardPresenter _suppliersWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _suppliersWizardPresenter; } }

        public SuppliersWizard()
        {
            _suppliersWizardPresenter = new SuppliersWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}
        public Page2 Page2
		{
		    get{ return _page2; }
		}

        protected override void InitPages(Supplier businessObject)
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
		    var objectTypeDisplayName = "Supplier";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Suppliers", 48));			

            form.AddGroup("");
                form.AddStep("Supplier Details",
                        "Please add supplier details",
                        "Supplier Details", 
                        Page1,
                        Page1.GetPropertyControlHolders());
                form.AddStep("Supplier Details",
                        "Please add supplier details",
                        "Supplier Details", 
                        Page2,
                        Page2.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

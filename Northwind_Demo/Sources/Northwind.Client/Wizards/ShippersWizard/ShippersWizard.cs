using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.ShippersWizard
{
    /// <summary> Wizard for Shipper </summary>
    public sealed class ShippersWizard : ObjectWizard<Shipper, ShippersWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly ShippersWizardPresenter _shippersWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _shippersWizardPresenter; } }

        public ShippersWizard()
        {
            _shippersWizardPresenter = new ShippersWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Shipper businessObject)
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
		    var objectTypeDisplayName = "Shipper";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Shippers", 48));			

            form.AddGroup("");
                form.AddStep("Page -1",
                        "Please add shipper details",
                        "Shipper Details", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

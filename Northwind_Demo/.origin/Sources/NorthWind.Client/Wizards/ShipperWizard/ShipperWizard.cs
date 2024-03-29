using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.ShipperWizard
{
    /// <summary> Wizard for Shippers </summary>
    public sealed class ShipperWizard : ObjectWizard<Shippers, ShipperWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly ShipperWizardPresenter _shipperWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _shipperWizardPresenter; } }

        public ShipperWizard()
        {
            _shipperWizardPresenter = new ShipperWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Shippers businessObject)
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
		    var objectTypeDisplayName = "Shippers";

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

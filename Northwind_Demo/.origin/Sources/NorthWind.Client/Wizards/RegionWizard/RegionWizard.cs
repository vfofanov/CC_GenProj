using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.RegionWizard
{
    /// <summary> Wizard for Region </summary>
    public sealed class RegionWizard : ObjectWizard<Region, RegionWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly RegionWizardPresenter _regionWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _regionWizardPresenter; } }

        public RegionWizard()
        {
            _regionWizardPresenter = new RegionWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Region businessObject)
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
		    var objectTypeDisplayName = "Region";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Region", 48));			

            form.AddGroup("");
                form.AddStep("Page1",
                        "Page1",
                        "Page1", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

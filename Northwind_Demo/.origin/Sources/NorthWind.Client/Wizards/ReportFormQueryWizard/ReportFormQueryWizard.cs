using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.ReportFormQueryWizard
{
    /// <summary> Wizard for ReportFormQuery </summary>
    public sealed class ReportFormQueryWizard : ObjectWizard<ReportFormQuery, ReportFormQueryWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly ReportFormQueryWizardPresenter _reportFormQueryWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _reportFormQueryWizardPresenter; } }

        public ReportFormQueryWizard()
        {
            _reportFormQueryWizardPresenter = new ReportFormQueryWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(ReportFormQuery businessObject)
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
		    var objectTypeDisplayName = "ReportFormQuery";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Orders", 48));			

            form.AddGroup("");
                form.AddStep("Orders Report",
                        "Orders Report",
                        "Get list of orders by selected criteria", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

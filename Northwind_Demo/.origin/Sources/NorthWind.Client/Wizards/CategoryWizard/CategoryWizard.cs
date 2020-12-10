using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.CategoryWizard
{
    /// <summary> Wizard for Categories </summary>
    public sealed class CategoryWizard : ObjectWizard<Categories, CategoryWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly CategoryWizardPresenter _categoryWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _categoryWizardPresenter; } }

        public CategoryWizard()
        {
            _categoryWizardPresenter = new CategoryWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Categories businessObject)
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
		    var objectTypeDisplayName = "Categories";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Categories", 48));			

            form.AddGroup("");
                form.AddStep("Category Details",
                        "Please add category details ",
                        "Category Details", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.CategoriesWizard
{
    /// <summary> Wizard for Category </summary>
    public sealed class CategoriesWizard : ObjectWizard<Category, CategoriesWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly CategoriesWizardPresenter _categoriesWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _categoriesWizardPresenter; } }

        public CategoriesWizard()
        {
            _categoriesWizardPresenter = new CategoriesWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Category businessObject)
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
		    var objectTypeDisplayName = "Category";

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

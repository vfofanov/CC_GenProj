using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.ProductsWizard
{
    /// <summary> Wizard for Product </summary>
    public sealed class ProductsWizard : ObjectWizard<Product, ProductsWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly ProductsWizardPresenter _productsWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _productsWizardPresenter; } }

        public ProductsWizard()
        {
            _productsWizardPresenter = new ProductsWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(Product businessObject)
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
		    var objectTypeDisplayName = "Product";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Products", 48));			

            form.AddGroup("");
                form.AddStep("Product Details ",
                        "Please add product details",
                        "Product Details ", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

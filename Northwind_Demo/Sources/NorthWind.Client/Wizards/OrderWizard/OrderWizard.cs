using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.OrderWizard
{
    /// <summary> Wizard for Orders </summary>
    public sealed class OrderWizard : ObjectWizard<Orders, OrderWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();
        private readonly Page2 _page2 = new Page2();

        private readonly OrderWizardPresenter _orderWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _orderWizardPresenter; } }

        public OrderWizard()
        {
            _orderWizardPresenter = new OrderWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}
        public Page2 Page2
		{
		    get{ return _page2; }
		}

        protected override void InitPages(Orders businessObject)
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
		    var objectTypeDisplayName = "Orders";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("Orders", 48));			

            form.AddGroup("");
                form.AddStep("Order Details",
                        "Please add order details",
                        "Order Details", 
                        Page1,
                        Page1.GetPropertyControlHolders());
                form.AddStep("Order Shipping Info",
                        "Please add order shipping info",
                        "Order Shipping Info", 
                        Page2,
                        Page2.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;




namespace NorthWind.Client.Wizards.OrderDetailWizard
{
    /// <summary> Wizard for OrderDetails </summary>
    public sealed class OrderDetailWizard : ObjectWizard<OrderDetails, OrderDetailWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly OrderDetailWizardPresenter _orderDetailWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _orderDetailWizardPresenter; } }

        public OrderDetailWizard()
        {
            _orderDetailWizardPresenter = new OrderDetailWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(OrderDetails businessObject)
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
		    var objectTypeDisplayName = "OrderDetails";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("OrderDetails", 48));			

            form.AddGroup("");
                form.AddStep("Page -1",
                        "Please add order product info",
                        "Order Product Info", 
                        Page1,
                        Page1.GetPropertyControlHolders());

			SetAutoValidate(AutoValidate.EnablePreventFocusChange);
        }
			
	
    }
}

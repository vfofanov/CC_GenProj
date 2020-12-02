using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFramework.Client.WinForms.IG.Wizard;
using BusinessFramework.Client.WinForms.Utils;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;




namespace Northwind.Client.Wizards.OrderDetailsWizard
{
    /// <summary> Wizard for OrderDetail </summary>
    public sealed class OrderDetailsWizard : ObjectWizard<OrderDetail, OrderDetailsWizardParameters>
    {
        private readonly Page1 _page1 = new Page1();

        private readonly OrderDetailsWizardPresenter _orderDetailsWizardPresenter;
        protected override IWizardPresenter Presenter { get{ return _orderDetailsWizardPresenter; } }

        public OrderDetailsWizard()
        {
            _orderDetailsWizardPresenter = new OrderDetailsWizardPresenter {Wizard = this};
        }

        public Page1 Page1
		{
		    get{ return _page1; }
		}

        protected override void InitPages(OrderDetail businessObject)
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
		    var objectTypeDisplayName = "OrderDetail";

            form.AddGroup(objectTypeDisplayName);

            form.Text = GetWizardHeaderName(objectTypeDisplayName);

            form.AddBannerImage(ResourceImageManager.Default.GetImage("OrderDetail", 48));			

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

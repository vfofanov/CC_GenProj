using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;


namespace Northwind.Common.Wizards.Initialization
{
    public sealed class OrdersWizardInitialization : CodeBehind.CodeBehindOrdersWizardInitialization
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public OrdersWizardInitialization(
        //--  custom dependencies
		//-- /custom dependencies
        )
            :base()
        {
        }
    }
}
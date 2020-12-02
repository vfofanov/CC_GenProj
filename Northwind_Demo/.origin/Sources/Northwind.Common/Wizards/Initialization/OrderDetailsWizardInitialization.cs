using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;


namespace Northwind.Common.Wizards.Initialization
{
    public sealed class OrderDetailsWizardInitialization : CodeBehind.CodeBehindOrderDetailsWizardInitialization
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public OrderDetailsWizardInitialization(
        //--  custom dependencies
		//-- /custom dependencies
        )
            :base()
        {
        }
    }
}
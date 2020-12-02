using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;


namespace Northwind.Common.Wizards.Initialization
{
    public sealed class CustomersWizardInitialization : CodeBehind.CodeBehindCustomersWizardInitialization
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public CustomersWizardInitialization(
        //--  custom dependencies
		//-- /custom dependencies
        )
            :base()
        {
        }
    }
}
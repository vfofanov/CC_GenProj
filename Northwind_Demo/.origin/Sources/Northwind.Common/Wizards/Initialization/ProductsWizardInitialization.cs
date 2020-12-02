using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;


namespace Northwind.Common.Wizards.Initialization
{
    public sealed class ProductsWizardInitialization : CodeBehind.CodeBehindProductsWizardInitialization
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ProductsWizardInitialization(
        //--  custom dependencies
		//-- /custom dependencies
        )
            :base()
        {
        }
    }
}
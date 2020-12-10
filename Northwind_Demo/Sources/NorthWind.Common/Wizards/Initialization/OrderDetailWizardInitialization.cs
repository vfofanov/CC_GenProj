using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;


namespace NorthWind.Common.Wizards.Initialization
{
    public sealed class OrderDetailWizardInitialization : CodeBehind.CodeBehindOrderDetailWizardInitialization
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public OrderDetailWizardInitialization(
        //--  custom dependencies
		//-- /custom dependencies
        )
            :base()
        {
        }
    }
}
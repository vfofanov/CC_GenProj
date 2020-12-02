using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;


namespace Northwind.Common.Wizards.Initialization
{
    public sealed class EmployeesWizardInitialization : CodeBehind.CodeBehindEmployeesWizardInitialization
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public EmployeesWizardInitialization(
        //--  custom dependencies
		//-- /custom dependencies
        )
            :base()
        {
        }
    }
}
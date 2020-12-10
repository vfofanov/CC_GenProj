using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindCustomerWizardInitialization : IWizardInitialization<Customers, CustomerWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(CustomerWizardParameters parameters, Customers entity)
        {
        }

        /// <inheritdoc />
        public virtual CustomerWizardParameters GetParameters()
        {
            var result = new CustomerWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(CustomerWizardParameters parameters, Customers entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.CustomerWizard; }
        }
    }
}
using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindCustomerCompactWizardInitialization : IWizardInitialization<Customers, CustomerCompactWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(CustomerCompactWizardParameters parameters, Customers entity)
        {
        }

        /// <inheritdoc />
        public virtual CustomerCompactWizardParameters GetParameters()
        {
            var result = new CustomerCompactWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(CustomerCompactWizardParameters parameters, Customers entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.CustomerCompactWizard; }
        }
    }
}
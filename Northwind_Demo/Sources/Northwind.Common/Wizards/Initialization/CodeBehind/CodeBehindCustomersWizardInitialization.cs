using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindCustomersWizardInitialization : IWizardInitialization<Customer, CustomersWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(CustomersWizardParameters parameters, Customer entity)
        {
        }

        /// <inheritdoc />
        public virtual CustomersWizardParameters GetParameters()
        {
            var result = new CustomersWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(CustomersWizardParameters parameters, Customer entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.CustomersWizard; }
        }
    }
}
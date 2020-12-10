using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindOrderWizardInitialization : IWizardInitialization<Orders, OrderWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(OrderWizardParameters parameters, Orders entity)
        {
        }

        /// <inheritdoc />
        public virtual OrderWizardParameters GetParameters()
        {
            var result = new OrderWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(OrderWizardParameters parameters, Orders entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.OrderWizard; }
        }
    }
}
using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindProductWizardInitialization : IWizardInitialization<Products, ProductWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(ProductWizardParameters parameters, Products entity)
        {
        }

        /// <inheritdoc />
        public virtual ProductWizardParameters GetParameters()
        {
            var result = new ProductWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(ProductWizardParameters parameters, Products entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.ProductWizard; }
        }
    }
}
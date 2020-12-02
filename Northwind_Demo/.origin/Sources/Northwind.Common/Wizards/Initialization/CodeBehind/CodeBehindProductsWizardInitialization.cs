using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindProductsWizardInitialization : IWizardInitialization<Product, ProductsWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(ProductsWizardParameters parameters, Product entity)
        {
        }

        /// <inheritdoc />
        public virtual ProductsWizardParameters GetParameters()
        {
            var result = new ProductsWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(ProductsWizardParameters parameters, Product entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.ProductsWizard; }
        }
    }
}
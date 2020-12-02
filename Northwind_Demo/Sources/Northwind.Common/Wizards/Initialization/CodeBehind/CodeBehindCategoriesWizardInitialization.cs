using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindCategoriesWizardInitialization : IWizardInitialization<Category, CategoriesWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(CategoriesWizardParameters parameters, Category entity)
        {
        }

        /// <inheritdoc />
        public virtual CategoriesWizardParameters GetParameters()
        {
            var result = new CategoriesWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(CategoriesWizardParameters parameters, Category entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.CategoriesWizard; }
        }
    }
}
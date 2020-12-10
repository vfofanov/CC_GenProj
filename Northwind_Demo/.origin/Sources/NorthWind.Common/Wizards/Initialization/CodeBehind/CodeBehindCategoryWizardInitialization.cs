using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindCategoryWizardInitialization : IWizardInitialization<Categories, CategoryWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(CategoryWizardParameters parameters, Categories entity)
        {
        }

        /// <inheritdoc />
        public virtual CategoryWizardParameters GetParameters()
        {
            var result = new CategoryWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(CategoryWizardParameters parameters, Categories entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.CategoryWizard; }
        }
    }
}
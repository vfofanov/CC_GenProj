using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindSupplierWizardInitialization : IWizardInitialization<Suppliers, SupplierWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(SupplierWizardParameters parameters, Suppliers entity)
        {
        }

        /// <inheritdoc />
        public virtual SupplierWizardParameters GetParameters()
        {
            var result = new SupplierWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(SupplierWizardParameters parameters, Suppliers entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.SupplierWizard; }
        }
    }
}
using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindSuppliersWizardInitialization : IWizardInitialization<Supplier, SuppliersWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(SuppliersWizardParameters parameters, Supplier entity)
        {
        }

        /// <inheritdoc />
        public virtual SuppliersWizardParameters GetParameters()
        {
            var result = new SuppliersWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(SuppliersWizardParameters parameters, Supplier entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.SuppliersWizard; }
        }
    }
}
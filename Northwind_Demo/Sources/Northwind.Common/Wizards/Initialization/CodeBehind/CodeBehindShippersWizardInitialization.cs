using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindShippersWizardInitialization : IWizardInitialization<Shipper, ShippersWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(ShippersWizardParameters parameters, Shipper entity)
        {
        }

        /// <inheritdoc />
        public virtual ShippersWizardParameters GetParameters()
        {
            var result = new ShippersWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(ShippersWizardParameters parameters, Shipper entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.ShippersWizard; }
        }
    }
}
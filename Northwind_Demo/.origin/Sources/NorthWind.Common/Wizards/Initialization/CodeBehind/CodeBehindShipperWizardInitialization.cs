using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindShipperWizardInitialization : IWizardInitialization<Shippers, ShipperWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(ShipperWizardParameters parameters, Shippers entity)
        {
        }

        /// <inheritdoc />
        public virtual ShipperWizardParameters GetParameters()
        {
            var result = new ShipperWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(ShipperWizardParameters parameters, Shippers entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.ShipperWizard; }
        }
    }
}
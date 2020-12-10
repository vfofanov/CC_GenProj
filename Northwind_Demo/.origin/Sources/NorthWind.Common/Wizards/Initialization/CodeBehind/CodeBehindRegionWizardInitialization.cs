using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindRegionWizardInitialization : IWizardInitialization<Region, RegionWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(RegionWizardParameters parameters, Region entity)
        {
        }

        /// <inheritdoc />
        public virtual RegionWizardParameters GetParameters()
        {
            var result = new RegionWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(RegionWizardParameters parameters, Region entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.RegionWizard; }
        }
    }
}
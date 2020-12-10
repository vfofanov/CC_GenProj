using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindReportFormQueryWizardInitialization : IWizardInitialization<ReportFormQuery, ReportFormQueryWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(ReportFormQueryWizardParameters parameters, ReportFormQuery entity)
        {
        }

        /// <inheritdoc />
        public virtual ReportFormQueryWizardParameters GetParameters()
        {
            var result = new ReportFormQueryWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(ReportFormQueryWizardParameters parameters, ReportFormQuery entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.ReportFormQueryWizard; }
        }
    }
}
using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindEmployeeWizardInitialization : IWizardInitialization<Employees, EmployeeWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(EmployeeWizardParameters parameters, Employees entity)
        {
        }

        /// <inheritdoc />
        public virtual EmployeeWizardParameters GetParameters()
        {
            var result = new EmployeeWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(EmployeeWizardParameters parameters, Employees entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.EmployeeWizard; }
        }
    }
}
using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindEmployeesWizardInitialization : IWizardInitialization<Employee, EmployeesWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(EmployeesWizardParameters parameters, Employee entity)
        {
        }

        /// <inheritdoc />
        public virtual EmployeesWizardParameters GetParameters()
        {
            var result = new EmployeesWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(EmployeesWizardParameters parameters, Employee entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.EmployeesWizard; }
        }
    }
}
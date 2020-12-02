using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindOrderDetailsWizardInitialization : IWizardInitialization<OrderDetail, OrderDetailsWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(OrderDetailsWizardParameters parameters, OrderDetail entity)
        {
        }

        /// <inheritdoc />
        public virtual OrderDetailsWizardParameters GetParameters()
        {
            var result = new OrderDetailsWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(OrderDetailsWizardParameters parameters, OrderDetail entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.OrderDetailsWizard; }
        }
    }
}
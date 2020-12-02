using System;
using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindOrdersWizardInitialization : IWizardInitialization<Order, OrdersWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(OrdersWizardParameters parameters, Order entity)
        {
        }

        /// <inheritdoc />
        public virtual OrdersWizardParameters GetParameters()
        {
            var result = new OrdersWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(OrdersWizardParameters parameters, Order entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.OrdersWizard; }
        }
    }
}
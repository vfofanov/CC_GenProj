using System;
using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Wizards.Initialization.CodeBehind
{
    public abstract class CodeBehindOrderDetailWizardInitialization : IWizardInitialization<OrderDetails, OrderDetailWizardParameters>
    {


        /// <inheritdoc />
        public virtual void SetDefaults(OrderDetailWizardParameters parameters, OrderDetails entity)
        {
        }

        /// <inheritdoc />
        public virtual OrderDetailWizardParameters GetParameters()
        {
            var result = new OrderDetailWizardParameters();

            return result;
        }

		/// <inheritdoc />
        public virtual void PostParametersHandling(OrderDetailWizardParameters parameters, OrderDetails entity)
        {
        }
        public string Name
        {
            get { return DomainWizards.Names.OrderDetailWizard; }
        }
    }
}
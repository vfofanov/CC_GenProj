using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class CustomersScreenViewModel : CodeBehind.CodeBehindCustomersScreenViewModel
    {
        public CustomersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		ICustomerQueryCollectionManager customerQueryCollectionManager, IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory)
		    :base(customerQueryCollectionManager, entityManagementService, screenCommandFactory)
        {
        }
    }
}
using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class CustomersScreenViewModel : CodeBehind.CodeBehindCustomersScreenViewModel
    {
        public CustomersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IQCustomersCollectionManager qCustomersCollectionManager, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, qCustomersCollectionManager, screenCommandFactory)
        {
        }
    }
}
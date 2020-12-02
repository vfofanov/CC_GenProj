using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class ShippersScreenViewModel : CodeBehind.CodeBehindShippersScreenViewModel
    {
        public ShippersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IQShippersCollectionManager qShippersCollectionManager, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, qShippersCollectionManager, screenCommandFactory)
        {
        }
    }
}
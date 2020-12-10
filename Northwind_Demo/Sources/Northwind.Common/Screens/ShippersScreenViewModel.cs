using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class ShippersScreenViewModel : CodeBehind.CodeBehindShippersScreenViewModel
    {
        public ShippersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory, IShipperQueryCollectionManager shipperQueryCollectionManager)
		    :base(entityManagementService, screenCommandFactory, shipperQueryCollectionManager)
        {
        }
    }
}
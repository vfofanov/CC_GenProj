using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.ActionServices;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class OrdersScreenViewModel : CodeBehind.CodeBehindOrdersScreenViewModel
    {
        public OrdersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IOrderProductQueryCollectionManager orderProductQueryCollectionManager, IOrdersQueryCollectionManager ordersQueryCollectionManager, IReportService reportService, IScreenCommandFactory screenCommandFactory, IServerActionRunService serverActionRunService, IShipperQueryCollectionManager shipperQueryCollectionManager)
		    :base(entityManagementService, orderProductQueryCollectionManager, ordersQueryCollectionManager, reportService, screenCommandFactory, serverActionRunService, shipperQueryCollectionManager)
        {
        }
    }
}
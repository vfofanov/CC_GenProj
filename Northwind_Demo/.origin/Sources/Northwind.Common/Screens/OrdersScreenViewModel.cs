using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Reporting;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.ActionServices;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class OrdersScreenViewModel : CodeBehind.CodeBehindOrdersScreenViewModel
    {
        public OrdersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IClientOrderManagerService clientOrderManagerService, IEntityManagementService entityManagementService, IQOrderProductsCollectionManager qOrderProductsCollectionManager, IQOrdersCollectionManager qOrdersCollectionManager, IQShippersCollectionManager qShippersCollectionManager, IReportViewer reportViewer, IScreenCommandFactory screenCommandFactory)
		    :base(clientOrderManagerService, entityManagementService, qOrderProductsCollectionManager, qOrdersCollectionManager, qShippersCollectionManager, reportViewer, screenCommandFactory)
        {
        }
    }
}
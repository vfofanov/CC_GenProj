using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Reporting;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class CategoriesScreenViewModel : CodeBehind.CodeBehindCategoriesScreenViewModel
    {
        public CategoriesScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		ICategoryQueryCollectionManager categoryQueryCollectionManager, IEntityManagementService entityManagementService, IProductQueryCollectionManager productQueryCollectionManager, IReportViewer reportViewer, IScreenCommandFactory screenCommandFactory)
		    :base(categoryQueryCollectionManager, entityManagementService, productQueryCollectionManager, reportViewer, screenCommandFactory)
        {
        }
    }
}
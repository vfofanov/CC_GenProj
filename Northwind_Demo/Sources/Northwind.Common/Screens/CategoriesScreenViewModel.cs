using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Reporting;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class CategoriesScreenViewModel : CodeBehind.CodeBehindCategoriesScreenViewModel
    {
        public CategoriesScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IQCategoriesCollectionManager qCategoriesCollectionManager, IQProductsCollectionManager qProductsCollectionManager, IReportViewer reportViewer, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, qCategoriesCollectionManager, qProductsCollectionManager, reportViewer, screenCommandFactory)
        {
        }
    }
}
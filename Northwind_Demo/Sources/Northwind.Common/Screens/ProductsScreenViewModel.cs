using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class ProductsScreenViewModel : CodeBehind.CodeBehindProductsScreenViewModel
    {
        public ProductsScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IQCategoriesCollectionManager qCategoriesCollectionManager, IQProductsCollectionManager qProductsCollectionManager, IQSuppliersCollectionManager qSuppliersCollectionManager, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, qCategoriesCollectionManager, qProductsCollectionManager, qSuppliersCollectionManager, screenCommandFactory)
        {
        }
    }
}
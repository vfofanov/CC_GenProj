using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class ProductsScreenViewModel : CodeBehind.CodeBehindProductsScreenViewModel
    {
        public ProductsScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		ICategoryQueryCollectionManager categoryQueryCollectionManager, IEntityManagementService entityManagementService, IProductQueryCollectionManager productQueryCollectionManager, IScreenCommandFactory screenCommandFactory, ISupplierQueryCollectionManager supplierQueryCollectionManager)
		    :base(categoryQueryCollectionManager, entityManagementService, productQueryCollectionManager, screenCommandFactory, supplierQueryCollectionManager)
        {
        }
    }
}
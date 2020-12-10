using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class SuppliersScreenViewModel : CodeBehind.CodeBehindSuppliersScreenViewModel
    {
        public SuppliersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory, ISupplierQueryCollectionManager supplierQueryCollectionManager)
		    :base(entityManagementService, screenCommandFactory, supplierQueryCollectionManager)
        {
        }
    }
}
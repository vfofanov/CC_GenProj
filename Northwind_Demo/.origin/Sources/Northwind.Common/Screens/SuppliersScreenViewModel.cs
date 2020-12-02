using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class SuppliersScreenViewModel : CodeBehind.CodeBehindSuppliersScreenViewModel
    {
        public SuppliersScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IQSuppliersCollectionManager qSuppliersCollectionManager, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, qSuppliersCollectionManager, screenCommandFactory)
        {
        }
    }
}
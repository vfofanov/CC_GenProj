using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Common.Screens
{
    public sealed class EmployeesScreenViewModel : CodeBehind.CodeBehindEmployeesScreenViewModel
    {
        public EmployeesScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IQEmployeesCollectionManager qEmployeesCollectionManager, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, qEmployeesCollectionManager, screenCommandFactory)
        {
        }
    }
}
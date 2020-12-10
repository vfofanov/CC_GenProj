using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class EmployeesScreenViewModel : CodeBehind.CodeBehindEmployeesScreenViewModel
    {
        public EmployeesScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEmployeeQueryCollectionManager employeeQueryCollectionManager, IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory)
		    :base(employeeQueryCollectionManager, entityManagementService, screenCommandFactory)
        {
        }
    }
}
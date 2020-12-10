using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class ChartsScreenViewModel : CodeBehind.CodeBehindChartsScreenViewModel
    {
        public ChartsScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		ICustomersCollectionManager customersCollectionManager)
		    :base(customersCollectionManager)
        {
        }
    }
}
using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Contracts.Services;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Common.Screens
{
    public sealed class RegionScreenViewModel : CodeBehind.CodeBehindRegionScreenViewModel
    {
        public RegionScreenViewModel(
		//--  custom dependencies
		//-- /custom dependencies
		IEntityManagementService entityManagementService, IRegionCollectionManager regionCollectionManager, IScreenCommandFactory screenCommandFactory)
		    :base(entityManagementService, regionCollectionManager, screenCommandFactory)
        {
        }
    }
}
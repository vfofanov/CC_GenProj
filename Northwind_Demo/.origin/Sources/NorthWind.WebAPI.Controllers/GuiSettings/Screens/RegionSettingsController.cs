using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using BusinessFramework.Contracts.GuiSettings.Actions;
using BusinessFramework.Contracts.GuiSettings.Fields;
using BusinessFramework.Contracts.GuiSettings.Json;
using BusinessFramework.Contracts.GuiSettings.Screens;
using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks;
using BusinessFramework.WebAPI.Common.GuiSettings;
using BusinessFramework.WebAPI.Common.Request;
using BusinessFramework.WebAPI.Common.Security;
using BusinessFramework.WebAPI.Contracts.Security;
using BusinessFramework.WebAPI.GuiSettingsControllers;
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Controllers.Properties;

// ReSharper disable UnusedParameter.Local

namespace NorthWind.WebAPI.Controllers.GuiSettings.Screens
{
    /// <summary>
    ///  Region screen settings controller
    /// </summary>
    public sealed class RegionSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public RegionSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Region' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.Region_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "region",
				Title = ScreenResources.Region_DisplayName,

                Content = GetScreenChildren(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private ScreenItem GetScreenChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "blockRegion1",
                    Actions = GetBlockRegion1Actions(),
				    Controller = "Region",
				    Content = GetBlockRegion1Content(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetBlockRegion1Content(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.Region_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(2);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Id", Key = DomainObjectPropertyKeys.Region.Id, DataType = FieldDataType.Integer},
				Title = ScreenResources.Region_blockRegion1_Id,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "RegionDescription", Key = DomainObjectPropertyKeys.Region.RegionDescription, DataType = FieldDataType.String},
				Title = ScreenResources.Region_blockRegion1_RegionDescription,                
				Sortable = true,
			});

		    return new GridDataBlockContent
			{
				WrapDataInGridCell = true,
			    PagingEnabled = true,
                ItemsOnPage = 100,
                Fields = fields.ToArray()

			};

        }
        
		private WorkActionItem[] GetBlockRegion1Actions()
        {
		    var actions = new List<WorkActionItem>(3);
            if (Security.AuthorizeAll(DomainPermissions.Region_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Region_blockRegion1_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1ActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Region_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Region_blockRegion1_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1CreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Region_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Region_blockRegion1_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1Edit1",
                });
            }
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

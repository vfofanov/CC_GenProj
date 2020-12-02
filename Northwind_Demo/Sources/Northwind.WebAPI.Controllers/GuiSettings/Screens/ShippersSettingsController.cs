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
using Northwind.Contracts;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Controllers.Properties;

// ReSharper disable UnusedParameter.Local

namespace Northwind.WebAPI.Controllers.GuiSettings.Screens
{
    /// <summary>
    ///  Shippers screen settings controller
    /// </summary>
    public sealed class ShippersSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public ShippersSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Shippers' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.QShippers_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "shippers",
				Title = ScreenResources.Shippers_DisplayName,

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
				    Controller = "QShippers",
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
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QShippers_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(2);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.QShippers.CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Shippers_blockRegion1_CompanyName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.QShippers.Phone, DataType = FieldDataType.String},
				Title = ScreenResources.Shippers_blockRegion1_Phone,                
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
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.Shipper_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Shippers_blockRegion1_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1CreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Shipper_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Shippers_blockRegion1_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1ActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Shipper_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Shippers_blockRegion1_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1Edit1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Shipper_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Shippers_blockRegion1_Delete1,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1Delete1",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Shippers_blockRegion1_Refresh1,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "blockRegion1Refresh1",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

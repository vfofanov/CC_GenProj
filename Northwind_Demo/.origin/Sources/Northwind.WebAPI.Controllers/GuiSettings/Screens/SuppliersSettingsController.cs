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
    ///  Suppliers screen settings controller
    /// </summary>
    public sealed class SuppliersSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public SuppliersSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Suppliers' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.QSuppliers_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "suppliers",
				Title = ScreenResources.Suppliers_DisplayName,

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
				    Controller = "QSuppliers",
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
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QSuppliers_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(11);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.QSuppliers.CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_CompanyName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.QSuppliers.ContactName, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_ContactName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.QSuppliers.ContactTitle, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_ContactTitle,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.QSuppliers.Address, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_Address,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.QSuppliers.City, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_City,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.QSuppliers.Region, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_Region,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.QSuppliers.PostalCode, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_PostalCode,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.QSuppliers.Country, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_Country,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.QSuppliers.Phone, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_Phone,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.QSuppliers.Fax, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_Fax,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "HomePage", Key = DomainObjectPropertyKeys.QSuppliers.HomePage, DataType = FieldDataType.String},
				Title = ScreenResources.Suppliers_blockRegion1_HomePage,                
				Sortable = true,
			});

		    return new GridDataBlockContent
			{
				WrapDataInGridCell = true,
			    HasQuickFilter = true,
			    PagingEnabled = true,
                ItemsOnPage = 100,
                Fields = fields.ToArray()

			};

        }
        
		private WorkActionItem[] GetBlockRegion1Actions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.Supplier_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Suppliers_blockRegion1_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1CreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Supplier_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Suppliers_blockRegion1_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1ActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Supplier_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Suppliers_blockRegion1_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1Edit1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Supplier_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Suppliers_blockRegion1_Delete1,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "blockRegion1Delete1",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Suppliers_blockRegion1_Refresh1,
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

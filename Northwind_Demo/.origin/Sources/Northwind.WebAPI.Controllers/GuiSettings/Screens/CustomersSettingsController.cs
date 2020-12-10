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
    ///  Customers screen settings controller
    /// </summary>
    public sealed class CustomersSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public CustomersSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Customers' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.CustomerQuery_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "customers",
				Title = ScreenResources.Customers_DisplayName,

                Content = GetScreenChildren(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private ScreenItem GetScreenChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qCustomers",
                    Actions = GetQCustomersActions(),
				    Controller = "CustomerQuery",
				    Content = GetQCustomersContent(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQCustomersContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.CustomerQuery_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(10);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.CustomerQuery.CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_CompanyName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.CustomerQuery.ContactName, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_ContactName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.CustomerQuery.ContactTitle, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_ContactTitle,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.CustomerQuery.Address, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_Address,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.CustomerQuery.City, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_City,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.CustomerQuery.Region, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_Region,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.CustomerQuery.PostalCode, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_PostalCode,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.CustomerQuery.Country, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_Country,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.CustomerQuery.Phone, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_Phone,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.CustomerQuery.Fax, DataType = FieldDataType.String},
				Title = ScreenResources.Customers_qCustomers_Fax,                
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
        
		private WorkActionItem[] GetQCustomersActions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.Customers_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Customers_qCustomers_WizardCreateNew,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCustomersWizardCreateNew",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Customers_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Customers_qCustomers_WizardView,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCustomersWizardView",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Customers_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Customers_qCustomers_WizardEdit,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCustomersWizardEdit",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Customers_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Customers_qCustomers_DeleteEntity,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCustomersDeleteEntity",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Customers_qCustomers_Refresh,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qCustomersRefresh",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

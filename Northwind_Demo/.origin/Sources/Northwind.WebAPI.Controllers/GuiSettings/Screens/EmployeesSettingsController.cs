﻿using System.Collections.Generic;
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
    ///  Employees screen settings controller
    /// </summary>
    public sealed class EmployeesSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public EmployeesSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Employees' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.EmployeeQuery_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "employees",
				Title = ScreenResources.Employees_DisplayName,

                Content = GetScreenChildren(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private ScreenItem GetScreenChildren(ScreenSettingsContext context)
        {
		        var item = new SplitContainer 
                {
				    Name = "splitContainer",
                    Orientation = SplitContainerOrientation.Vertical,
                    CollapsingPanel = SplitContainerPanel.Panel2,
                    FixedPanel = SplitContainerPanel.Panel2,
                    PanelsRatio =0.5d,
                    Panel1 = GetSplitContainer_Panel1Children(context),
		            Panel2 = GetSplitContainer_Panel2Children(context),
                };
				           
			    if (item.Panel1 != null && item.Panel2 != null)
				{
				    return item;
				}
                else if (item.Panel1 != null)
				{
				    return item.Panel1;
				}
				else if (item.Panel2 != null)
				{
				    return item.Panel2;
				}
            return null;
	    
        }
        
		private ScreenItem GetSplitContainer_Panel1Children(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qEmployees",
                    Actions = GetQEmployeesActions(),
				    Controller = "EmployeeQuery",
				    Content = GetQEmployeesContent(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQEmployeesContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.EmployeeQuery_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(6);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "LastName", Key = DomainObjectPropertyKeys.EmployeeQuery.LastName, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees_LastName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "FirstName", Key = DomainObjectPropertyKeys.EmployeeQuery.FirstName, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees_FirstName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "TitleOfCourtesy", Key = DomainObjectPropertyKeys.EmployeeQuery.TitleOfCourtesy, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees_TitleOfCourtesy,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Title", Key = DomainObjectPropertyKeys.EmployeeQuery.Title, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees_Title,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "BirthDate", Key = DomainObjectPropertyKeys.EmployeeQuery.BirthDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Employees_qEmployees_BirthDate,                
				Format = 3,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "HireDate", Key = DomainObjectPropertyKeys.EmployeeQuery.HireDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Employees_qEmployees_HireDate,                
				Format = 3,
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
        
		private ScreenItem GetSplitContainer_Panel2Children(ScreenSettingsContext context)
        {
		        var item = new TabLayout 
                {
				    Name = "tabControl",
				    Children = GetTabControlChildren(context),
                };
				           
			    if (item.Children != null)
				{
				    return item;
				}
            return null;
	    
        }
        
		private ScreenItem[] GetTabControlChildren(ScreenSettingsContext context)
        {
		        var item = new Tab 
                {
				    Name = "tabqEmployees",
				    Content = GetTabqEmployeesChildren(context),
				    Title = ScreenResources.Employees_tabqEmployees,
                };
				           
			    if (item.Content != null)
				{
				    return new ScreenItem[]{item};
				}
            return null;
	    
        }
        
		private ScreenItem GetTabqEmployeesChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qEmployees1",
				    Controller = "EmployeeQuery",
				    Content = GetQEmployees1Content(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qEmployees", ParentFields = new[] {"Id"}, Fields = new[] {"Id"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQEmployees1Content(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.EmployeeQuery_Read) && Security.AuthorizeAll(DomainPermissions.EmployeeQuery_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(9);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "DocumentScanFileId", Key = DomainObjectPropertyKeys.EmployeeQuery.DocumentScanFileId, DataType = FieldDataType.None},
				Title = ScreenResources.Employees_qEmployees1_DocumentScanFileId,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Photo", Key = DomainObjectPropertyKeys.EmployeeQuery.Photo, DataType = FieldDataType.Image},
				Title = ScreenResources.Employees_qEmployees1_Photo,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.EmployeeQuery.Address, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_Address,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.EmployeeQuery.City, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_City,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.EmployeeQuery.Region, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_Region,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.EmployeeQuery.PostalCode, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_PostalCode,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.EmployeeQuery.Country, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_Country,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "HomePhone", Key = DomainObjectPropertyKeys.EmployeeQuery.HomePhone, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_HomePhone,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Notes", Key = DomainObjectPropertyKeys.EmployeeQuery.Notes, DataType = FieldDataType.String},
				Title = ScreenResources.Employees_qEmployees1_Notes,
				LineCount = 1,    
				IsEndLine = true,       
			});
		    return new DetailsDataBlockContent
			{

			    Fields = fields.ToArray()
			};

        }
        
		private WorkActionItem[] GetQEmployeesActions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.Employees_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Employees_qEmployees_WizardCreateNew,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qEmployeesWizardCreateNew",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Employees_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Employees_qEmployees_WizardView,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qEmployeesWizardView",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Employees_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Employees_qEmployees_WizardEdit,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qEmployeesWizardEdit",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Employees_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Employees_qEmployees_DeleteEntity,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qEmployeesDeleteEntity",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Employees_qEmployees_Refresh,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qEmployeesRefresh",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

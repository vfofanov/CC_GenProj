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
    ///  Categories screen settings controller
    /// </summary>
    public sealed class CategoriesSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public CategoriesSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Categories' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.QCategories_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "categories",
				Title = ScreenResources.Categories_DisplayName,

                Content = GetScreenChildren(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private ScreenItem GetScreenChildren(ScreenSettingsContext context)
        {
		        var item = new SplitContainer 
                {
				    Name = "splitContainer1",
                    Orientation = SplitContainerOrientation.Vertical,
                    CollapsingPanel = SplitContainerPanel.Panel2,
                    FixedPanel = SplitContainerPanel.Panel2,
                    PanelsRatio =0.4d,
                    Panel1 = GetSplitContainer1_Panel1Children(context),
		            Panel2 = GetSplitContainer1_Panel2Children(context),
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
        
		private ScreenItem GetSplitContainer1_Panel1Children(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qCategories",
                    Actions = GetQCategoriesActions(),
				    Controller = "QCategories",
				    Content = GetQCategoriesContent(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQCategoriesContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QCategories_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(2);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "CategoryName", Key = DomainObjectPropertyKeys.QCategories.CategoryName, DataType = FieldDataType.String},
				Title = ScreenResources.Categories_qCategories_CategoryName,                
				Sortable = true,
				Width = 177.0,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Description", Key = DomainObjectPropertyKeys.QCategories.Description, DataType = FieldDataType.String},
				Title = ScreenResources.Categories_qCategories_Description,                
				Sortable = true,
				Width = 357.0,
			});

		    return new GridDataBlockContent
			{
				WrapDataInGridCell = true,
			    PagingEnabled = true,
                ItemsOnPage = 100,
                Fields = fields.ToArray()

			};

        }
        
		private ScreenItem GetSplitContainer1_Panel2Children(ScreenSettingsContext context)
        {
		        var item = new TabLayout 
                {
				    Name = "tabs1",
				    Children = GetTabs1Children(context),
                };
				           
			    if (item.Children != null)
				{
				    return item;
				}
            return null;
	    
        }
        
		private ScreenItem[] GetTabs1Children(ScreenSettingsContext context)
        {
		        var item = new Tab 
                {
				    Name = "tab1",
				    Content = GetTab1Children(context),
				    Title = ScreenResources.Categories_tab1,
                };
				           
			    if (item.Content != null)
				{
				    return new ScreenItem[]{item};
				}
            return null;
	    
        }
        
		private ScreenItem GetTab1Children(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qProducts",
                    Actions = GetQProductsActions(),
				    Controller = "QProducts",
				    Content = GetQProductsContent(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qCategories", ParentFields = new[] {"Id"}, Fields = new[] {"CategoryID"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQProductsContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QProducts_Read) && Security.AuthorizeAll(DomainPermissions.QCategories_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(3);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ProductName", Key = DomainObjectPropertyKeys.QProducts.ProductName, DataType = FieldDataType.String},
				Title = ScreenResources.Categories_qProducts_ProductName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "QuantityPerUnit", Key = DomainObjectPropertyKeys.QProducts.QuantityPerUnit, DataType = FieldDataType.String},
				Title = ScreenResources.Categories_qProducts_QuantityPerUnit,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.QProducts.UnitPrice, DataType = FieldDataType.Decimal},
				Title = ScreenResources.Categories_qProducts_UnitPrice,                
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
        
		private WorkActionItem[] GetQCategoriesActions()
        {
		    var actions = new List<WorkActionItem>(6);
            if (Security.AuthorizeAll(DomainPermissions.Category_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qCategories_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCategoriesCreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Category_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qCategories_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCategoriesActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Category_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qCategories_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCategoriesEdit1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Category_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qCategories_Delete1,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCategoriesDelete1",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Categories_qCategories_Refresh1,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qCategoriesRefresh1",
                Shortcut = ShortcutKey.F5,
            });
            if (Security.AuthorizeAll(DomainPermissions.QCategories_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qCategories_OpenReports1,
    			    Image = "action-open-report",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qCategoriesOpenReports1",
                });
            }
            return actions.Count != 0 ? actions.ToArray() : null;
        }

        
		private WorkActionItem[] GetQProductsActions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.Product_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qProducts_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsCreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Product_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qProducts_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Product_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qProducts_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsEdit1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Product_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Categories_qProducts_Delete1,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsDelete1",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Categories_qProducts_Refresh1,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qProductsRefresh1",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

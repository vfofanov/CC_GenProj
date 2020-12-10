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
    ///  Products screen settings controller
    /// </summary>
    public sealed class ProductsSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public ProductsSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Products' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.ProductQuery_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "products",
				Title = ScreenResources.Products_DisplayName,

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
				    Name = "qProducts",
                    Actions = GetQProductsActions(),
				    Controller = "ProductQuery",
				    Content = GetQProductsContent(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQProductsContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.ProductQuery_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(8);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Categories_CategoryName", Key = DomainObjectPropertyKeys.ProductQuery.Categories_CategoryName, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qProducts_Categories_CategoryName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ProductName", Key = DomainObjectPropertyKeys.ProductQuery.ProductName, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qProducts_ProductName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "QuantityPerUnit", Key = DomainObjectPropertyKeys.ProductQuery.QuantityPerUnit, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qProducts_QuantityPerUnit,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.ProductQuery.UnitPrice, DataType = FieldDataType.Decimal},
				Title = ScreenResources.Products_qProducts_UnitPrice,                
				Format = 1,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "UnitsInStock", Key = DomainObjectPropertyKeys.ProductQuery.UnitsInStock, DataType = FieldDataType.Integer},
				Title = ScreenResources.Products_qProducts_UnitsInStock,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "UnitsOnOrder", Key = DomainObjectPropertyKeys.ProductQuery.UnitsOnOrder, DataType = FieldDataType.Integer},
				Title = ScreenResources.Products_qProducts_UnitsOnOrder,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ReorderLevel", Key = DomainObjectPropertyKeys.ProductQuery.ReorderLevel, DataType = FieldDataType.Integer},
				Title = ScreenResources.Products_qProducts_ReorderLevel,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Discontinued", Key = DomainObjectPropertyKeys.ProductQuery.Discontinued, DataType = FieldDataType.Bool},
				Title = ScreenResources.Products_qProducts_Discontinued,                
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
		    var items = new List<ScreenItem>(2);

            #region tabqCategories
            {
		        var item = new Tab 
                {
				    Name = "tabqCategories",
				    Content = GetTabqCategoriesChildren(context),
				    Title = ScreenResources.Products_tabqCategories,
                };
				           
			    if (item.Content != null)
				{
				    items.Add(item);
				}
            }
			#endregion
            #region tabqSuppliers
            {
		        var item = new Tab 
                {
				    Name = "tabqSuppliers",
				    Content = GetTabqSuppliersChildren(context),
				    Title = ScreenResources.Products_tabqSuppliers,
                };
				           
			    if (item.Content != null)
				{
				    items.Add(item);
				}
            }
			#endregion
            return items.Count == 0 ? null : items.ToArray();
	    
        }
        
		private ScreenItem GetTabqCategoriesChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qCategories",
				    Controller = "CategoryQuery",
				    Content = GetQCategoriesContent(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qProducts", ParentFields = new[] {"CategoryID"}, Fields = new[] {"Id"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQCategoriesContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.CategoryQuery_Read) && Security.AuthorizeAll(DomainPermissions.ProductQuery_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(2);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "CategoryName", Key = DomainObjectPropertyKeys.CategoryQuery.CategoryName, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qCategories_CategoryName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Description", Key = DomainObjectPropertyKeys.CategoryQuery.Description, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qCategories_Description,
				LineCount = 1,    
				IsEndLine = true,       
			});
		    return new DetailsDataBlockContent
			{

			    Fields = fields.ToArray()
			};

        }
        
		private ScreenItem GetTabqSuppliersChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qSuppliers",
				    Controller = "SupplierQuery",
				    Content = GetQSuppliersContent(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qProducts", ParentFields = new[] {"SupplierID"}, Fields = new[] {"Id"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQSuppliersContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.SupplierQuery_Read) && Security.AuthorizeAll(DomainPermissions.ProductQuery_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(11);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.SupplierQuery.CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_CompanyName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.SupplierQuery.ContactName, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_ContactName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.SupplierQuery.ContactTitle, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_ContactTitle,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.SupplierQuery.Address, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_Address,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.SupplierQuery.City, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_City,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.SupplierQuery.Region, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_Region,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.SupplierQuery.PostalCode, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_PostalCode,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.SupplierQuery.Country, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_Country,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.SupplierQuery.Phone, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_Phone,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.SupplierQuery.Fax, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_Fax,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "HomePage", Key = DomainObjectPropertyKeys.SupplierQuery.HomePage, DataType = FieldDataType.String},
				Title = ScreenResources.Products_qSuppliers_HomePage,
				LineCount = 1,    
				IsEndLine = true,       
			});
		    return new DetailsDataBlockContent
			{

			    Fields = fields.ToArray()
			};

        }
        
		private WorkActionItem[] GetQProductsActions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.Products_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Products_qProducts_WizardCreateNew,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsWizardCreateNew",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Products_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Products_qProducts_WizardView,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsWizardView",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Products_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Products_qProducts_WizardEdit,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsWizardEdit",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Products_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Products_qProducts_DeleteEntity,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qProductsDeleteEntity",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Products_qProducts_Refresh,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qProductsRefresh",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

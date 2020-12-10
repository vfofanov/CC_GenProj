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
    ///  Orders screen settings controller
    /// </summary>
    public sealed class OrdersSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public OrdersSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Orders' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "orders",
				Title = ScreenResources.Orders_DisplayName,

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
                    PanelsRatio =0.5d,
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
				    Name = "qOrders",
                    Actions = GetQOrdersActions(),
				    Controller = "OrdersQuery",
				    Content = GetQOrdersContent(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQOrdersContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(8);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Id", Key = DomainObjectPropertyKeys.OrdersQuery.Id, DataType = FieldDataType.Integer},
				Title = ScreenResources.Orders_qOrders_Id,                
				Sortable = true,
				Sorting = Sorting.Descending,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "OrderDate", Key = DomainObjectPropertyKeys.OrdersQuery.OrderDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Orders_qOrders_OrderDate,                
				Format = 3,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "RequiredDate", Key = DomainObjectPropertyKeys.OrdersQuery.RequiredDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Orders_qOrders_RequiredDate,                
				Format = 3,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ShippedDate", Key = DomainObjectPropertyKeys.OrdersQuery.ShippedDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Orders_qOrders_ShippedDate,                
				Format = 3,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Freight", Key = DomainObjectPropertyKeys.OrdersQuery.Freight, DataType = FieldDataType.Decimal},
				Title = ScreenResources.Orders_qOrders_Freight,                
				Format = 1,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Customers_CompanyName", Key = DomainObjectPropertyKeys.OrdersQuery.Customers_CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrders_Customers_CompanyName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "EmployeeFullName", Key = DomainObjectPropertyKeys.OrdersQuery.EmployeeFullName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrders_EmployeeFullName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Shippers_CompanyName", Key = DomainObjectPropertyKeys.OrdersQuery.Shippers_CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrders_Shippers_CompanyName,                
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
        
		private ScreenItem GetSplitContainer1_Panel2Children(ScreenSettingsContext context)
        {
		        var item = new TabLayout 
                {
				    Name = "tabsControl",
				    Children = GetTabsControlChildren(context),
                };
				           
			    if (item.Children != null)
				{
				    return item;
				}
            return null;
	    
        }
        
		private ScreenItem[] GetTabsControlChildren(ScreenSettingsContext context)
        {
		    var items = new List<ScreenItem>(3);

            #region tabqOrders
            {
		        var item = new Tab 
                {
				    Name = "tabqOrders",
				    Content = GetTabqOrdersChildren(context),
				    Title = ScreenResources.Orders_tabqOrders,
                };
				           
			    if (item.Content != null)
				{
				    items.Add(item);
				}
            }
			#endregion
            #region tabqOrderProducts
            {
		        var item = new Tab 
                {
				    Name = "tabqOrderProducts",
				    Content = GetTabqOrderProductsChildren(context),
				    Title = ScreenResources.Orders_tabqOrderProducts,
                };
				           
			    if (item.Content != null)
				{
				    items.Add(item);
				}
            }
			#endregion
            #region tabqShippers
            {
		        var item = new Tab 
                {
				    Name = "tabqShippers",
				    Content = GetTabqShippersChildren(context),
				    Title = ScreenResources.Orders_tabqShippers,
                };
				           
			    if (item.Content != null)
				{
				    items.Add(item);
				}
            }
			#endregion
            return items.Count == 0 ? null : items.ToArray();
	    
        }
        
		private ScreenItem GetTabqOrdersChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "blockRegion1",
				    Controller = "OrdersQuery",
				    Content = GetBlockRegion1Content(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qOrders", ParentFields = new[] {"Id"}, Fields = new[] {"Id"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetBlockRegion1Content(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read) && Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(6);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipAddress", Key = DomainObjectPropertyKeys.OrdersQuery.ShipAddress, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipAddress,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipName", Key = DomainObjectPropertyKeys.OrdersQuery.ShipName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipCity", Key = DomainObjectPropertyKeys.OrdersQuery.ShipCity, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipCity,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipRegion", Key = DomainObjectPropertyKeys.OrdersQuery.ShipRegion, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipRegion,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipPostalCode", Key = DomainObjectPropertyKeys.OrdersQuery.ShipPostalCode, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipPostalCode,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipCountry", Key = DomainObjectPropertyKeys.OrdersQuery.ShipCountry, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipCountry,
				LineCount = 1,    
				IsEndLine = true,       
			});
		    return new DetailsDataBlockContent
			{

			    Fields = fields.ToArray()
			};

        }
        
		private ScreenItem GetTabqOrderProductsChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "qOrderProducts",
                    Actions = GetQOrderProductsActions(),
				    Controller = "OrderProductQuery",
				    Content = GetQOrderProductsContent(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qOrders", ParentFields = new[] {"Id"}, Fields = new[] {"OrderID"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetQOrderProductsContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.OrderProductQuery_Read) && Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(4);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Products_ProductName", Key = DomainObjectPropertyKeys.OrderProductQuery.Products_ProductName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrderProducts_Products_ProductName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.OrderProductQuery.UnitPrice, DataType = FieldDataType.Decimal},
				Title = ScreenResources.Orders_qOrderProducts_UnitPrice,                
				Format = 1,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Quantity", Key = DomainObjectPropertyKeys.OrderProductQuery.Quantity, DataType = FieldDataType.Integer},
				Title = ScreenResources.Orders_qOrderProducts_Quantity,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Discount", Key = DomainObjectPropertyKeys.OrderProductQuery.Discount, DataType = FieldDataType.Float},
				Title = ScreenResources.Orders_qOrderProducts_Discount,                
				Format = 1,
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
        
		private ScreenItem GetTabqShippersChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "shipperDetailRegion",
				    Controller = "ShipperQuery",
				    Content = GetShipperDetailRegionContent(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "qOrders", ParentFields = new[] {"ShipVia"}, Fields = new[] {"Id"}},
                    },
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetShipperDetailRegionContent(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.ShipperQuery_Read) && Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(2);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.ShipperQuery.CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_ShipperDetailRegion_CompanyName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.ShipperQuery.Phone, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_ShipperDetailRegion_Phone,
				LineCount = 1,    
				IsEndLine = true,       
			});
		    return new DetailsDataBlockContent
			{

			    Fields = fields.ToArray()
			};

        }
        
		private WorkActionItem[] GetQOrdersActions()
        {
		    var actions = new List<WorkActionItem>(7);
            if (Security.AuthorizeAll(DomainPermissions.Orders_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersCreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Orders_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Orders_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_Edit1MyButton,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersEdit1MyButton",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Orders_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_Delete1,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersDelete1",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Orders_qOrders_PrintOrderInvoice,
			    Image = "Printer",
				ClassName = "Printer",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qOrdersPrintOrderInvoice",
            });
            if (Security.AuthorizeAll(DomainPermissions.ReportFormQuery_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_ClientPrintWithWizardAction,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersClientPrintWithWizardAction",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Orders_qOrders_Refresh1,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qOrdersRefresh1",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

        
		private WorkActionItem[] GetQOrderProductsActions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.OrderDetails_Create))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrderProducts_CreateNew1,
    			    Image = "action-create-new",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrderProductsCreateNew1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.OrderDetails_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrderProducts_ActionView1,
    			    Image = "action-view",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrderProductsActionView1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.OrderDetails_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrderProducts_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrderProductsEdit1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.OrderDetails_Delete))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrderProducts_Delete1,
    			    Image = "action-delete",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrderProductsDelete1",
                });
            }
		    actions.Add(new WorkAction
            {
			    Title = ActionsResources.Orders_qOrderProducts_Refresh1,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qOrderProductsRefresh1",
                Shortcut = ShortcutKey.F5,
            });
            return actions.Count != 0 ? actions.ToArray() : null;
        }

    }
}

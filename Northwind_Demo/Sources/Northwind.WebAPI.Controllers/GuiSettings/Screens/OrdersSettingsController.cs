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
            if (!(Security.AuthorizeAll(DomainPermissions.QOrders_Read)))
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
				    Controller = "QOrders",
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
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QOrders_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(8);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Id", Key = DomainObjectPropertyKeys.QOrders.Id, DataType = FieldDataType.Integer},
				Title = ScreenResources.Orders_qOrders_Id,                
				Sortable = true,
				Sorting = Sorting.Descending,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "OrderDate", Key = DomainObjectPropertyKeys.QOrders.OrderDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Orders_qOrders_OrderDate,                
				Format = 2,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "RequiredDate", Key = DomainObjectPropertyKeys.QOrders.RequiredDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Orders_qOrders_RequiredDate,                
				Format = 2,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "ShippedDate", Key = DomainObjectPropertyKeys.QOrders.ShippedDate, DataType = FieldDataType.DateTime},
				Title = ScreenResources.Orders_qOrders_ShippedDate,                
				Format = 2,
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Freight", Key = DomainObjectPropertyKeys.QOrders.Freight, DataType = FieldDataType.Decimal},
				Title = ScreenResources.Orders_qOrders_Freight,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Customers_CompanyName", Key = DomainObjectPropertyKeys.QOrders.Customers_CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrders_Customers_CompanyName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "EmployeeFullName", Key = DomainObjectPropertyKeys.QOrders.EmployeeFullName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrders_EmployeeFullName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Shippers_CompanyName", Key = DomainObjectPropertyKeys.QOrders.Shippers_CompanyName, DataType = FieldDataType.String},
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
				    Controller = "QOrders",
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
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QOrders_Read) && Security.AuthorizeAll(DomainPermissions.QOrders_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(6);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipAddress", Key = DomainObjectPropertyKeys.QOrders.ShipAddress, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipAddress,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipName", Key = DomainObjectPropertyKeys.QOrders.ShipName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipCity", Key = DomainObjectPropertyKeys.QOrders.ShipCity, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipCity,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipRegion", Key = DomainObjectPropertyKeys.QOrders.ShipRegion, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipRegion,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipPostalCode", Key = DomainObjectPropertyKeys.QOrders.ShipPostalCode, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_blockRegion1_ShipPostalCode,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "ShipCountry", Key = DomainObjectPropertyKeys.QOrders.ShipCountry, DataType = FieldDataType.String},
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
				    Controller = "QOrderProducts",
				    Content = GetQOrderProductsContent(context),
                    Depends = new[]
                    {
                        new DataBlockDepend {Parent = "blockRegion1", ParentFields = new[] {"Id"}, Fields = new[] {"OrderID"}},
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
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QOrderProducts_Read) && Security.AuthorizeAll(DomainPermissions.QOrders_Read)))
            {
			    return null;
			}
            var fields = new List<GridDataBlockContentField>(4);            

            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Products_ProductName", Key = DomainObjectPropertyKeys.QOrderProducts.Products_ProductName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_qOrderProducts_Products_ProductName,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.QOrderProducts.UnitPrice, DataType = FieldDataType.Decimal},
				Title = ScreenResources.Orders_qOrderProducts_UnitPrice,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Quantity", Key = DomainObjectPropertyKeys.QOrderProducts.Quantity, DataType = FieldDataType.Integer},
				Title = ScreenResources.Orders_qOrderProducts_Quantity,                
				Sortable = true,
			});
            fields.Add(new GridDataBlockContentField
			{
			    Field = new Field {Name = "Discount", Key = DomainObjectPropertyKeys.QOrderProducts.Discount, DataType = FieldDataType.Float},
				Title = ScreenResources.Orders_qOrderProducts_Discount,                
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
				    Controller = "QShippers",
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
		    
            if (!(Security.AuthorizeAll(DomainPermissions.QShippers_Read) && Security.AuthorizeAll(DomainPermissions.QOrders_Read)))
            {
			    return null;
			}
            var fields = new List<DetailsDataBlockContentField>(2);

            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.QShippers.CompanyName, DataType = FieldDataType.String},
				Title = ScreenResources.Orders_ShipperDetailRegion_CompanyName,
				LineCount = 1,    
				IsEndLine = true,       
			});
            fields.Add(new DetailsDataBlockContentField
			{
			    Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.QShippers.Phone, DataType = FieldDataType.String},
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
            if (Security.AuthorizeAll(DomainPermissions.Order_Create))
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
            if (Security.AuthorizeAll(DomainPermissions.Order_Read))
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
            if (Security.AuthorizeAll(DomainPermissions.Order_Update))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_Edit1,
    			    Image = "action-edit",
    				ClassName = "default",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersEdit1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.Order_Delete))
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
			    Title = ActionsResources.Orders_qOrders_Refresh1,
			    Image = "action-refresh",
				ClassName = "default",
			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                ActionName = "qOrdersRefresh1",
                Shortcut = ShortcutKey.F5,
            });
            if (Security.AuthorizeAll(DomainPermissions.QOrders_Read))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_OpenReports1,
    			    Image = "action-open-report",
    				ClassName = "default",
    			    Position = WorkActionPosition.None,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersOpenReports1",
                });
            }
            if (Security.AuthorizeAll(DomainPermissions.PrintOrderInvoice_Execute))
		    {
    		    actions.Add(new WorkAction
                {
    			    Title = ActionsResources.Orders_qOrders_PrintOrderInvoice,
    			    Image = "Printer",
    				ClassName = "Printer",
    			    Position = WorkActionPosition.None | WorkActionPosition.Context | WorkActionPosition.Toolbar,
    			    ToolbarAlligement = WorkActionToolbarAlligement.Left,
                    ActionName = "qOrdersPrintOrderInvoice",
                });
            }
            return actions.Count != 0 ? actions.ToArray() : null;
        }

        
		private WorkActionItem[] GetQOrderProductsActions()
        {
		    var actions = new List<WorkActionItem>(5);
            if (Security.AuthorizeAll(DomainPermissions.OrderDetail_Create))
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
            if (Security.AuthorizeAll(DomainPermissions.OrderDetail_Read))
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
            if (Security.AuthorizeAll(DomainPermissions.OrderDetail_Update))
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
            if (Security.AuthorizeAll(DomainPermissions.OrderDetail_Delete))
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

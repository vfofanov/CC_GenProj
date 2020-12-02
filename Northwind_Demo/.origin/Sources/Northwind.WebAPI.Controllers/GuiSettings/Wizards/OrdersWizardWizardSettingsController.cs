using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using BusinessFramework.Contracts.GuiSettings.Fields;
using BusinessFramework.Contracts.GuiSettings.Json;
using BusinessFramework.Contracts.GuiSettings.Wizards;
using BusinessFramework.Contracts.GuiSettings.Wizards.Editors;
using BusinessFramework.WebAPI.Common.GuiSettings;
using BusinessFramework.WebAPI.Common.Request;
using BusinessFramework.WebAPI.Common.Security;
using BusinessFramework.WebAPI.Contracts.Security;
using BusinessFramework.WebAPI.GuiSettingsControllers;
using Northwind.Contracts;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Controllers.Properties;

// ReSharper disable UnusedParameter.Local

namespace Northwind.WebAPI.Controllers.GuiSettings.Wizards
{
    /// <summary>
    ///  OrdersWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class OrdersWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public OrdersWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'OrdersWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Order_Read, DomainPermissions.Order_Create, DomainPermissions.Order_Update)){ return GetInternalForbiddenResult(@"Order.Read(Order_Read), Order.Create(Order_Create), Order.Update(Order_Update)"); }
		    var context = new WizardSettingsContext();
            var result = new Wizard
            {
			    Items = GetWizardItems(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private WizardItem[] GetWizardItems(WizardSettingsContext context)
        {
		    var items = new List<WizardItem>(2);

            #region Page1
            {
		        var item = new WizardPage 
                {
				    Name = "page1",
					Title = WizardResources.OrdersWizard_Page1,
                    BannerTitle = WizardResources.OrdersWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.OrdersWizard_Page1_BannerDescription,
				    Editors = GetPage1Editors(context),
                };
				           
			    if (item.Editors != null)
				{
				    items.Add(item);
				}
            }
			#endregion
            #region Page2
            {
		        var item = new WizardPage 
                {
				    Name = "page2",
					Title = WizardResources.OrdersWizard_Page2,
                    BannerTitle = WizardResources.OrdersWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.OrdersWizard_Page2_BannerDescription,
				    Editors = GetPage2Editors(context),
                };
				           
			    if (item.Editors != null)
				{
				    items.Add(item);
				}
            }
			#endregion
	    
            return items.Count == 0 ? null : items.ToArray();
        }
        
		private WizardPageEditor[] GetPage1Editors(WizardSettingsContext context)
        {
		    var items = new List<WizardPageEditor>(4);

            // page1_OrderDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_OrderDate",
			    Title = WizardResources.OrdersWizard_Page1_OrderDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "OrderDate", Key = DomainObjectPropertyKeys.Order.OrderDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_CustomerID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_CustomerID",
			    Title = WizardResources.OrdersWizard_Page1_CustomerID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CustomerID", Key = DomainObjectPropertyKeys.Order.CustomerID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CompanyName",
            });
			
            // page1_EmployeeID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_EmployeeID",
			    Title = WizardResources.OrdersWizard_Page1_EmployeeID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "EmployeeID", Key = DomainObjectPropertyKeys.Order.EmployeeID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"Employee_FullName",
            });
			
            // page1_RequiredDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_RequiredDate",
			    Title = WizardResources.OrdersWizard_Page1_RequiredDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "RequiredDate", Key = DomainObjectPropertyKeys.Order.RequiredDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }
        
		private WizardPageEditor[] GetPage2Editors(WizardSettingsContext context)
        {
		    var items = new List<WizardPageEditor>(9);

            // page2_ShipVia
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page2_ShipVia",
			    Title = WizardResources.OrdersWizard_Page2_ShipVia_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipVia", Key = DomainObjectPropertyKeys.Order.ShipVia, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CompanyName",
            });
			
            // page2_ShippedDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page2_ShippedDate",
			    Title = WizardResources.OrdersWizard_Page2_ShippedDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShippedDate", Key = DomainObjectPropertyKeys.Order.ShippedDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page2_Freight
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page2_Freight",
			    Title = WizardResources.OrdersWizard_Page2_Freight_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Freight", Key = DomainObjectPropertyKeys.Order.Freight, DataType = FieldDataType.Decimal},
                Step = 1,
            });
			
            // page2_ShipName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipName",
			    Title = WizardResources.OrdersWizard_Page2_ShipName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipName", Key = DomainObjectPropertyKeys.Order.ShipName, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipAddress
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipAddress",
			    Title = WizardResources.OrdersWizard_Page2_ShipAddress_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipAddress", Key = DomainObjectPropertyKeys.Order.ShipAddress, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipCity
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipCity",
			    Title = WizardResources.OrdersWizard_Page2_ShipCity_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipCity", Key = DomainObjectPropertyKeys.Order.ShipCity, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipRegion
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipRegion",
			    Title = WizardResources.OrdersWizard_Page2_ShipRegion_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipRegion", Key = DomainObjectPropertyKeys.Order.ShipRegion, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipPostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipPostalCode",
			    Title = WizardResources.OrdersWizard_Page2_ShipPostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipPostalCode", Key = DomainObjectPropertyKeys.Order.ShipPostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipCountry
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipCountry",
			    Title = WizardResources.OrdersWizard_Page2_ShipCountry_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipCountry", Key = DomainObjectPropertyKeys.Order.ShipCountry, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

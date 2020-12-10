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
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Controllers.Properties;

// ReSharper disable UnusedParameter.Local

namespace NorthWind.WebAPI.Controllers.GuiSettings.Wizards
{
    /// <summary>
    ///  OrderWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public OrderWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'OrderWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Orders_Read, DomainPermissions.Orders_Create, DomainPermissions.Orders_Update)){ return GetInternalForbiddenResult(@"Orders.Read(Orders_Read), Orders.Create(Orders_Create), Orders.Update(Orders_Update)"); }
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
					Title = WizardResources.OrderWizard_Page1,
                    BannerTitle = WizardResources.OrderWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.OrderWizard_Page1_BannerDescription,
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
					Title = WizardResources.OrderWizard_Page2,
                    BannerTitle = WizardResources.OrderWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.OrderWizard_Page2_BannerDescription,
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
			    Title = WizardResources.OrderWizard_Page1_OrderDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "OrderDate", Key = DomainObjectPropertyKeys.Orders.OrderDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_CustomerID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_CustomerID",
			    Title = WizardResources.OrderWizard_Page1_CustomerID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CustomerID", Key = DomainObjectPropertyKeys.Orders.CustomerID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CompanyName",
                Validators = new [] 
				{
                    new Validator {Handler = "CustomerID_Required",Type = ValidatorType.Required, Message = ValidationResources.Orders_CustomerID_RequiredMsg},
				}
            });
			
            // page1_EmployeeID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_EmployeeID",
			    Title = WizardResources.OrderWizard_Page1_EmployeeID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "EmployeeID", Key = DomainObjectPropertyKeys.Orders.EmployeeID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"Employee_FullName",
            });
			
            // page1_RequiredDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_RequiredDate",
			    Title = WizardResources.OrderWizard_Page1_RequiredDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "RequiredDate", Key = DomainObjectPropertyKeys.Orders.RequiredDate, DataType = FieldDataType.DateTime},
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
			    Title = WizardResources.OrderWizard_Page2_ShipVia_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipVia", Key = DomainObjectPropertyKeys.Orders.ShipVia, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CompanyName",
            });
			
            // page2_ShippedDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page2_ShippedDate",
			    Title = WizardResources.OrderWizard_Page2_ShippedDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShippedDate", Key = DomainObjectPropertyKeys.Orders.ShippedDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page2_Freight
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page2_Freight",
			    Title = WizardResources.OrderWizard_Page2_Freight_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Freight", Key = DomainObjectPropertyKeys.Orders.Freight, DataType = FieldDataType.Decimal},
                Step = 1,
            });
			
            // page2_ShipName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipName",
			    Title = WizardResources.OrderWizard_Page2_ShipName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipName", Key = DomainObjectPropertyKeys.Orders.ShipName, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipAddress
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipAddress",
			    Title = WizardResources.OrderWizard_Page2_ShipAddress_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipAddress", Key = DomainObjectPropertyKeys.Orders.ShipAddress, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipCity
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipCity",
			    Title = WizardResources.OrderWizard_Page2_ShipCity_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipCity", Key = DomainObjectPropertyKeys.Orders.ShipCity, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipRegion
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipRegion",
			    Title = WizardResources.OrderWizard_Page2_ShipRegion_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipRegion", Key = DomainObjectPropertyKeys.Orders.ShipRegion, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipPostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipPostalCode",
			    Title = WizardResources.OrderWizard_Page2_ShipPostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipPostalCode", Key = DomainObjectPropertyKeys.Orders.ShipPostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_ShipCountry
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_ShipCountry",
			    Title = WizardResources.OrderWizard_Page2_ShipCountry_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ShipCountry", Key = DomainObjectPropertyKeys.Orders.ShipCountry, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

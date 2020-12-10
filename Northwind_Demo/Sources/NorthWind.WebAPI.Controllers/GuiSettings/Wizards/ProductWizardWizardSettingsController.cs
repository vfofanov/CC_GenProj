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
    ///  ProductWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class ProductWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public ProductWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'ProductWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Products_Read, DomainPermissions.Products_Create, DomainPermissions.Products_Update)){ return GetInternalForbiddenResult(@"Products.Read(Products_Read), Products.Create(Products_Create), Products.Update(Products_Update)"); }
		    var context = new WizardSettingsContext();
            var result = new Wizard
            {
			    Items = GetWizardItems(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private WizardItem[] GetWizardItems(WizardSettingsContext context)
        {
		    var items = new List<WizardItem>(1);

            #region Page1
            {
		        var item = new WizardPage 
                {
				    Name = "page1",
					Title = WizardResources.ProductWizard_Page1,
                    BannerTitle = WizardResources.ProductWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.ProductWizard_Page1_BannerDescription,
				    Editors = GetPage1Editors(context),
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
		    var items = new List<WizardPageEditor>(9);

            // page1_ProductName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ProductName",
			    Title = WizardResources.ProductWizard_Page1_ProductName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ProductName", Key = DomainObjectPropertyKeys.Products.ProductName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "ProductName_Required",Type = ValidatorType.Required, Message = ValidationResources.Products_ProductName_RequiredMsg},
				}
            });
			
            // page1_CategoryID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_CategoryID",
			    Title = WizardResources.ProductWizard_Page1_CategoryID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CategoryID", Key = DomainObjectPropertyKeys.Products.CategoryID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CategoryName",
            });
			
            // page1_QuantityPerUnit
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_QuantityPerUnit",
			    Title = WizardResources.ProductWizard_Page1_QuantityPerUnit_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "QuantityPerUnit", Key = DomainObjectPropertyKeys.Products.QuantityPerUnit, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_UnitPrice
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_UnitPrice",
			    Title = WizardResources.ProductWizard_Page1_UnitPrice_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.Products.UnitPrice, DataType = FieldDataType.Decimal},
                Step = 1,
            });
			
            // page1_UnitsInStock
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_UnitsInStock",
			    Title = WizardResources.ProductWizard_Page1_UnitsInStock_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "UnitsInStock", Key = DomainObjectPropertyKeys.Products.UnitsInStock, DataType = FieldDataType.Integer},
                Step = 1,
            });
			
            // page1_UnitsOnOrder
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_UnitsOnOrder",
			    Title = WizardResources.ProductWizard_Page1_UnitsOnOrder_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "UnitsOnOrder", Key = DomainObjectPropertyKeys.Products.UnitsOnOrder, DataType = FieldDataType.Integer},
                Step = 1,
            });
			
            // page1_ReorderLevel
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_ReorderLevel",
			    Title = WizardResources.ProductWizard_Page1_ReorderLevel_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ReorderLevel", Key = DomainObjectPropertyKeys.Products.ReorderLevel, DataType = FieldDataType.Integer},
                Step = 1,
            });
			
            // page1_Discontinued
            items.Add(new CheckWizardPageEditor 
            {
			    Name = "page1_Discontinued",
			    Title = WizardResources.ProductWizard_Page1_Discontinued_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Discontinued", Key = DomainObjectPropertyKeys.Products.Discontinued, DataType = FieldDataType.Bool},
                IsThreeState = false,
                Validators = new [] 
				{
                    new Validator {Handler = "Discontinued_Required",Type = ValidatorType.Required, Message = ValidationResources.Products_Discontinued_RequiredMsg},
				}
            });
			
            // page1_SupplierID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_SupplierID",
			    Title = WizardResources.ProductWizard_Page1_SupplierID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "SupplierID", Key = DomainObjectPropertyKeys.Products.SupplierID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CompanyName",
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

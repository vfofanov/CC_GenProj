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
    ///  SupplierWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class SupplierWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public SupplierWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'SupplierWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Suppliers_Read, DomainPermissions.Suppliers_Create, DomainPermissions.Suppliers_Update)){ return GetInternalForbiddenResult(@"Suppliers.Read(Suppliers_Read), Suppliers.Create(Suppliers_Create), Suppliers.Update(Suppliers_Update)"); }
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
					Title = WizardResources.SupplierWizard_Page1,
                    BannerTitle = WizardResources.SupplierWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.SupplierWizard_Page1_BannerDescription,
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
					Title = WizardResources.SupplierWizard_Page2,
                    BannerTitle = WizardResources.SupplierWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.SupplierWizard_Page2_BannerDescription,
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
		    var items = new List<WizardPageEditor>(3);

            // page1_CompanyName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_CompanyName",
			    Title = WizardResources.SupplierWizard_Page1_CompanyName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.Suppliers.CompanyName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "CompanyName_Required",Type = ValidatorType.Required, Message = ValidationResources.Suppliers_CompanyName_RequiredMsg},
				}
            });
			
            // page1_ContactName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactName",
			    Title = WizardResources.SupplierWizard_Page1_ContactName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.Suppliers.ContactName, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_ContactTitle
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactTitle",
			    Title = WizardResources.SupplierWizard_Page1_ContactTitle_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.Suppliers.ContactTitle, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }
        
		private WizardPageEditor[] GetPage2Editors(WizardSettingsContext context)
        {
		    var items = new List<WizardPageEditor>(8);

            // page2_Address
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Address",
			    Title = WizardResources.SupplierWizard_Page2_Address_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.Suppliers.Address, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_City
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_City",
			    Title = WizardResources.SupplierWizard_Page2_City_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.Suppliers.City, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Country
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Country",
			    Title = WizardResources.SupplierWizard_Page2_Country_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.Suppliers.Country, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Fax
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Fax",
			    Title = WizardResources.SupplierWizard_Page2_Fax_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.Suppliers.Fax, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_HomePage
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_HomePage",
			    Title = WizardResources.SupplierWizard_Page2_HomePage_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "HomePage", Key = DomainObjectPropertyKeys.Suppliers.HomePage, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Phone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Phone",
			    Title = WizardResources.SupplierWizard_Page2_Phone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.Suppliers.Phone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_PostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_PostalCode",
			    Title = WizardResources.SupplierWizard_Page2_PostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.Suppliers.PostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Region
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Region",
			    Title = WizardResources.SupplierWizard_Page2_Region_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.Suppliers.Region, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

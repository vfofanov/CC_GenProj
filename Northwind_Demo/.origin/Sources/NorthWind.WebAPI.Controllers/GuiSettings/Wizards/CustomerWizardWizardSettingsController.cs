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
    ///  CustomerWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomerWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public CustomerWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'CustomerWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Customers_Read, DomainPermissions.Customers_Create, DomainPermissions.Customers_Update)){ return GetInternalForbiddenResult(@"Customers.Read(Customers_Read), Customers.Create(Customers_Create), Customers.Update(Customers_Update)"); }
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
					Title = WizardResources.CustomerWizard_Page1,
                    BannerTitle = WizardResources.CustomerWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.CustomerWizard_Page1_BannerDescription,
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
					Title = WizardResources.CustomerWizard_Page2,
                    BannerTitle = WizardResources.CustomerWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.CustomerWizard_Page2_BannerDescription,
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
		    var items = new List<WizardPageEditor>(5);

            // page1_CompanyName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_CompanyName",
			    Title = WizardResources.CustomerWizard_Page1_CompanyName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.Customers.CompanyName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "CompanyName_Required",Type = ValidatorType.Required, Message = ValidationResources.Customers_CompanyName_RequiredMsg},
				}
            });
			
            // page1_ContactName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactName",
			    Title = WizardResources.CustomerWizard_Page1_ContactName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.Customers.ContactName, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_ContactTitle
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactTitle",
			    Title = WizardResources.CustomerWizard_Page1_ContactTitle_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.Customers.ContactTitle, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_Phone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Phone",
			    Title = WizardResources.CustomerWizard_Page1_Phone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.Customers.Phone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_Fax
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Fax",
			    Title = WizardResources.CustomerWizard_Page1_Fax_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.Customers.Fax, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }
        
		private WizardPageEditor[] GetPage2Editors(WizardSettingsContext context)
        {
		    var items = new List<WizardPageEditor>(5);

            // page2_Address
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Address",
			    Title = WizardResources.CustomerWizard_Page2_Address_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.Customers.Address, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_City
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_City",
			    Title = WizardResources.CustomerWizard_Page2_City_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.Customers.City, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Region
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Region",
			    Title = WizardResources.CustomerWizard_Page2_Region_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.Customers.Region, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_PostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_PostalCode",
			    Title = WizardResources.CustomerWizard_Page2_PostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.Customers.PostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Country
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Country",
			    Title = WizardResources.CustomerWizard_Page2_Country_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.Customers.Country, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

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
    ///  CustomerCompactWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomerCompactWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public CustomerCompactWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'CustomerCompactWizard' wizard
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
		    var items = new List<WizardItem>(1);

            #region Page1
            {
		        var item = new WizardPage 
                {
				    Name = "page1",
					Title = WizardResources.CustomerCompactWizard_Page1,
                    BannerTitle = WizardResources.CustomerCompactWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.CustomerCompactWizard_Page1_BannerDescription,
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
		    var items = new List<WizardPageEditor>(5);

            // page1_CompanyName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_CompanyName",
			    Title = WizardResources.CustomerCompactWizard_Page1_CompanyName_DisplayName,
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
			    Title = WizardResources.CustomerCompactWizard_Page1_ContactName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.Customers.ContactName, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_ContactTitle
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactTitle",
			    Title = WizardResources.CustomerCompactWizard_Page1_ContactTitle_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.Customers.ContactTitle, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_Phone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Phone",
			    Title = WizardResources.CustomerCompactWizard_Page1_Phone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.Customers.Phone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_Fax
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Fax",
			    Title = WizardResources.CustomerCompactWizard_Page1_Fax_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.Customers.Fax, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

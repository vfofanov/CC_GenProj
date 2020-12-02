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
    ///  SuppliersWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class SuppliersWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public SuppliersWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'SuppliersWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Supplier_Read, DomainPermissions.Supplier_Create, DomainPermissions.Supplier_Update)){ return GetInternalForbiddenResult(@"Supplier.Read(Supplier_Read), Supplier.Create(Supplier_Create), Supplier.Update(Supplier_Update)"); }
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
					Title = WizardResources.SuppliersWizard_Page1,
                    BannerTitle = WizardResources.SuppliersWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.SuppliersWizard_Page1_BannerDescription,
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
					Title = WizardResources.SuppliersWizard_Page2,
                    BannerTitle = WizardResources.SuppliersWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.SuppliersWizard_Page2_BannerDescription,
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
			    Title = WizardResources.SuppliersWizard_Page1_CompanyName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.Supplier.CompanyName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "CompanyName_Required",Type = ValidatorType.Required, Message = ValidationResources.Supplier_CompanyName_RequiredMsg},
				}
            });
			
            // page1_ContactName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactName",
			    Title = WizardResources.SuppliersWizard_Page1_ContactName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactName", Key = DomainObjectPropertyKeys.Supplier.ContactName, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_ContactTitle
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_ContactTitle",
			    Title = WizardResources.SuppliersWizard_Page1_ContactTitle_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ContactTitle", Key = DomainObjectPropertyKeys.Supplier.ContactTitle, DataType = FieldDataType.String},
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
			    Title = WizardResources.SuppliersWizard_Page2_Address_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.Supplier.Address, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_City
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_City",
			    Title = WizardResources.SuppliersWizard_Page2_City_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.Supplier.City, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Country
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Country",
			    Title = WizardResources.SuppliersWizard_Page2_Country_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.Supplier.Country, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Fax
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Fax",
			    Title = WizardResources.SuppliersWizard_Page2_Fax_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Fax", Key = DomainObjectPropertyKeys.Supplier.Fax, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_HomePage
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_HomePage",
			    Title = WizardResources.SuppliersWizard_Page2_HomePage_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "HomePage", Key = DomainObjectPropertyKeys.Supplier.HomePage, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Phone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Phone",
			    Title = WizardResources.SuppliersWizard_Page2_Phone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.Supplier.Phone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_PostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_PostalCode",
			    Title = WizardResources.SuppliersWizard_Page2_PostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.Supplier.PostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Region
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Region",
			    Title = WizardResources.SuppliersWizard_Page2_Region_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.Supplier.Region, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

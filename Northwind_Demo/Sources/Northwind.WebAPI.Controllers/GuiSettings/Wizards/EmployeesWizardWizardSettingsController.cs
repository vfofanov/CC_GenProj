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
    ///  EmployeesWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class EmployeesWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public EmployeesWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'EmployeesWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Employee_Read, DomainPermissions.Employee_Create, DomainPermissions.Employee_Update)){ return GetInternalForbiddenResult(@"Employee.Read(Employee_Read), Employee.Create(Employee_Create), Employee.Update(Employee_Update)"); }
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
					Title = WizardResources.EmployeesWizard_Page1,
                    BannerTitle = WizardResources.EmployeesWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.EmployeesWizard_Page1_BannerDescription,
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
					Title = WizardResources.EmployeesWizard_Page2,
                    BannerTitle = WizardResources.EmployeesWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.EmployeesWizard_Page2_BannerDescription,
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
		    var items = new List<WizardPageEditor>(8);

            // page1_LastName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_LastName",
			    Title = WizardResources.EmployeesWizard_Page1_LastName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "LastName", Key = DomainObjectPropertyKeys.Employee.LastName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "LastName_Required",Type = ValidatorType.Required, Message = ValidationResources.Employee_LastName_RequiredMsg},
				}
            });
			
            // page1_FirstName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_FirstName",
			    Title = WizardResources.EmployeesWizard_Page1_FirstName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "FirstName", Key = DomainObjectPropertyKeys.Employee.FirstName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "FirstName_Required",Type = ValidatorType.Required, Message = ValidationResources.Employee_FirstName_RequiredMsg},
				}
            });
			
            // page1_Title
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Title",
			    Title = WizardResources.EmployeesWizard_Page1_Title_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Title", Key = DomainObjectPropertyKeys.Employee.Title, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_TitleOfCourtesy
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_TitleOfCourtesy",
			    Title = WizardResources.EmployeesWizard_Page1_TitleOfCourtesy_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "TitleOfCourtesy", Key = DomainObjectPropertyKeys.Employee.TitleOfCourtesy, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_BirthDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_BirthDate",
			    Title = WizardResources.EmployeesWizard_Page1_BirthDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "BirthDate", Key = DomainObjectPropertyKeys.Employee.BirthDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_HireDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_HireDate",
			    Title = WizardResources.EmployeesWizard_Page1_HireDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "HireDate", Key = DomainObjectPropertyKeys.Employee.HireDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_Photo
            items.Add(new PictureWizardPageEditor 
            {
			    Name = "page1_Photo",
			    Title = WizardResources.EmployeesWizard_Page1_Photo_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Photo", Key = DomainObjectPropertyKeys.Employee.Photo, DataType = FieldDataType.Image},
            });
			
            // page1_Notes
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Notes",
			    Title = WizardResources.EmployeesWizard_Page1_Notes_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Notes", Key = DomainObjectPropertyKeys.Employee.Notes, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }
        
		private WizardPageEditor[] GetPage2Editors(WizardSettingsContext context)
        {
		    var items = new List<WizardPageEditor>(6);

            // page2_Address
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Address",
			    Title = WizardResources.EmployeesWizard_Page2_Address_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.Employee.Address, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_City
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_City",
			    Title = WizardResources.EmployeesWizard_Page2_City_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.Employee.City, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Region
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Region",
			    Title = WizardResources.EmployeesWizard_Page2_Region_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.Employee.Region, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_PostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_PostalCode",
			    Title = WizardResources.EmployeesWizard_Page2_PostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.Employee.PostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Country
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Country",
			    Title = WizardResources.EmployeesWizard_Page2_Country_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.Employee.Country, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_HomePhone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_HomePhone",
			    Title = WizardResources.EmployeesWizard_Page2_HomePhone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "HomePhone", Key = DomainObjectPropertyKeys.Employee.HomePhone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

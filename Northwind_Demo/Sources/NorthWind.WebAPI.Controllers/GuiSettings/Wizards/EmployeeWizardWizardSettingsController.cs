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
    ///  EmployeeWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class EmployeeWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public EmployeeWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'EmployeeWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Employees_Read, DomainPermissions.Employees_Create, DomainPermissions.Employees_Update)){ return GetInternalForbiddenResult(@"Employees.Read(Employees_Read), Employees.Create(Employees_Create), Employees.Update(Employees_Update)"); }
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
					Title = WizardResources.EmployeeWizard_Page1,
                    BannerTitle = WizardResources.EmployeeWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.EmployeeWizard_Page1_BannerDescription,
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
					Title = WizardResources.EmployeeWizard_Page2,
                    BannerTitle = WizardResources.EmployeeWizard_Page2_BannerTitle,
					BannerDescription = WizardResources.EmployeeWizard_Page2_BannerDescription,
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
		    var items = new List<WizardPageEditor>(9);

            // page1_LastName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_LastName",
			    Title = WizardResources.EmployeeWizard_Page1_LastName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "LastName", Key = DomainObjectPropertyKeys.Employees.LastName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "LastName_Required",Type = ValidatorType.Required, Message = ValidationResources.Employees_LastName_RequiredMsg},
				}
            });
			
            // page1_FirstName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_FirstName",
			    Title = WizardResources.EmployeeWizard_Page1_FirstName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "FirstName", Key = DomainObjectPropertyKeys.Employees.FirstName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "FirstName_Required",Type = ValidatorType.Required, Message = ValidationResources.Employees_FirstName_RequiredMsg},
				}
            });
			
            // page1_Title
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Title",
			    Title = WizardResources.EmployeeWizard_Page1_Title_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Title", Key = DomainObjectPropertyKeys.Employees.Title, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_TitleOfCourtesy
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_TitleOfCourtesy",
			    Title = WizardResources.EmployeeWizard_Page1_TitleOfCourtesy_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "TitleOfCourtesy", Key = DomainObjectPropertyKeys.Employees.TitleOfCourtesy, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_BirthDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_BirthDate",
			    Title = WizardResources.EmployeeWizard_Page1_BirthDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "BirthDate", Key = DomainObjectPropertyKeys.Employees.BirthDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_HireDate
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_HireDate",
			    Title = WizardResources.EmployeeWizard_Page1_HireDate_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "HireDate", Key = DomainObjectPropertyKeys.Employees.HireDate, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_Photo
            items.Add(new PictureWizardPageEditor 
            {
			    Name = "page1_Photo",
			    Title = WizardResources.EmployeeWizard_Page1_Photo_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Photo", Key = DomainObjectPropertyKeys.Employees.Photo, DataType = FieldDataType.Image},
            });
			
            // page1_Notes
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Notes",
			    Title = WizardResources.EmployeeWizard_Page1_Notes_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Notes", Key = DomainObjectPropertyKeys.Employees.Notes, DataType = FieldDataType.String},
                MaxLength = null,
                IsMultiline = true,
                LineCount = 5,
            });
			
            // page1_DocumentScanFileId
            items.Add(new PictureWizardPageEditor 
            {
			    Name = "page1_DocumentScanFileId",
			    Title = WizardResources.EmployeeWizard_Page1_DocumentScanFileId_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "DocumentScanFileId", Key = DomainObjectPropertyKeys.Employees.DocumentScanFileId, DataType = FieldDataType.None},
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
			    Title = WizardResources.EmployeeWizard_Page2_Address_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Address", Key = DomainObjectPropertyKeys.Employees.Address, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_City
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_City",
			    Title = WizardResources.EmployeeWizard_Page2_City_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "City", Key = DomainObjectPropertyKeys.Employees.City, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Region
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Region",
			    Title = WizardResources.EmployeeWizard_Page2_Region_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Region", Key = DomainObjectPropertyKeys.Employees.Region, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_PostalCode
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_PostalCode",
			    Title = WizardResources.EmployeeWizard_Page2_PostalCode_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "PostalCode", Key = DomainObjectPropertyKeys.Employees.PostalCode, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_Country
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_Country",
			    Title = WizardResources.EmployeeWizard_Page2_Country_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Country", Key = DomainObjectPropertyKeys.Employees.Country, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page2_HomePhone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page2_HomePhone",
			    Title = WizardResources.EmployeeWizard_Page2_HomePhone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "HomePhone", Key = DomainObjectPropertyKeys.Employees.HomePhone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

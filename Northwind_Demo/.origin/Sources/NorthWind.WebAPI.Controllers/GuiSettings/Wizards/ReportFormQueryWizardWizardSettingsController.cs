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
    ///  ReportFormQueryWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class ReportFormQueryWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public ReportFormQueryWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'ReportFormQueryWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.ReportFormQuery_Read, DomainPermissions.ReportFormQuery_Create)){ return GetInternalForbiddenResult(@"ReportFormQuery.Read(ReportFormQuery_Read), ReportFormQuery.Create(ReportFormQuery_Create)"); }
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
					Title = WizardResources.ReportFormQueryWizard_Page1,
                    BannerTitle = WizardResources.ReportFormQueryWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.ReportFormQueryWizard_Page1_BannerDescription,
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

            // page1_EmployeeId
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_EmployeeId",
			    Title = WizardResources.ReportFormQueryWizard_Page1_EmployeeId_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "EmployeeId", Key = DomainObjectPropertyKeys.ReportFormQuery.EmployeeId, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"FirstName",
            });
			
            // page1_CustomerId
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_CustomerId",
			    Title = WizardResources.ReportFormQueryWizard_Page1_CustomerId_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CustomerId", Key = DomainObjectPropertyKeys.ReportFormQuery.CustomerId, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"CompanyName",
            });
			
            // page1_From
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_From",
			    Title = WizardResources.ReportFormQueryWizard_Page1_From_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "From", Key = DomainObjectPropertyKeys.ReportFormQuery.From, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_To
            items.Add(new DateTimeWizardPageEditor 
            {
			    Name = "page1_To",
			    Title = WizardResources.ReportFormQueryWizard_Page1_To_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "To", Key = DomainObjectPropertyKeys.ReportFormQuery.To, DataType = FieldDataType.DateTime},
                EditType = DateTimeWizardPageEditorType.Date,
            });
			
            // page1_useExcel
            items.Add(new CheckWizardPageEditor 
            {
			    Name = "page1_useExcel",
			    Title = WizardResources.ReportFormQueryWizard_Page1_useExcel_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "useExcel", Key = DomainObjectPropertyKeys.ReportFormQuery.useExcel, DataType = FieldDataType.Bool},
                IsThreeState = false,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

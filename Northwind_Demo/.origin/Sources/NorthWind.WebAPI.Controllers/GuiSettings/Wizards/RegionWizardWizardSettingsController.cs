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
    ///  RegionWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class RegionWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public RegionWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'RegionWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Region_Read, DomainPermissions.Region_Create, DomainPermissions.Region_Update)){ return GetInternalForbiddenResult(@"Region.Read(Region_Read), Region.Create(Region_Create), Region.Update(Region_Update)"); }
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
					Title = WizardResources.RegionWizard_Page1,
                    BannerTitle = WizardResources.RegionWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.RegionWizard_Page1_BannerDescription,
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
		    var items = new List<WizardPageEditor>(2);

            // page1_Id
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_Id",
			    Title = WizardResources.RegionWizard_Page1_Id_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Id", Key = DomainObjectPropertyKeys.Region.Id, DataType = FieldDataType.Integer},
                Step = 1,
                Validators = new [] 
				{
                    new Validator {Handler = "Id_Required",Type = ValidatorType.Required, Message = ValidationResources.Region_Id_RequiredMsg},
				}
            });
			
            // page1_RegionDescription
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_RegionDescription",
			    Title = WizardResources.RegionWizard_Page1_RegionDescription_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "RegionDescription", Key = DomainObjectPropertyKeys.Region.RegionDescription, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "RegionDescription_Required",Type = ValidatorType.Required, Message = ValidationResources.Region_RegionDescription_RequiredMsg},
				}
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

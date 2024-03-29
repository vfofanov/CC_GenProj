﻿using System.Collections.Generic;
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
    ///  ShipperWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class ShipperWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public ShipperWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'ShipperWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Shippers_Read, DomainPermissions.Shippers_Create, DomainPermissions.Shippers_Update)){ return GetInternalForbiddenResult(@"Shippers.Read(Shippers_Read), Shippers.Create(Shippers_Create), Shippers.Update(Shippers_Update)"); }
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
					Title = WizardResources.ShipperWizard_Page1,
                    BannerTitle = WizardResources.ShipperWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.ShipperWizard_Page1_BannerDescription,
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

            // page1_CompanyName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_CompanyName",
			    Title = WizardResources.ShipperWizard_Page1_CompanyName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.Shippers.CompanyName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "CompanyName_Required",Type = ValidatorType.Required, Message = ValidationResources.Shippers_CompanyName_RequiredMsg},
				}
            });
			
            // page1_Phone
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Phone",
			    Title = WizardResources.ShipperWizard_Page1_Phone_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Phone", Key = DomainObjectPropertyKeys.Shippers.Phone, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

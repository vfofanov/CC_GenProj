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
    ///  CategoriesWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class CategoriesWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public CategoriesWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'CategoriesWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.Category_Read, DomainPermissions.Category_Create, DomainPermissions.Category_Update)){ return GetInternalForbiddenResult(@"Category.Read(Category_Read), Category.Create(Category_Create), Category.Update(Category_Update)"); }
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
					Title = WizardResources.CategoriesWizard_Page1,
                    BannerTitle = WizardResources.CategoriesWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.CategoriesWizard_Page1_BannerDescription,
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
		    var items = new List<WizardPageEditor>(3);

            // page1_CategoryName
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_CategoryName",
			    Title = WizardResources.CategoriesWizard_Page1_CategoryName_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "CategoryName", Key = DomainObjectPropertyKeys.Category.CategoryName, DataType = FieldDataType.String},
                MaxLength = null,
                Validators = new [] 
				{
                    new Validator {Handler = "CategoryName_Required",Type = ValidatorType.Required, Message = ValidationResources.Category_CategoryName_RequiredMsg},
				}
            });
			
            // page1_Description
            items.Add(new TextWizardPageEditor 
            {
			    Name = "page1_Description",
			    Title = WizardResources.CategoriesWizard_Page1_Description_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Description", Key = DomainObjectPropertyKeys.Category.Description, DataType = FieldDataType.String},
                MaxLength = null,
            });
			
            // page1_Picture
            items.Add(new PictureWizardPageEditor 
            {
			    Name = "page1_Picture",
			    Title = WizardResources.CategoriesWizard_Page1_Picture_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Picture", Key = DomainObjectPropertyKeys.Category.Picture, DataType = FieldDataType.Image},
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

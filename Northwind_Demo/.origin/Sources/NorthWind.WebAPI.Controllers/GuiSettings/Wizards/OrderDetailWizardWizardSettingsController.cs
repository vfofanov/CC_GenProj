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
    ///  OrderDetailWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderDetailWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public OrderDetailWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'OrderDetailWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.OrderDetails_Read, DomainPermissions.OrderDetails_Create, DomainPermissions.OrderDetails_Update)){ return GetInternalForbiddenResult(@"OrderDetails.Read(OrderDetails_Read), OrderDetails.Create(OrderDetails_Create), OrderDetails.Update(OrderDetails_Update)"); }
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
					Title = WizardResources.OrderDetailWizard_Page1,
                    BannerTitle = WizardResources.OrderDetailWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.OrderDetailWizard_Page1_BannerDescription,
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
		    var items = new List<WizardPageEditor>(4);

            // page1_ProductID
            items.Add(new ComboBoxWizardPageEditor 
            {
			    Name = "page1_ProductID",
			    Title = WizardResources.OrderDetailWizard_Page1_ProductID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ProductID", Key = DomainObjectPropertyKeys.OrderDetails.ProductID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"ProductName",
                Validators = new [] 
				{
                    new Validator {Handler = "ProductID_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetails_ProductID_RequiredMsg},
				}
            });
			
            // page1_UnitPrice
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_UnitPrice",
			    Title = WizardResources.OrderDetailWizard_Page1_UnitPrice_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.OrderDetails.UnitPrice, DataType = FieldDataType.Decimal},
                Step = 0.01,
                Currency = @"us-dollar",
                Validators = new [] 
				{
                    new Validator {Handler = "UnitPrice_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetails_UnitPrice_RequiredMsg},
				}
            });
			
            // page1_Quantity
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_Quantity",
			    Title = WizardResources.OrderDetailWizard_Page1_Quantity_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Quantity", Key = DomainObjectPropertyKeys.OrderDetails.Quantity, DataType = FieldDataType.Integer},
                Step = 1,
                Validators = new [] 
				{
                    new Validator {Handler = "Quantity_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetails_Quantity_RequiredMsg},
				}
            });
			
            // page1_Discount
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_Discount",
			    Title = WizardResources.OrderDetailWizard_Page1_Discount_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Discount", Key = DomainObjectPropertyKeys.OrderDetails.Discount, DataType = FieldDataType.Float},
                Step = 2,
                Validators = new [] 
				{
                    new Validator {Handler = "Discount_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetails_Discount_RequiredMsg},
				}
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

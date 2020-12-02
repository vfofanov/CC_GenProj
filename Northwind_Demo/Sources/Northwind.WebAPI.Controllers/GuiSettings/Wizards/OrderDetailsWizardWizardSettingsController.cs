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
    ///  OrderDetailsWizard wizard settings controller
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderDetailsWizardWizardSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public OrderDetailsWizardWizardSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'OrderDetailsWizard' wizard
        /// </summary>
        /// <returns></returns>
		public IHttpActionResult Get()
        {
            if(!Security.AuthorizeAny(DomainPermissions.OrderDetail_Read, DomainPermissions.OrderDetail_Create, DomainPermissions.OrderDetail_Update)){ return GetInternalForbiddenResult(@"Order detail.Read(OrderDetail_Read), Order detail.Create(OrderDetail_Create), Order detail.Update(OrderDetail_Update)"); }
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
					Title = WizardResources.OrderDetailsWizard_Page1,
                    BannerTitle = WizardResources.OrderDetailsWizard_Page1_BannerTitle,
					BannerDescription = WizardResources.OrderDetailsWizard_Page1_BannerDescription,
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
			    Title = WizardResources.OrderDetailsWizard_Page1_ProductID_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "ProductID", Key = DomainObjectPropertyKeys.OrderDetail.ProductID, DataType = FieldDataType.Integer},
                ValueField = @"Id",
                DisplayField = @"ProductName",
                Validators = new [] 
				{
                    new Validator {Handler = "ProductID_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetail_ProductID_RequiredMsg},
				}
            });
			
            // page1_UnitPrice
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_UnitPrice",
			    Title = WizardResources.OrderDetailsWizard_Page1_UnitPrice_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "UnitPrice", Key = DomainObjectPropertyKeys.OrderDetail.UnitPrice, DataType = FieldDataType.Decimal},
                Step = 0.01,
                Currency = @"us-dollar",
                Validators = new [] 
				{
                    new Validator {Handler = "UnitPrice_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetail_UnitPrice_RequiredMsg},
				}
            });
			
            // page1_Quantity
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_Quantity",
			    Title = WizardResources.OrderDetailsWizard_Page1_Quantity_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Quantity", Key = DomainObjectPropertyKeys.OrderDetail.Quantity, DataType = FieldDataType.Integer},
                Step = 1,
                Validators = new [] 
				{
                    new Validator {Handler = "Quantity_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetail_Quantity_RequiredMsg},
				}
            });
			
            // page1_Discount
            items.Add(new NumericWizardPageEditor 
            {
			    Name = "page1_Discount",
			    Title = WizardResources.OrderDetailsWizard_Page1_Discount_DisplayName,
				ReadOnly = false,
				IsEndLine = true,
                Field = new Field {Name = "Discount", Key = DomainObjectPropertyKeys.OrderDetail.Discount, DataType = FieldDataType.Float},
                Step = 2,
                Validators = new [] 
				{
                    new Validator {Handler = "Discount_Required",Type = ValidatorType.Required, Message = ValidationResources.OrderDetail_Discount_RequiredMsg},
				}
            });
			
	    
            return items.Count == 0 ? null : items.ToArray();
        }

    }
}

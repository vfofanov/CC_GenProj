using System.Collections.Generic;
using System.Web.Http.Results;
using BusinessFramework.Contracts.GuiSettings.Actions;
using BusinessFramework.Contracts.GuiSettings.Fields;
using BusinessFramework.Contracts.GuiSettings.Json;
using BusinessFramework.Contracts.GuiSettings.MainMenu;
using BusinessFramework.Contracts.GuiSettings.Screens;
using BusinessFramework.WebAPI.Common.Request;
using BusinessFramework.WebAPI.Contracts.Security;
using BusinessFramework.WebAPI.GuiSettingsControllers;
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Controllers.Properties;


namespace NorthWind.WebAPI.Controllers.GuiSettings
{
    /// <summary>
    ///  Main menu gui settings controller
    /// </summary>
    public sealed class MainMenuSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public MainMenuSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for main menu
        /// </summary>
        /// <returns></returns>
        public JsonResult<MainMenuSettings> Get()
        {
            var result = new MainMenuSettings();
            var groups = new List<MainMenuScreenGroupSettings>(4);
            var screens = new List<MainMenuScreenSettings>();
			           
            #region Orders
            if (Security.AuthorizeAll(DomainPermissions.CustomerQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Customers",
								Title = ScreenResources.Customers_DisplayName,
								Controller = "CustomersSettings",
                                Hidden = false,
								Image = "Customers"
							});
            }
            if (Security.AuthorizeAll(DomainPermissions.ShipperQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Shippers",
								Title = ScreenResources.Shippers_DisplayName,
								Controller = "ShippersSettings",
                                Hidden = false,
								Image = "Shippers"
							});
            }
            if (Security.AuthorizeAll(DomainPermissions.OrdersQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Orders",
								Title = ScreenResources.Orders_DisplayName,
								Controller = "OrdersSettings",
                                Hidden = false,
								Image = "Orders"
							});
            }
            if (screens.Count != 0)
            {
                groups.Add(new MainMenuScreenGroupSettings
                {
				    Name = "Orders",
                    Title = ScreenGroupResources.Orders_DisplayName,
                    Color = new byte[] {100, 149, 237},
                    Screens = screens.ToArray()
                });
            }
            screens.Clear();
            #endregion
            #region Products
            if (Security.AuthorizeAll(DomainPermissions.CategoryQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Categories",
								Title = ScreenResources.Categories_DisplayName,
								Controller = "CategoriesSettings",
                                Hidden = false,
								Image = "Categories"
							});
            }
            if (Security.AuthorizeAll(DomainPermissions.ProductQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Products",
								Title = ScreenResources.Products_DisplayName,
								Controller = "ProductsSettings",
                                Hidden = false,
								Image = "Products"
							});
            }
            if (Security.AuthorizeAll(DomainPermissions.SupplierQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Suppliers",
								Title = ScreenResources.Suppliers_DisplayName,
								Controller = "SuppliersSettings",
                                Hidden = false,
								Image = "Suppliers"
							});
            }
            if (screens.Count != 0)
            {
                groups.Add(new MainMenuScreenGroupSettings
                {
				    Name = "Products",
                    Title = ScreenGroupResources.Products_DisplayName,
                    Color = new byte[] {155, 187, 89},
                    Screens = screens.ToArray()
                });
            }
            screens.Clear();
            #endregion
            #region Employees
            if (Security.AuthorizeAll(DomainPermissions.EmployeeQuery_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Employees",
								Title = ScreenResources.Employees_DisplayName,
								Controller = "EmployeesSettings",
                                Hidden = false,
								Image = "Employees"
							});
            }
            if (screens.Count != 0)
            {
                groups.Add(new MainMenuScreenGroupSettings
                {
				    Name = "Employees",
                    Title = ScreenGroupResources.Employees_DisplayName,
                    Color = new byte[] {247, 150, 70},
                    Screens = screens.ToArray()
                });
            }
            screens.Clear();
            #endregion
            #region Experimental
            if (Security.AuthorizeAll(DomainPermissions.Region_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Region",
								Title = ScreenResources.Region_DisplayName,
								Controller = "RegionSettings",
                                Hidden = false,
								Image = "Region"
							});
            }
            if (Security.AuthorizeAll(DomainPermissions.Customers_Read))
            {
                screens.Add(new MainMenuScreenSettings 
				            { 
							    Name = "Charts",
								Title = ScreenResources.Charts_DisplayName,
								Controller = "ChartsSettings",
                                Hidden = false,
								Image = "Customers"
							});
            }
            if (screens.Count != 0)
            {
                groups.Add(new MainMenuScreenGroupSettings
                {
				    Name = "Experimental",
                    Title = ScreenGroupResources.Experimental_DisplayName,
                    Color = new byte[] {100, 149, 237},
                    Screens = screens.ToArray()
                });
            }
            screens.Clear();
            #endregion
            result.Groups = groups.ToArray();

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }

    }
}
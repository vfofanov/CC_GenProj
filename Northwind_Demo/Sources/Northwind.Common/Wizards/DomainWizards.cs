using BusinessFramework.Client.Contracts.Wizards;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.DataObjects;

namespace NorthWind.Common.Wizards
{
    public static class DomainWizards
    {
        public static class Names
        {
         public const string ProductWizard = "ProductWizard";
        public const string CustomerWizard = "CustomerWizard";
        public const string EmployeeWizard = "EmployeeWizard";
        public const string ShipperWizard = "ShipperWizard";
        public const string OrderDetailWizard = "OrderDetailWizard";
        public const string OrderWizard = "OrderWizard";
        public const string CategoryWizard = "CategoryWizard";
        public const string SupplierWizard = "SupplierWizard";
        public const string CustomerCompactWizard = "CustomerCompactWizard";
        public const string RegionWizard = "RegionWizard";
        public const string ReportFormQueryWizard = "ReportFormQueryWizard";
      
        }

        public static readonly WizardNameWithKey<Products, int, ProductWizardParameters> ProductWizard = new WizardNameWithKey<Products, int, ProductWizardParameters>(Names.ProductWizard);
        public static readonly WizardNameWithKey<Customers, int, CustomerWizardParameters> CustomerWizard = new WizardNameWithKey<Customers, int, CustomerWizardParameters>(Names.CustomerWizard);
        public static readonly WizardNameWithKey<Employees, int, EmployeeWizardParameters> EmployeeWizard = new WizardNameWithKey<Employees, int, EmployeeWizardParameters>(Names.EmployeeWizard);
        public static readonly WizardNameWithKey<Shippers, int, ShipperWizardParameters> ShipperWizard = new WizardNameWithKey<Shippers, int, ShipperWizardParameters>(Names.ShipperWizard);
        public static readonly WizardNameWithKey<OrderDetails, OrderDetailsKey, OrderDetailWizardParameters> OrderDetailWizard = new WizardNameWithKey<OrderDetails, OrderDetailsKey, OrderDetailWizardParameters>(Names.OrderDetailWizard);
        public static readonly WizardNameWithKey<Orders, int, OrderWizardParameters> OrderWizard = new WizardNameWithKey<Orders, int, OrderWizardParameters>(Names.OrderWizard);
        public static readonly WizardNameWithKey<Categories, int, CategoryWizardParameters> CategoryWizard = new WizardNameWithKey<Categories, int, CategoryWizardParameters>(Names.CategoryWizard);
        public static readonly WizardNameWithKey<Suppliers, int, SupplierWizardParameters> SupplierWizard = new WizardNameWithKey<Suppliers, int, SupplierWizardParameters>(Names.SupplierWizard);
        public static readonly WizardNameWithKey<Customers, int, CustomerCompactWizardParameters> CustomerCompactWizard = new WizardNameWithKey<Customers, int, CustomerCompactWizardParameters>(Names.CustomerCompactWizard);
        public static readonly WizardNameWithKey<Region, int, RegionWizardParameters> RegionWizard = new WizardNameWithKey<Region, int, RegionWizardParameters>(Names.RegionWizard);
        public static readonly WizardNameWithKey<ReportFormQuery, int, ReportFormQueryWizardParameters> ReportFormQueryWizard = new WizardNameWithKey<ReportFormQuery, int, ReportFormQueryWizardParameters>(Names.ReportFormQueryWizard);
    }
}
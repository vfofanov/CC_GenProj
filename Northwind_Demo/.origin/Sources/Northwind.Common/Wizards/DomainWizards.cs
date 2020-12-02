using BusinessFramework.Client.Contracts.Wizards;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.DataObjects;

namespace Northwind.Common.Wizards
{
    public static class DomainWizards
    {
        public static class Names
        {
         public const string ProductsWizard = "ProductsWizard";
        public const string CustomersWizard = "CustomersWizard";
        public const string EmployeesWizard = "EmployeesWizard";
        public const string ShippersWizard = "ShippersWizard";
        public const string OrderDetailsWizard = "OrderDetailsWizard";
        public const string OrdersWizard = "OrdersWizard";
        public const string CategoriesWizard = "CategoriesWizard";
        public const string SuppliersWizard = "SuppliersWizard";
      
        }

        public static readonly WizardNameWithKey<Product, int, ProductsWizardParameters> ProductsWizard = new WizardNameWithKey<Product, int, ProductsWizardParameters>(Names.ProductsWizard);
        public static readonly WizardNameWithKey<Customer, int, CustomersWizardParameters> CustomersWizard = new WizardNameWithKey<Customer, int, CustomersWizardParameters>(Names.CustomersWizard);
        public static readonly WizardNameWithKey<Employee, int, EmployeesWizardParameters> EmployeesWizard = new WizardNameWithKey<Employee, int, EmployeesWizardParameters>(Names.EmployeesWizard);
        public static readonly WizardNameWithKey<Shipper, int, ShippersWizardParameters> ShippersWizard = new WizardNameWithKey<Shipper, int, ShippersWizardParameters>(Names.ShippersWizard);
        public static readonly WizardNameWithKey<OrderDetail, int, OrderDetailsWizardParameters> OrderDetailsWizard = new WizardNameWithKey<OrderDetail, int, OrderDetailsWizardParameters>(Names.OrderDetailsWizard);
        public static readonly WizardNameWithKey<Order, int, OrdersWizardParameters> OrdersWizard = new WizardNameWithKey<Order, int, OrdersWizardParameters>(Names.OrdersWizard);
        public static readonly WizardNameWithKey<Category, int, CategoriesWizardParameters> CategoriesWizard = new WizardNameWithKey<Category, int, CategoriesWizardParameters>(Names.CategoriesWizard);
        public static readonly WizardNameWithKey<Supplier, int, SuppliersWizardParameters> SuppliersWizard = new WizardNameWithKey<Supplier, int, SuppliersWizardParameters>(Names.SuppliersWizard);
    }
}
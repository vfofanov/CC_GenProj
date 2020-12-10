using BusinessFramework.Contracts.Metadata;


namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain actions' keys
    /// </summary>
    public abstract partial class DomainActions
    {
        public static class Object
        {
            public static class Products
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Products_Create, @"Add New 'Products'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Products_Update, @"Edit 'Products'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Products_Delete, @"Delete 'Products'", false);
            }

            public static class CustomerCustomerDemo
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.CustomerCustomerDemo_Create, @"Add New 'Customer customer demo'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.CustomerCustomerDemo_Update, @"Edit 'Customer customer demo'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.CustomerCustomerDemo_Delete, @"Delete 'Customer customer demo'", false);
            }

            public static class SysResetPasswordToken
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysResetPasswordToken_Create, @"Add New 'Reset password token'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysResetPasswordToken_Update, @"Edit 'Reset password token'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysResetPasswordToken_Delete, @"Delete 'Reset password token'", true);
            }

            public static class SysRole
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysRole_Create, @"Add New 'Role'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysRole_Update, @"Edit 'Role'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysRole_Delete, @"Delete 'Role'", true);
            }

            public static class Territory
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Territory_Create, @"Add New 'Territory'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Territory_Update, @"Edit 'Territory'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Territory_Delete, @"Delete 'Territory'", false);
            }

            public static class EmployeeTerritory
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.EmployeeTerritory_Create, @"Add New 'Employee territory'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.EmployeeTerritory_Update, @"Edit 'Employee territory'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.EmployeeTerritory_Delete, @"Delete 'Employee territory'", false);
            }

            public static class Customers
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Customers_Create, @"Add New 'Customers'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Customers_Update, @"Edit 'Customers'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Customers_Delete, @"Delete 'Customers'", false);
            }

            public static class Categories
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Categories_Create, @"Add New 'Categories'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Categories_Update, @"Edit 'Categories'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Categories_Delete, @"Delete 'Categories'", false);
            }

            public static class Region
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Region_Create, @"Add New 'Region'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Region_Update, @"Edit 'Region'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Region_Delete, @"Delete 'Region'", false);
            }

            public static class Suppliers
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Suppliers_Create, @"Add New 'Suppliers'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Suppliers_Update, @"Edit 'Suppliers'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Suppliers_Delete, @"Delete 'Suppliers'", false);
            }

            public static class SysOperationLock
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysOperationLock_Create, @"Add New 'Operation lock'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysOperationLock_Update, @"Edit 'Operation lock'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysOperationLock_Delete, @"Delete 'Operation lock'", true);
            }

            public static class Orders
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Orders_Create, @"Add New 'Orders'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Orders_Update, @"Edit 'Orders'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Orders_Delete, @"Delete 'Orders'", false);
            }

            public static class OrderDetails
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.OrderDetails_Create, @"Add New 'OrderDetails'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.OrderDetails_Update, @"Edit 'OrderDetails'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.OrderDetails_Delete, @"Delete 'OrderDetails'", false);
            }

            public static class SysSetting
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysSetting_Create, @"Add New 'Setting'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysSetting_Update, @"Edit 'Setting'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysSetting_Delete, @"Delete 'Setting'", true);
            }

            public static class Employees
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Employees_Create, @"Add New 'Employees'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Employees_Update, @"Edit 'Employees'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Employees_Delete, @"Delete 'Employees'", false);
            }

            public static class CustomerDemographic
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.CustomerDemographic_Create, @"Add New 'Customer demographic'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.CustomerDemographic_Update, @"Edit 'Customer demographic'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.CustomerDemographic_Delete, @"Delete 'Customer demographic'", false);
            }

            public static class SysSettingProperty
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysSettingProperty_Create, @"Add New 'Setting property'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysSettingProperty_Update, @"Edit 'Setting property'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysSettingProperty_Delete, @"Delete 'Setting property'", true);
            }

            public static class Shippers
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Shippers_Create, @"Add New 'Shippers'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Shippers_Update, @"Edit 'Shippers'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Shippers_Delete, @"Delete 'Shippers'", false);
            }

            public static class ReportFormQuery
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.ReportFormQuery_Create, @"Add New 'ReportFormQuery'", false);
            }

        }
    }
}
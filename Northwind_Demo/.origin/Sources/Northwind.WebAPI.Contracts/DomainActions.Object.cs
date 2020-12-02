using BusinessFramework.Contracts.Metadata;


namespace Northwind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain actions' keys
    /// </summary>
    public abstract partial class DomainActions
    {
        public static class Object
        {
            public static class OrderStatus
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.OrderStatus_Create, @"Add New 'Order status'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.OrderStatus_Update, @"Edit 'Order status'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.OrderStatus_Delete, @"Delete 'Order status'", false);
            }

            public static class Product
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Product_Create, @"Add New 'Product'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Product_Update, @"Edit 'Product'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Product_Delete, @"Delete 'Product'", false);
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

            public static class Customer
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Customer_Create, @"Add New 'Customer'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Customer_Update, @"Edit 'Customer'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Customer_Delete, @"Delete 'Customer'", false);
            }

            public static class Category
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Category_Create, @"Add New 'Category'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Category_Update, @"Edit 'Category'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Category_Delete, @"Delete 'Category'", false);
            }

            public static class Supplier
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Supplier_Create, @"Add New 'Supplier'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Supplier_Update, @"Edit 'Supplier'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Supplier_Delete, @"Delete 'Supplier'", false);
            }

            public static class SysOperationLock
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysOperationLock_Create, @"Add New 'Operation lock'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysOperationLock_Update, @"Edit 'Operation lock'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysOperationLock_Delete, @"Delete 'Operation lock'", true);
            }

            public static class Order
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Order_Create, @"Add New 'Order'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Order_Update, @"Edit 'Order'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Order_Delete, @"Delete 'Order'", false);
            }

            public static class OrderDetail
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.OrderDetail_Create, @"Add New 'Order detail'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.OrderDetail_Update, @"Edit 'Order detail'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.OrderDetail_Delete, @"Delete 'Order detail'", false);
            }

            public static class SysSetting
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysSetting_Create, @"Add New 'Setting'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysSetting_Update, @"Edit 'Setting'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysSetting_Delete, @"Delete 'Setting'", true);
            }

            public static class Employee
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Employee_Create, @"Add New 'Employee'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Employee_Update, @"Edit 'Employee'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Employee_Delete, @"Delete 'Employee'", false);
            }

            public static class SysSettingProperty
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.SysSettingProperty_Create, @"Add New 'Setting property'", true);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.SysSettingProperty_Update, @"Edit 'Setting property'", true);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.SysSettingProperty_Delete, @"Delete 'Setting property'", true);
            }

            public static class VSalesByCategory
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.VSalesByCategory_Create, @"Add New 'V sales by category'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.VSalesByCategory_Update, @"Edit 'V sales by category'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.VSalesByCategory_Delete, @"Delete 'V sales by category'", false);
            }

            public static class Shipper
            {
                public static readonly ObjectDomainAction Create = new ObjectDomainAction("Create", DomainActionKeys.Object.Shipper_Create, @"Add New 'Shipper'", false);
                public static readonly ObjectDomainAction Update = new ObjectDomainAction("Update", DomainActionKeys.Object.Shipper_Update, @"Edit 'Shipper'", false);
                public static readonly ObjectDomainAction Delete = new ObjectDomainAction("Delete", DomainActionKeys.Object.Shipper_Delete, @"Delete 'Shipper'", false);
            }

        }
    }
}
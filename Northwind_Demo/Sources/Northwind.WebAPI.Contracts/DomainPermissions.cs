using BusinessFramework;


namespace Northwind.WebAPI.Contracts
{
    /// <summary>
    /// Domain permissions
    /// </summary>
    public enum DomainPermissions
    {
        /// <summary>
        /// System SettingManagement. Allows editing of global settings or other users settings
        /// </summary>
        SettingManagement = Constants.Permissions.SettingManagement,

        /// <summary>
        /// System ReportManagement. Allows editing reports
        /// </summary>
        ReportManagement = Constants.Permissions.ReportManagement,

        /// <summary>
        /// Global Operation lock management. Allows to set lock for operation
        /// </summary>
        OperationLock = 0x10,

        /// <summary>
        /// Global Settings. Allow read and edit user settings
        /// </summary>
        Settings = 0x20,

        /// <summary>
        /// Read Order status.Read. 
        /// </summary>
        OrderStatus_Read = 0x40,

        /// <summary>
        /// Create Order status.Create. 
        /// </summary>
        OrderStatus_Create = 0x80,

        /// <summary>
        /// Update Order status.Update. 
        /// </summary>
        OrderStatus_Update = 0x101,

        /// <summary>
        /// Delete Order status.Delete. 
        /// </summary>
        OrderStatus_Delete = 0x102,

        /// <summary>
        /// Read Product.Read. 
        /// </summary>
        Product_Read = 0x104,

        /// <summary>
        /// Create Product.Create. 
        /// </summary>
        Product_Create = 0x108,

        /// <summary>
        /// Update Product.Update. 
        /// </summary>
        Product_Update = 0x110,

        /// <summary>
        /// Delete Product.Delete. 
        /// </summary>
        Product_Delete = 0x120,

        /// <summary>
        /// Read Reset password token.Read. 
        /// </summary>
        SysResetPasswordToken_Read = 0x140,

        /// <summary>
        /// Create Reset password token.Create. 
        /// </summary>
        SysResetPasswordToken_Create = 0x180,

        /// <summary>
        /// Update Reset password token.Update. 
        /// </summary>
        SysResetPasswordToken_Update = 0x201,

        /// <summary>
        /// Delete Reset password token.Delete. 
        /// </summary>
        SysResetPasswordToken_Delete = 0x202,

        /// <summary>
        /// Read Role.Read. 
        /// </summary>
        SysRole_Read = 0x204,

        /// <summary>
        /// Create Role.Create. 
        /// </summary>
        SysRole_Create = 0x208,

        /// <summary>
        /// Update Role.Update. 
        /// </summary>
        SysRole_Update = 0x210,

        /// <summary>
        /// Delete Role.Delete. 
        /// </summary>
        SysRole_Delete = 0x220,

        /// <summary>
        /// Read Customer.Read. 
        /// </summary>
        Customer_Read = 0x240,

        /// <summary>
        /// Create Customer.Create. 
        /// </summary>
        Customer_Create = 0x280,

        /// <summary>
        /// Update Customer.Update. 
        /// </summary>
        Customer_Update = 0x301,

        /// <summary>
        /// Delete Customer.Delete. 
        /// </summary>
        Customer_Delete = 0x302,

        /// <summary>
        /// Read Category.Read. 
        /// </summary>
        Category_Read = 0x304,

        /// <summary>
        /// Create Category.Create. 
        /// </summary>
        Category_Create = 0x308,

        /// <summary>
        /// Update Category.Update. 
        /// </summary>
        Category_Update = 0x310,

        /// <summary>
        /// Delete Category.Delete. 
        /// </summary>
        Category_Delete = 0x320,

        /// <summary>
        /// Read Supplier.Read. 
        /// </summary>
        Supplier_Read = 0x340,

        /// <summary>
        /// Create Supplier.Create. 
        /// </summary>
        Supplier_Create = 0x380,

        /// <summary>
        /// Update Supplier.Update. 
        /// </summary>
        Supplier_Update = 0x401,

        /// <summary>
        /// Delete Supplier.Delete. 
        /// </summary>
        Supplier_Delete = 0x402,

        /// <summary>
        /// Read Order.Read. 
        /// </summary>
        Order_Read = 0x404,

        /// <summary>
        /// Create Order.Create. 
        /// </summary>
        Order_Create = 0x408,

        /// <summary>
        /// Update Order.Update. 
        /// </summary>
        Order_Update = 0x410,

        /// <summary>
        /// Delete Order.Delete. 
        /// </summary>
        Order_Delete = 0x420,

        /// <summary>
        /// Read Order detail.Read. 
        /// </summary>
        OrderDetail_Read = 0x440,

        /// <summary>
        /// Create Order detail.Create. 
        /// </summary>
        OrderDetail_Create = 0x480,

        /// <summary>
        /// Update Order detail.Update. 
        /// </summary>
        OrderDetail_Update = 0x501,

        /// <summary>
        /// Delete Order detail.Delete. 
        /// </summary>
        OrderDetail_Delete = 0x502,

        /// <summary>
        /// Read Employee.Read. 
        /// </summary>
        Employee_Read = 0x504,

        /// <summary>
        /// Create Employee.Create. 
        /// </summary>
        Employee_Create = 0x508,

        /// <summary>
        /// Update Employee.Update. 
        /// </summary>
        Employee_Update = 0x510,

        /// <summary>
        /// Delete Employee.Delete. 
        /// </summary>
        Employee_Delete = 0x520,

        /// <summary>
        /// Read V sales by category.Read. 
        /// </summary>
        VSalesByCategory_Read = 0x540,

        /// <summary>
        /// Create V sales by category.Create. 
        /// </summary>
        VSalesByCategory_Create = 0x580,

        /// <summary>
        /// Update V sales by category.Update. 
        /// </summary>
        VSalesByCategory_Update = 0x601,

        /// <summary>
        /// Delete V sales by category.Delete. 
        /// </summary>
        VSalesByCategory_Delete = 0x602,

        /// <summary>
        /// Read Shipper.Read. 
        /// </summary>
        Shipper_Read = 0x604,

        /// <summary>
        /// Create Shipper.Create. 
        /// </summary>
        Shipper_Create = 0x608,

        /// <summary>
        /// Update Shipper.Update. 
        /// </summary>
        Shipper_Update = 0x610,

        /// <summary>
        /// Delete Shipper.Delete. 
        /// </summary>
        Shipper_Delete = 0x620,

        /// <summary>
        /// Read qSuppliers.Read. 
        /// </summary>
        QSuppliers_Read = 0x640,

        /// <summary>
        /// Read qEmployees.Read. 
        /// </summary>
        QEmployees_Read = 0x680,

        /// <summary>
        /// Read qShippers.Read. 
        /// </summary>
        QShippers_Read = 0x701,

        /// <summary>
        /// Read qCategories.Read. 
        /// </summary>
        QCategories_Read = 0x702,

        /// <summary>
        /// Read qCustomers.Read. 
        /// </summary>
        QCustomers_Read = 0x704,

        /// <summary>
        /// Read qProducts.Read. 
        /// </summary>
        QProducts_Read = 0x708,

        /// <summary>
        /// Read qOrderProducts.Read. 
        /// </summary>
        QOrderProducts_Read = 0x710,

        /// <summary>
        /// Read qOrders.Read. 
        /// </summary>
        QOrders_Read = 0x720,

        /// <summary>
        /// Execute Print Order Invoice.Execute. 
        /// </summary>
        PrintOrderInvoice_Execute = 0x740,

        /// <summary>
        /// Execute GetTestData.Execute. 
        /// </summary>
        GetTestData_Execute = 0x780,

        
    }
}
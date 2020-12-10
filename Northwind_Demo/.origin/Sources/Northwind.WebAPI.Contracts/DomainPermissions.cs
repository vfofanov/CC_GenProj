using BusinessFramework;


namespace NorthWind.WebAPI.Contracts
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
        /// Read Products.Read. 
        /// </summary>
        Products_Read = 0x40,

        /// <summary>
        /// Create Products.Create. 
        /// </summary>
        Products_Create = 0x80,

        /// <summary>
        /// Update Products.Update. 
        /// </summary>
        Products_Update = 0x101,

        /// <summary>
        /// Delete Products.Delete. 
        /// </summary>
        Products_Delete = 0x102,

        /// <summary>
        /// Read Customer customer demo.Read. 
        /// </summary>
        CustomerCustomerDemo_Read = 0x104,

        /// <summary>
        /// Create Customer customer demo.Create. 
        /// </summary>
        CustomerCustomerDemo_Create = 0x108,

        /// <summary>
        /// Update Customer customer demo.Update. 
        /// </summary>
        CustomerCustomerDemo_Update = 0x110,

        /// <summary>
        /// Delete Customer customer demo.Delete. 
        /// </summary>
        CustomerCustomerDemo_Delete = 0x120,

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
        /// Read Territory.Read. 
        /// </summary>
        Territory_Read = 0x240,

        /// <summary>
        /// Create Territory.Create. 
        /// </summary>
        Territory_Create = 0x280,

        /// <summary>
        /// Update Territory.Update. 
        /// </summary>
        Territory_Update = 0x301,

        /// <summary>
        /// Delete Territory.Delete. 
        /// </summary>
        Territory_Delete = 0x302,

        /// <summary>
        /// Read Employee territory.Read. 
        /// </summary>
        EmployeeTerritory_Read = 0x304,

        /// <summary>
        /// Create Employee territory.Create. 
        /// </summary>
        EmployeeTerritory_Create = 0x308,

        /// <summary>
        /// Update Employee territory.Update. 
        /// </summary>
        EmployeeTerritory_Update = 0x310,

        /// <summary>
        /// Delete Employee territory.Delete. 
        /// </summary>
        EmployeeTerritory_Delete = 0x320,

        /// <summary>
        /// Read Customers.Read. 
        /// </summary>
        Customers_Read = 0x340,

        /// <summary>
        /// Create Customers.Create. 
        /// </summary>
        Customers_Create = 0x380,

        /// <summary>
        /// Update Customers.Update. 
        /// </summary>
        Customers_Update = 0x401,

        /// <summary>
        /// Delete Customers.Delete. 
        /// </summary>
        Customers_Delete = 0x402,

        /// <summary>
        /// Read Categories.Read. 
        /// </summary>
        Categories_Read = 0x404,

        /// <summary>
        /// Create Categories.Create. 
        /// </summary>
        Categories_Create = 0x408,

        /// <summary>
        /// Update Categories.Update. 
        /// </summary>
        Categories_Update = 0x410,

        /// <summary>
        /// Delete Categories.Delete. 
        /// </summary>
        Categories_Delete = 0x420,

        /// <summary>
        /// Read Region.Read. 
        /// </summary>
        Region_Read = 0x440,

        /// <summary>
        /// Create Region.Create. 
        /// </summary>
        Region_Create = 0x480,

        /// <summary>
        /// Update Region.Update. 
        /// </summary>
        Region_Update = 0x501,

        /// <summary>
        /// Delete Region.Delete. 
        /// </summary>
        Region_Delete = 0x502,

        /// <summary>
        /// Read Suppliers.Read. 
        /// </summary>
        Suppliers_Read = 0x504,

        /// <summary>
        /// Create Suppliers.Create. 
        /// </summary>
        Suppliers_Create = 0x508,

        /// <summary>
        /// Update Suppliers.Update. 
        /// </summary>
        Suppliers_Update = 0x510,

        /// <summary>
        /// Delete Suppliers.Delete. 
        /// </summary>
        Suppliers_Delete = 0x520,

        /// <summary>
        /// Read Orders.Read. 
        /// </summary>
        Orders_Read = 0x540,

        /// <summary>
        /// Create Orders.Create. 
        /// </summary>
        Orders_Create = 0x580,

        /// <summary>
        /// Update Orders.Update. 
        /// </summary>
        Orders_Update = 0x601,

        /// <summary>
        /// Delete Orders.Delete. 
        /// </summary>
        Orders_Delete = 0x602,

        /// <summary>
        /// Read OrderDetails.Read. 
        /// </summary>
        OrderDetails_Read = 0x604,

        /// <summary>
        /// Create OrderDetails.Create. 
        /// </summary>
        OrderDetails_Create = 0x608,

        /// <summary>
        /// Update OrderDetails.Update. 
        /// </summary>
        OrderDetails_Update = 0x610,

        /// <summary>
        /// Delete OrderDetails.Delete. 
        /// </summary>
        OrderDetails_Delete = 0x620,

        /// <summary>
        /// Read Employees.Read. 
        /// </summary>
        Employees_Read = 0x640,

        /// <summary>
        /// Create Employees.Create. 
        /// </summary>
        Employees_Create = 0x680,

        /// <summary>
        /// Update Employees.Update. 
        /// </summary>
        Employees_Update = 0x701,

        /// <summary>
        /// Delete Employees.Delete. 
        /// </summary>
        Employees_Delete = 0x702,

        /// <summary>
        /// Read Customer demographic.Read. 
        /// </summary>
        CustomerDemographic_Read = 0x704,

        /// <summary>
        /// Create Customer demographic.Create. 
        /// </summary>
        CustomerDemographic_Create = 0x708,

        /// <summary>
        /// Update Customer demographic.Update. 
        /// </summary>
        CustomerDemographic_Update = 0x710,

        /// <summary>
        /// Delete Customer demographic.Delete. 
        /// </summary>
        CustomerDemographic_Delete = 0x720,

        /// <summary>
        /// Read Shippers.Read. 
        /// </summary>
        Shippers_Read = 0x740,

        /// <summary>
        /// Create Shippers.Create. 
        /// </summary>
        Shippers_Create = 0x780,

        /// <summary>
        /// Update Shippers.Update. 
        /// </summary>
        Shippers_Update = 0x801,

        /// <summary>
        /// Delete Shippers.Delete. 
        /// </summary>
        Shippers_Delete = 0x802,

        /// <summary>
        /// Read SupplierQuery.Read. 
        /// </summary>
        SupplierQuery_Read = 0x804,

        /// <summary>
        /// Read EmployeeQuery.Read. 
        /// </summary>
        EmployeeQuery_Read = 0x808,

        /// <summary>
        /// Read ShipperQuery.Read. 
        /// </summary>
        ShipperQuery_Read = 0x810,

        /// <summary>
        /// Read CategoryQuery.Read. 
        /// </summary>
        CategoryQuery_Read = 0x820,

        /// <summary>
        /// Read ReportFormQuery.Read. 
        /// </summary>
        ReportFormQuery_Read = 0x840,

        /// <summary>
        /// Create ReportFormQuery.Create. 
        /// </summary>
        ReportFormQuery_Create = 0x880,

        /// <summary>
        /// Read CustomerQuery.Read. 
        /// </summary>
        CustomerQuery_Read = 0x901,

        /// <summary>
        /// Read ProductQuery.Read. 
        /// </summary>
        ProductQuery_Read = 0x902,

        /// <summary>
        /// Read OrderProductQuery.Read. 
        /// </summary>
        OrderProductQuery_Read = 0x904,

        /// <summary>
        /// Read OrdersQuery.Read. 
        /// </summary>
        OrdersQuery_Read = 0x908,

        /// <summary>
        /// Read RegionQuery.Read. 
        /// </summary>
        RegionQuery_Read = 0x910,

        /// <summary>
        /// Execute Print report.Execute. 
        /// </summary>
        ServerPrintSimple_Execute = 0x920,

        /// <summary>
        /// Execute Print report with parameter .Execute. 
        /// </summary>
        ServerPrintWithParameter_Execute = 0x940,

        /// <summary>
        /// Execute Print report with parameter .Execute. 
        /// </summary>
        ServerPrintWithForm_Execute = 0x980,

        
    }
}
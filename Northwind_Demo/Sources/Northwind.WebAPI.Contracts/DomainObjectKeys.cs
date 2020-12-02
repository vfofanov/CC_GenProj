namespace Northwind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain objects' keys
    /// </summary>
    public abstract class DomainObjectKeys
    {
         public const int OrderStatus = 1;
         public const int SysUserPermissionsDisplayView = 7;
         public const int SysOperation = 12;
         public const int SysObject = 24;
         public const int SysOperationResult = 35;
         public const int Product = 38;
         public const int SysResetPasswordToken = 54;
         public const int SysRefreshToken = 64;
         public const int SysRole = 70;
         public const int SysUser = 82;
         public const int SysRolePermission = 98;
         public const int Customer = 104;
         public const int Category = 119;
         public const int Supplier = 127;
         public const int SysOperationLock = 143;
         public const int SysUserRole = 155;
         public const int Order = 161;
         public const int SysPermission = 185;
         public const int OrderDetail = 195;
         public const int SysSetting = 207;
         public const int SysInfo = 217;
         public const int Employee = 221;
         public const int SysObjectType = 244;
         public const int SysObjectClass = 247;
         public const int SysPermissionType = 252;
         public const int SysSettingProperty = 257;
         public const int SysUsersDisplayView = 269;
         public const int VSalesByCategory = 273;
         public const int Shipper = 281;
         public const int QSuppliers = 288;
         public const int QEmployees = 301;
         public const int QShippers = 319;
         public const int QCategories = 323;
         public const int QCustomers = 328;
         public const int QProducts = 340;
         public const int QOrderProducts = 366;
         public const int QOrders = 397;
    }

    /// <summary>
    ///     Domain objects' property keys
    /// </summary>
    public abstract class DomainObjectPropertyKeys
    {
        /// <summary>
        ///     Property keys for OrderStatus
        /// </summary>
        public abstract class OrderStatus
        {
             public const int Id = 5;
             public const int Name = 6;
        }
        /// <summary>
        ///     Property keys for SysUserPermissionsDisplayView
        /// </summary>
        public abstract class SysUserPermissionsDisplayView
        {
             public const int UserId = 8;
             public const int PermissionId = 9;
             public const int PermissionName = 10;
             public const int Roles = 11;
        }
        /// <summary>
        ///     Property keys for SysOperation
        /// </summary>
        public abstract class SysOperation
        {
             public const int Id = 13;
             public const int ActionId = 15;
             public const int Date = 16;
             public const int OperationDetails = 17;
             public const int OperationResultId = 19;
             public const int Request = 20;
             public const int RequestContent = 21;
             public const int UserID = 23;
        }
        /// <summary>
        ///     Property keys for SysObject
        /// </summary>
        public abstract class SysObject
        {
             public const int Id = 25;
             public const int ClassId = 26;
             public const int CodeName = 27;
             public const int DbFieldId = 28;
             public const int DbObjectId = 29;
             public const int Description = 30;
             public const int DisplayName = 31;
             public const int Guid = 32;
             public const int ParentId = 33;
        }
        /// <summary>
        ///     Property keys for SysOperationResult
        /// </summary>
        public abstract class SysOperationResult
        {
             public const int Id = 36;
             public const int Name = 37;
        }
        /// <summary>
        ///     Property keys for Product
        /// </summary>
        public abstract class Product
        {
             public const int Id = 42;
             public const int CategoryID = 44;
             public const int Discontinued = 45;
             public const int ProductName = 46;
             public const int QuantityPerUnit = 47;
             public const int ReorderLevel = 48;
             public const int SupplierID = 49;
             public const int UnitPrice = 51;
             public const int UnitsInStock = 52;
             public const int UnitsOnOrder = 53;
        }
        /// <summary>
        ///     Property keys for SysResetPasswordToken
        /// </summary>
        public abstract class SysResetPasswordToken
        {
             public const int Id = 58;
             public const int IsExecuted = 59;
             public const int Token = 61;
             public const int UserId = 62;
             public const int ValidFrom = 63;
        }
        /// <summary>
        ///     Property keys for SysRefreshToken
        /// </summary>
        public abstract class SysRefreshToken
        {
             public const int UserId = 65;
             public const int ClientId = 66;
             public const int ExpiresUtc = 67;
             public const int Token = 69;
        }
        /// <summary>
        ///     Property keys for SysRole
        /// </summary>
        public abstract class SysRole
        {
             public const int Id = 74;
             public const int Description = 75;
             public const int IsOwnByUser = 76;
             public const int IsSystem = 77;
             public const int Name = 78;
             public const int OwnerUserID = 80;
        }
        /// <summary>
        ///     Property keys for SysUser
        /// </summary>
        public abstract class SysUser
        {
             public const int Id = 83;
             public const int AccountName = 84;
             public const int CreateDate = 85;
             public const int DeactivationDate = 86;
             public const int Description = 87;
             public const int DisplayName = 88;
             public const int EMail = 89;
             public const int EmailToken = 90;
             public const int FullAccess = 91;
             public const int IsAnonymous = 92;
             public const int IsDeactivated = 93;
             public const int IsEmailConfirmed = 94;
             public const int IsSystemUser = 95;
             public const int PasswordHash = 96;
        }
        /// <summary>
        ///     Property keys for SysRolePermission
        /// </summary>
        public abstract class SysRolePermission
        {
             public const int Id = 99;
             public const int PermissionId = 100;
             public const int RoleId = 101;
        }
        /// <summary>
        ///     Property keys for Customer
        /// </summary>
        public abstract class Customer
        {
             public const int Id = 108;
             public const int Address = 109;
             public const int City = 110;
             public const int CompanyName = 111;
             public const int ContactName = 112;
             public const int ContactTitle = 113;
             public const int Country = 114;
             public const int Fax = 115;
             public const int Phone = 116;
             public const int PostalCode = 117;
             public const int Region = 118;
        }
        /// <summary>
        ///     Property keys for Category
        /// </summary>
        public abstract class Category
        {
             public const int Id = 123;
             public const int CategoryName = 124;
             public const int Description = 125;
             public const int Picture = 126;
        }
        /// <summary>
        ///     Property keys for Supplier
        /// </summary>
        public abstract class Supplier
        {
             public const int Id = 131;
             public const int Address = 132;
             public const int City = 133;
             public const int CompanyName = 134;
             public const int ContactName = 135;
             public const int ContactTitle = 136;
             public const int Country = 137;
             public const int Fax = 138;
             public const int HomePage = 139;
             public const int Phone = 140;
             public const int PostalCode = 141;
             public const int Region = 142;
        }
        /// <summary>
        ///     Property keys for SysOperationLock
        /// </summary>
        public abstract class SysOperationLock
        {
             public const int OperationName = 147;
             public const int OperationContext = 148;
             public const int AquiredTime = 149;
             public const int ExpirationTime = 150;
             public const int MachineName = 151;
             public const int ProcessId = 152;
             public const int UserId = 154;
        }
        /// <summary>
        ///     Property keys for SysUserRole
        /// </summary>
        public abstract class SysUserRole
        {
             public const int Id = 156;
             public const int RoleId = 157;
             public const int UserId = 160;
        }
        /// <summary>
        ///     Property keys for Order
        /// </summary>
        public abstract class Order
        {
             public const int Id = 165;
             public const int CustomerID = 166;
             public const int EmployeeID = 168;
             public const int Freight = 170;
             public const int OrderDate = 171;
             public const int RequiredDate = 174;
             public const int ShipAddress = 175;
             public const int ShipCity = 176;
             public const int ShipCountry = 177;
             public const int ShipName = 178;
             public const int ShippedDate = 179;
             public const int ShipPostalCode = 181;
             public const int ShipRegion = 182;
             public const int ShipVia = 183;
             public const int StatusID = 184;
        }
        /// <summary>
        ///     Property keys for SysPermission
        /// </summary>
        public abstract class SysPermission
        {
             public const int Id = 186;
             public const int CodeName = 187;
             public const int Description = 188;
             public const int DisplayName = 189;
             public const int Guid = 190;
             public const int ObjectId = 191;
             public const int Type = 194;
        }
        /// <summary>
        ///     Property keys for OrderDetail
        /// </summary>
        public abstract class OrderDetail
        {
             public const int Id = 199;
             public const int Discount = 200;
             public const int OrderID = 201;
             public const int ProductID = 203;
             public const int Quantity = 205;
             public const int UnitPrice = 206;
        }
        /// <summary>
        ///     Property keys for SysSetting
        /// </summary>
        public abstract class SysSetting
        {
             public const int Id = 211;
             public const int SettingPropertyId = 212;
             public const int StringValue = 213;
             public const int UserId = 216;
        }
        /// <summary>
        ///     Property keys for SysInfo
        /// </summary>
        public abstract class SysInfo
        {
             public const int SystemVersion = 218;
             public const int DomainVersion = 219;
             public const int LastInitialization = 220;
        }
        /// <summary>
        ///     Property keys for Employee
        /// </summary>
        public abstract class Employee
        {
             public const int Id = 225;
             public const int Address = 226;
             public const int BirthDate = 227;
             public const int City = 228;
             public const int Country = 229;
             public const int Extension = 230;
             public const int FirstName = 231;
             public const int HireDate = 232;
             public const int HomePhone = 233;
             public const int LastName = 234;
             public const int Notes = 235;
             public const int Photo = 236;
             public const int PhotoPath = 237;
             public const int PostalCode = 238;
             public const int Region = 239;
             public const int ReportsTo = 240;
             public const int Title = 242;
             public const int TitleOfCourtesy = 243;
        }
        /// <summary>
        ///     Property keys for SysObjectType
        /// </summary>
        public abstract class SysObjectType
        {
             public const int Id = 245;
             public const int Name = 246;
        }
        /// <summary>
        ///     Property keys for SysObjectClass
        /// </summary>
        public abstract class SysObjectClass
        {
             public const int Id = 248;
             public const int CodeName = 249;
             public const int Description = 250;
             public const int DisplayName = 251;
        }
        /// <summary>
        ///     Property keys for SysPermissionType
        /// </summary>
        public abstract class SysPermissionType
        {
             public const int Id = 253;
             public const int CodeName = 254;
             public const int Description = 255;
             public const int DisplayName = 256;
        }
        /// <summary>
        ///     Property keys for SysSettingProperty
        /// </summary>
        public abstract class SysSettingProperty
        {
             public const int Id = 261;
             public const int DefaultType = 262;
             public const int Description = 263;
             public const int GroupName = 264;
             public const int IsManaged = 265;
             public const int IsOverridable = 266;
             public const int Name = 267;
             public const int UIEditorType = 268;
        }
        /// <summary>
        ///     Property keys for SysUsersDisplayView
        /// </summary>
        public abstract class SysUsersDisplayView
        {
             public const int Id = 270;
             public const int UserRoleId = 272;
        }
        /// <summary>
        ///     Property keys for VSalesByCategory
        /// </summary>
        public abstract class VSalesByCategory
        {
             public const int Id = 277;
             public const int CategoryName = 278;
             public const int ProductName = 279;
             public const int ProductSales = 280;
        }
        /// <summary>
        ///     Property keys for Shipper
        /// </summary>
        public abstract class Shipper
        {
             public const int Id = 285;
             public const int CompanyName = 286;
             public const int Phone = 287;
        }
        /// <summary>
        ///     Property keys for QSuppliers
        /// </summary>
        public abstract class QSuppliers
        {
             public const int Id = 289;
             public const int Address = 290;
             public const int City = 291;
             public const int CompanyName = 292;
             public const int ContactName = 293;
             public const int ContactTitle = 294;
             public const int Country = 295;
             public const int Fax = 296;
             public const int HomePage = 297;
             public const int Phone = 298;
             public const int PostalCode = 299;
             public const int Region = 300;
        }
        /// <summary>
        ///     Property keys for QEmployees
        /// </summary>
        public abstract class QEmployees
        {
             public const int Id = 302;
             public const int Address = 303;
             public const int BirthDate = 304;
             public const int City = 305;
             public const int Country = 306;
             public const int Employee_FullName = 307;
             public const int Extension = 308;
             public const int FirstName = 309;
             public const int HireDate = 310;
             public const int HomePhone = 311;
             public const int LastName = 312;
             public const int Notes = 313;
             public const int PostalCode = 314;
             public const int Region = 315;
             public const int ReportsTo = 316;
             public const int Title = 317;
             public const int TitleOfCourtesy = 318;
        }
        /// <summary>
        ///     Property keys for QShippers
        /// </summary>
        public abstract class QShippers
        {
             public const int Id = 320;
             public const int CompanyName = 321;
             public const int Phone = 322;
        }
        /// <summary>
        ///     Property keys for QCategories
        /// </summary>
        public abstract class QCategories
        {
             public const int Id = 324;
             public const int CategoryName = 325;
             public const int Description = 326;
             public const int Picture = 327;
        }
        /// <summary>
        ///     Property keys for QCustomers
        /// </summary>
        public abstract class QCustomers
        {
             public const int Id = 329;
             public const int Address = 330;
             public const int City = 331;
             public const int CompanyName = 332;
             public const int ContactName = 333;
             public const int ContactTitle = 334;
             public const int Country = 335;
             public const int Fax = 336;
             public const int Phone = 337;
             public const int PostalCode = 338;
             public const int Region = 339;
        }
        /// <summary>
        ///     Property keys for QProducts
        /// </summary>
        public abstract class QProducts
        {
             public const int Id = 341;
             public const int Categories_CategoryName = 342;
             public const int Categories_Description = 343;
             public const int Categories_Id = 344;
             public const int CategoryID = 345;
             public const int Discontinued = 346;
             public const int ProductName = 347;
             public const int QuantityPerUnit = 348;
             public const int ReorderLevel = 349;
             public const int SupplierID = 350;
             public const int Suppliers_Address = 351;
             public const int Suppliers_City = 352;
             public const int Suppliers_CompanyName = 353;
             public const int Suppliers_ContactName = 354;
             public const int Suppliers_ContactTitle = 355;
             public const int Suppliers_Country = 356;
             public const int Suppliers_Fax = 357;
             public const int Suppliers_HomePage = 358;
             public const int Suppliers_Id = 359;
             public const int Suppliers_Phone = 360;
             public const int Suppliers_PostalCode = 361;
             public const int Suppliers_Region = 362;
             public const int UnitPrice = 363;
             public const int UnitsInStock = 364;
             public const int UnitsOnOrder = 365;
        }
        /// <summary>
        ///     Property keys for QOrderProducts
        /// </summary>
        public abstract class QOrderProducts
        {
             public const int Id = 367;
             public const int Discount = 368;
             public const int OrderID = 369;
             public const int Orders_CustomerID = 370;
             public const int Orders_EmployeeID = 371;
             public const int Orders_Freight = 372;
             public const int Orders_Id = 373;
             public const int Orders_OrderDate = 374;
             public const int Orders_RequiredDate = 375;
             public const int Orders_ShipAddress = 376;
             public const int Orders_ShipCity = 377;
             public const int Orders_ShipCountry = 378;
             public const int Orders_ShipName = 379;
             public const int Orders_ShippedDate = 380;
             public const int Orders_ShipPostalCode = 381;
             public const int Orders_ShipRegion = 382;
             public const int Orders_ShipVia = 383;
             public const int ProductID = 384;
             public const int Products_CategoryID = 385;
             public const int Products_Discontinued = 386;
             public const int Products_Id = 387;
             public const int Products_ProductName = 388;
             public const int Products_QuantityPerUnit = 389;
             public const int Products_ReorderLevel = 390;
             public const int Products_SupplierID = 391;
             public const int Products_UnitPrice = 392;
             public const int Products_UnitsInStock = 393;
             public const int Products_UnitsOnOrder = 394;
             public const int Quantity = 395;
             public const int UnitPrice = 396;
        }
        /// <summary>
        ///     Property keys for QOrders
        /// </summary>
        public abstract class QOrders
        {
             public const int Id = 398;
             public const int CustomerID = 399;
             public const int Customers_Address = 400;
             public const int Customers_City = 401;
             public const int Customers_CompanyName = 402;
             public const int Customers_ContactName = 403;
             public const int Customers_ContactTitle = 404;
             public const int Customers_Country = 405;
             public const int Customers_Fax = 406;
             public const int Customers_Id = 407;
             public const int Customers_Phone = 408;
             public const int Customers_PostalCode = 409;
             public const int Customers_Region = 410;
             public const int EmployeeFullName = 411;
             public const int EmployeeID = 412;
             public const int Employees_Address = 413;
             public const int Employees_BirthDate = 414;
             public const int Employees_City = 415;
             public const int Employees_Country = 416;
             public const int Employees_Extension = 417;
             public const int Employees_FirstName = 418;
             public const int Employees_HireDate = 419;
             public const int Employees_HomePhone = 420;
             public const int Employees_Id = 421;
             public const int Employees_LastName = 422;
             public const int Employees_Notes = 423;
             public const int Employees_PhotoPath = 424;
             public const int Employees_PostalCode = 425;
             public const int Employees_Region = 426;
             public const int Employees_ReportsTo = 427;
             public const int Employees_Title = 428;
             public const int Employees_TitleOfCourtesy = 429;
             public const int Freight = 430;
             public const int OrderDate = 431;
             public const int RequiredDate = 432;
             public const int ShipAddress = 433;
             public const int ShipCity = 434;
             public const int ShipCountry = 435;
             public const int ShipName = 436;
             public const int ShippedDate = 437;
             public const int Shippers_CompanyName = 438;
             public const int Shippers_Id = 439;
             public const int Shippers_Phone = 440;
             public const int ShipPostalCode = 441;
             public const int ShipRegion = 442;
             public const int ShipVia = 443;
        }
    }
}
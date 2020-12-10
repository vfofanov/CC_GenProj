namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain objects' keys
    /// </summary>
    public abstract class DomainObjectKeys
    {
         public const int SysUserPermissionsDisplayView = 1;
         public const int SysOperation = 6;
         public const int SysObject = 18;
         public const int SysOperationResult = 29;
         public const int Products = 32;
         public const int CustomerCustomerDemo = 48;
         public const int SysResetPasswordToken = 56;
         public const int SysRefreshToken = 66;
         public const int SysRole = 72;
         public const int Territory = 84;
         public const int EmployeeTerritory = 92;
         public const int SysUser = 100;
         public const int SysRolePermission = 116;
         public const int Customers = 122;
         public const int Categories = 137;
         public const int Region = 145;
         public const int Suppliers = 151;
         public const int SysOperationLock = 167;
         public const int SysUserRole = 179;
         public const int Orders = 185;
         public const int SysPermission = 207;
         public const int OrderDetails = 217;
         public const int SysSetting = 228;
         public const int SysInfo = 238;
         public const int Employees = 242;
         public const int SysObjectType = 266;
         public const int SysObjectClass = 269;
         public const int CustomerDemographic = 274;
         public const int SysPermissionType = 280;
         public const int SysSettingProperty = 285;
         public const int SysUsersDisplayView = 297;
         public const int Shippers = 301;
         public const int SupplierQuery = 308;
         public const int EmployeeQuery = 321;
         public const int ShipperQuery = 341;
         public const int CategoryQuery = 345;
         public const int ReportFormQuery = 350;
         public const int CustomerQuery = 358;
         public const int ProductQuery = 370;
         public const int OrderProductQuery = 396;
         public const int OrdersQuery = 427;
         public const int RegionQuery = 474;
    }

    /// <summary>
    ///     Domain objects' property keys
    /// </summary>
    public abstract class DomainObjectPropertyKeys
    {
        /// <summary>
        ///     Property keys for SysUserPermissionsDisplayView
        /// </summary>
        public abstract class SysUserPermissionsDisplayView
        {
             public const int UserId = 2;
             public const int PermissionId = 3;
             public const int PermissionName = 4;
             public const int Roles = 5;
        }
        /// <summary>
        ///     Property keys for SysOperation
        /// </summary>
        public abstract class SysOperation
        {
             public const int Id = 7;
             public const int ActionId = 9;
             public const int Date = 10;
             public const int OperationDetails = 11;
             public const int OperationResultId = 13;
             public const int Request = 14;
             public const int RequestContent = 15;
             public const int UserID = 17;
        }
        /// <summary>
        ///     Property keys for SysObject
        /// </summary>
        public abstract class SysObject
        {
             public const int Id = 19;
             public const int ClassId = 20;
             public const int CodeName = 21;
             public const int DbFieldId = 22;
             public const int DbObjectId = 23;
             public const int Description = 24;
             public const int DisplayName = 25;
             public const int Guid = 26;
             public const int ParentId = 27;
        }
        /// <summary>
        ///     Property keys for SysOperationResult
        /// </summary>
        public abstract class SysOperationResult
        {
             public const int Id = 30;
             public const int Name = 31;
        }
        /// <summary>
        ///     Property keys for Products
        /// </summary>
        public abstract class Products
        {
             public const int Id = 36;
             public const int CategoryID = 38;
             public const int Discontinued = 39;
             public const int ProductName = 40;
             public const int QuantityPerUnit = 41;
             public const int ReorderLevel = 42;
             public const int SupplierID = 43;
             public const int UnitPrice = 45;
             public const int UnitsInStock = 46;
             public const int UnitsOnOrder = 47;
        }
        /// <summary>
        ///     Property keys for CustomerCustomerDemo
        /// </summary>
        public abstract class CustomerCustomerDemo
        {
             public const int CustomerID = 52;
             public const int CustomerTypeID = 53;
        }
        /// <summary>
        ///     Property keys for SysResetPasswordToken
        /// </summary>
        public abstract class SysResetPasswordToken
        {
             public const int Id = 60;
             public const int IsExecuted = 61;
             public const int Token = 63;
             public const int UserId = 64;
             public const int ValidFrom = 65;
        }
        /// <summary>
        ///     Property keys for SysRefreshToken
        /// </summary>
        public abstract class SysRefreshToken
        {
             public const int UserId = 67;
             public const int ClientId = 68;
             public const int ExpiresUtc = 69;
             public const int Token = 71;
        }
        /// <summary>
        ///     Property keys for SysRole
        /// </summary>
        public abstract class SysRole
        {
             public const int Id = 76;
             public const int Description = 77;
             public const int IsOwnByUser = 78;
             public const int IsSystem = 79;
             public const int Name = 80;
             public const int OwnerUserID = 82;
        }
        /// <summary>
        ///     Property keys for Territory
        /// </summary>
        public abstract class Territory
        {
             public const int Id = 88;
             public const int RegionID = 90;
             public const int TerritoryDescription = 91;
        }
        /// <summary>
        ///     Property keys for EmployeeTerritory
        /// </summary>
        public abstract class EmployeeTerritory
        {
             public const int EmployeeID = 96;
             public const int TerritoryID = 97;
        }
        /// <summary>
        ///     Property keys for SysUser
        /// </summary>
        public abstract class SysUser
        {
             public const int Id = 101;
             public const int AccountName = 102;
             public const int CreateDate = 103;
             public const int DeactivationDate = 104;
             public const int Description = 105;
             public const int DisplayName = 106;
             public const int EMail = 107;
             public const int EmailToken = 108;
             public const int FullAccess = 109;
             public const int IsAnonymous = 110;
             public const int IsDeactivated = 111;
             public const int IsEmailConfirmed = 112;
             public const int IsSystemUser = 113;
             public const int PasswordHash = 114;
        }
        /// <summary>
        ///     Property keys for SysRolePermission
        /// </summary>
        public abstract class SysRolePermission
        {
             public const int Id = 117;
             public const int PermissionId = 118;
             public const int RoleId = 119;
        }
        /// <summary>
        ///     Property keys for Customers
        /// </summary>
        public abstract class Customers
        {
             public const int Id = 126;
             public const int Address = 127;
             public const int City = 128;
             public const int CompanyName = 129;
             public const int ContactName = 130;
             public const int ContactTitle = 131;
             public const int Country = 132;
             public const int Fax = 133;
             public const int Phone = 134;
             public const int PostalCode = 135;
             public const int Region = 136;
        }
        /// <summary>
        ///     Property keys for Categories
        /// </summary>
        public abstract class Categories
        {
             public const int Id = 141;
             public const int CategoryName = 142;
             public const int Description = 143;
             public const int Picture = 144;
        }
        /// <summary>
        ///     Property keys for Region
        /// </summary>
        public abstract class Region
        {
             public const int Id = 149;
             public const int RegionDescription = 150;
        }
        /// <summary>
        ///     Property keys for Suppliers
        /// </summary>
        public abstract class Suppliers
        {
             public const int Id = 155;
             public const int Address = 156;
             public const int City = 157;
             public const int CompanyName = 158;
             public const int ContactName = 159;
             public const int ContactTitle = 160;
             public const int Country = 161;
             public const int Fax = 162;
             public const int HomePage = 163;
             public const int Phone = 164;
             public const int PostalCode = 165;
             public const int Region = 166;
        }
        /// <summary>
        ///     Property keys for SysOperationLock
        /// </summary>
        public abstract class SysOperationLock
        {
             public const int OperationName = 171;
             public const int OperationContext = 172;
             public const int AquiredTime = 173;
             public const int ExpirationTime = 174;
             public const int MachineName = 175;
             public const int ProcessId = 176;
             public const int UserId = 178;
        }
        /// <summary>
        ///     Property keys for SysUserRole
        /// </summary>
        public abstract class SysUserRole
        {
             public const int Id = 180;
             public const int RoleId = 181;
             public const int UserId = 184;
        }
        /// <summary>
        ///     Property keys for Orders
        /// </summary>
        public abstract class Orders
        {
             public const int Id = 189;
             public const int CustomerID = 190;
             public const int EmployeeID = 192;
             public const int Freight = 194;
             public const int OrderDate = 195;
             public const int RequiredDate = 197;
             public const int ShipAddress = 198;
             public const int ShipCity = 199;
             public const int ShipCountry = 200;
             public const int ShipName = 201;
             public const int ShippedDate = 202;
             public const int ShipPostalCode = 204;
             public const int ShipRegion = 205;
             public const int ShipVia = 206;
        }
        /// <summary>
        ///     Property keys for SysPermission
        /// </summary>
        public abstract class SysPermission
        {
             public const int Id = 208;
             public const int CodeName = 209;
             public const int Description = 210;
             public const int DisplayName = 211;
             public const int Guid = 212;
             public const int ObjectId = 213;
             public const int Type = 216;
        }
        /// <summary>
        ///     Property keys for OrderDetails
        /// </summary>
        public abstract class OrderDetails
        {
             public const int OrderID = 221;
             public const int ProductID = 222;
             public const int Discount = 223;
             public const int Quantity = 226;
             public const int UnitPrice = 227;
        }
        /// <summary>
        ///     Property keys for SysSetting
        /// </summary>
        public abstract class SysSetting
        {
             public const int Id = 232;
             public const int SettingPropertyId = 233;
             public const int StringValue = 234;
             public const int UserId = 237;
        }
        /// <summary>
        ///     Property keys for SysInfo
        /// </summary>
        public abstract class SysInfo
        {
             public const int SystemVersion = 239;
             public const int DomainVersion = 240;
             public const int LastInitialization = 241;
        }
        /// <summary>
        ///     Property keys for Employees
        /// </summary>
        public abstract class Employees
        {
             public const int Id = 246;
             public const int Address = 247;
             public const int BirthDate = 248;
             public const int City = 249;
             public const int Country = 250;
             public const int DocumentScanFileId = 251;
             public const int Extension = 252;
             public const int FirstName = 253;
             public const int HireDate = 254;
             public const int HomePhone = 255;
             public const int LastName = 256;
             public const int Notes = 257;
             public const int Photo = 258;
             public const int PhotoPath = 259;
             public const int PostalCode = 260;
             public const int Region = 261;
             public const int ReportsTo = 262;
             public const int Title = 264;
             public const int TitleOfCourtesy = 265;
        }
        /// <summary>
        ///     Property keys for SysObjectType
        /// </summary>
        public abstract class SysObjectType
        {
             public const int Id = 267;
             public const int Name = 268;
        }
        /// <summary>
        ///     Property keys for SysObjectClass
        /// </summary>
        public abstract class SysObjectClass
        {
             public const int Id = 270;
             public const int CodeName = 271;
             public const int Description = 272;
             public const int DisplayName = 273;
        }
        /// <summary>
        ///     Property keys for CustomerDemographic
        /// </summary>
        public abstract class CustomerDemographic
        {
             public const int Id = 278;
             public const int CustomerDesc = 279;
        }
        /// <summary>
        ///     Property keys for SysPermissionType
        /// </summary>
        public abstract class SysPermissionType
        {
             public const int Id = 281;
             public const int CodeName = 282;
             public const int Description = 283;
             public const int DisplayName = 284;
        }
        /// <summary>
        ///     Property keys for SysSettingProperty
        /// </summary>
        public abstract class SysSettingProperty
        {
             public const int Id = 289;
             public const int DefaultType = 290;
             public const int Description = 291;
             public const int GroupName = 292;
             public const int IsManaged = 293;
             public const int IsOverridable = 294;
             public const int Name = 295;
             public const int UIEditorType = 296;
        }
        /// <summary>
        ///     Property keys for SysUsersDisplayView
        /// </summary>
        public abstract class SysUsersDisplayView
        {
             public const int Id = 298;
             public const int UserRoleId = 300;
        }
        /// <summary>
        ///     Property keys for Shippers
        /// </summary>
        public abstract class Shippers
        {
             public const int Id = 305;
             public const int CompanyName = 306;
             public const int Phone = 307;
        }
        /// <summary>
        ///     Property keys for SupplierQuery
        /// </summary>
        public abstract class SupplierQuery
        {
             public const int Id = 309;
             public const int Address = 310;
             public const int City = 311;
             public const int CompanyName = 312;
             public const int ContactName = 313;
             public const int ContactTitle = 314;
             public const int Country = 315;
             public const int Fax = 316;
             public const int HomePage = 317;
             public const int Phone = 318;
             public const int PostalCode = 319;
             public const int Region = 320;
        }
        /// <summary>
        ///     Property keys for EmployeeQuery
        /// </summary>
        public abstract class EmployeeQuery
        {
             public const int Id = 322;
             public const int Address = 323;
             public const int BirthDate = 324;
             public const int City = 325;
             public const int Country = 326;
             public const int DocumentScanFileId = 327;
             public const int Employee_FullName = 328;
             public const int Extension = 329;
             public const int FirstName = 330;
             public const int HireDate = 331;
             public const int HomePhone = 332;
             public const int LastName = 333;
             public const int Notes = 334;
             public const int Photo = 335;
             public const int PostalCode = 336;
             public const int Region = 337;
             public const int ReportsTo = 338;
             public const int Title = 339;
             public const int TitleOfCourtesy = 340;
        }
        /// <summary>
        ///     Property keys for ShipperQuery
        /// </summary>
        public abstract class ShipperQuery
        {
             public const int Id = 342;
             public const int CompanyName = 343;
             public const int Phone = 344;
        }
        /// <summary>
        ///     Property keys for CategoryQuery
        /// </summary>
        public abstract class CategoryQuery
        {
             public const int Id = 346;
             public const int CategoryName = 347;
             public const int Description = 348;
             public const int Picture = 349;
        }
        /// <summary>
        ///     Property keys for ReportFormQuery
        /// </summary>
        public abstract class ReportFormQuery
        {
             public const int Id = 352;
             public const int CustomerId = 353;
             public const int EmployeeId = 354;
             public const int From = 355;
             public const int To = 356;
             public const int useExcel = 357;
        }
        /// <summary>
        ///     Property keys for CustomerQuery
        /// </summary>
        public abstract class CustomerQuery
        {
             public const int Id = 359;
             public const int Address = 360;
             public const int City = 361;
             public const int CompanyName = 362;
             public const int ContactName = 363;
             public const int ContactTitle = 364;
             public const int Country = 365;
             public const int Fax = 366;
             public const int Phone = 367;
             public const int PostalCode = 368;
             public const int Region = 369;
        }
        /// <summary>
        ///     Property keys for ProductQuery
        /// </summary>
        public abstract class ProductQuery
        {
             public const int Id = 371;
             public const int Categories_CategoryName = 372;
             public const int Categories_Description = 373;
             public const int Categories_Id = 374;
             public const int CategoryID = 375;
             public const int Discontinued = 376;
             public const int ProductName = 377;
             public const int QuantityPerUnit = 378;
             public const int ReorderLevel = 379;
             public const int SupplierID = 380;
             public const int Suppliers_Address = 381;
             public const int Suppliers_City = 382;
             public const int Suppliers_CompanyName = 383;
             public const int Suppliers_ContactName = 384;
             public const int Suppliers_ContactTitle = 385;
             public const int Suppliers_Country = 386;
             public const int Suppliers_Fax = 387;
             public const int Suppliers_HomePage = 388;
             public const int Suppliers_Id = 389;
             public const int Suppliers_Phone = 390;
             public const int Suppliers_PostalCode = 391;
             public const int Suppliers_Region = 392;
             public const int UnitPrice = 393;
             public const int UnitsInStock = 394;
             public const int UnitsOnOrder = 395;
        }
        /// <summary>
        ///     Property keys for OrderProductQuery
        /// </summary>
        public abstract class OrderProductQuery
        {
             public const int Id = 397;
             public const int OrderID = 398;
             public const int ProductID = 399;
             public const int Discount = 400;
             public const int Orders_CustomerID = 401;
             public const int Orders_EmployeeID = 402;
             public const int Orders_Freight = 403;
             public const int Orders_Id = 404;
             public const int Orders_OrderDate = 405;
             public const int Orders_RequiredDate = 406;
             public const int Orders_ShipAddress = 407;
             public const int Orders_ShipCity = 408;
             public const int Orders_ShipCountry = 409;
             public const int Orders_ShipName = 410;
             public const int Orders_ShippedDate = 411;
             public const int Orders_ShipPostalCode = 412;
             public const int Orders_ShipRegion = 413;
             public const int Orders_ShipVia = 414;
             public const int Products_CategoryID = 415;
             public const int Products_Discontinued = 416;
             public const int Products_Id = 417;
             public const int Products_ProductName = 418;
             public const int Products_QuantityPerUnit = 419;
             public const int Products_ReorderLevel = 420;
             public const int Products_SupplierID = 421;
             public const int Products_UnitPrice = 422;
             public const int Products_UnitsInStock = 423;
             public const int Products_UnitsOnOrder = 424;
             public const int Quantity = 425;
             public const int UnitPrice = 426;
        }
        /// <summary>
        ///     Property keys for OrdersQuery
        /// </summary>
        public abstract class OrdersQuery
        {
             public const int Id = 428;
             public const int CustomerID = 429;
             public const int Customers_Address = 430;
             public const int Customers_City = 431;
             public const int Customers_CompanyName = 432;
             public const int Customers_ContactName = 433;
             public const int Customers_ContactTitle = 434;
             public const int Customers_Country = 435;
             public const int Customers_Fax = 436;
             public const int Customers_Id = 437;
             public const int Customers_Phone = 438;
             public const int Customers_PostalCode = 439;
             public const int Customers_Region = 440;
             public const int EmployeeFullName = 441;
             public const int EmployeeID = 442;
             public const int Employees_Address = 443;
             public const int Employees_BirthDate = 444;
             public const int Employees_City = 445;
             public const int Employees_Country = 446;
             public const int Employees_Extension = 447;
             public const int Employees_FirstName = 448;
             public const int Employees_HireDate = 449;
             public const int Employees_HomePhone = 450;
             public const int Employees_Id = 451;
             public const int Employees_LastName = 452;
             public const int Employees_Notes = 453;
             public const int Employees_PhotoPath = 454;
             public const int Employees_PostalCode = 455;
             public const int Employees_Region = 456;
             public const int Employees_ReportsTo = 457;
             public const int Employees_Title = 458;
             public const int Employees_TitleOfCourtesy = 459;
             public const int Freight = 460;
             public const int OrderDate = 461;
             public const int RequiredDate = 462;
             public const int ShipAddress = 463;
             public const int ShipCity = 464;
             public const int ShipCountry = 465;
             public const int ShipName = 466;
             public const int ShippedDate = 467;
             public const int Shippers_CompanyName = 468;
             public const int Shippers_Id = 469;
             public const int Shippers_Phone = 470;
             public const int ShipPostalCode = 471;
             public const int ShipRegion = 472;
             public const int ShipVia = 473;
        }
        /// <summary>
        ///     Property keys for RegionQuery
        /// </summary>
        public abstract class RegionQuery
        {
             public const int Id = 475;
             public const int RegionDescription = 476;
        }
    }
}
using System;
using BusinessFramework.WebAPI.Contracts.Files;
using BusinessFramework.WebAPI.Contracts.Metadata;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain objects
    /// </summary>
    public static class DomainObjects
    {
        public static readonly CategoriesDomainObject Categories = new CategoriesDomainObject();
        public static readonly CategoryQueryDomainObject CategoryQuery = new CategoryQueryDomainObject();
        public static readonly CustomerCustomerDemoDomainObject CustomerCustomerDemo = new CustomerCustomerDemoDomainObject();
        public static readonly CustomerDemographicDomainObject CustomerDemographic = new CustomerDemographicDomainObject();
        public static readonly CustomerQueryDomainObject CustomerQuery = new CustomerQueryDomainObject();
        public static readonly CustomersDomainObject Customers = new CustomersDomainObject();
        public static readonly EmployeeQueryDomainObject EmployeeQuery = new EmployeeQueryDomainObject();
        public static readonly EmployeesDomainObject Employees = new EmployeesDomainObject();
        public static readonly EmployeeTerritoryDomainObject EmployeeTerritory = new EmployeeTerritoryDomainObject();
        public static readonly OrderDetailsDomainObject OrderDetails = new OrderDetailsDomainObject();
        public static readonly OrderProductQueryDomainObject OrderProductQuery = new OrderProductQueryDomainObject();
        public static readonly OrdersDomainObject Orders = new OrdersDomainObject();
        public static readonly OrdersQueryDomainObject OrdersQuery = new OrdersQueryDomainObject();
        public static readonly ProductQueryDomainObject ProductQuery = new ProductQueryDomainObject();
        public static readonly ProductsDomainObject Products = new ProductsDomainObject();
        public static readonly RegionDomainObject Region = new RegionDomainObject();
        public static readonly RegionQueryDomainObject RegionQuery = new RegionQueryDomainObject();
        public static readonly ReportFormQueryDomainObject ReportFormQuery = new ReportFormQueryDomainObject();
        public static readonly ShipperQueryDomainObject ShipperQuery = new ShipperQueryDomainObject();
        public static readonly ShippersDomainObject Shippers = new ShippersDomainObject();
        public static readonly SupplierQueryDomainObject SupplierQuery = new SupplierQueryDomainObject();
        public static readonly SuppliersDomainObject Suppliers = new SuppliersDomainObject();
        public static readonly SysInfoDomainObject SysInfo = new SysInfoDomainObject();
        public static readonly SysObjectDomainObject SysObject = new SysObjectDomainObject();
        public static readonly SysObjectClassDomainObject SysObjectClass = new SysObjectClassDomainObject();
        public static readonly SysObjectTypeDomainObject SysObjectType = new SysObjectTypeDomainObject();
        public static readonly SysOperationDomainObject SysOperation = new SysOperationDomainObject();
        public static readonly SysOperationLockDomainObject SysOperationLock = new SysOperationLockDomainObject();
        public static readonly SysOperationResultDomainObject SysOperationResult = new SysOperationResultDomainObject();
        public static readonly SysPermissionDomainObject SysPermission = new SysPermissionDomainObject();
        public static readonly SysPermissionTypeDomainObject SysPermissionType = new SysPermissionTypeDomainObject();
        public static readonly SysRefreshTokenDomainObject SysRefreshToken = new SysRefreshTokenDomainObject();
        public static readonly SysResetPasswordTokenDomainObject SysResetPasswordToken = new SysResetPasswordTokenDomainObject();
        public static readonly SysRoleDomainObject SysRole = new SysRoleDomainObject();
        public static readonly SysRolePermissionDomainObject SysRolePermission = new SysRolePermissionDomainObject();
        public static readonly SysSettingDomainObject SysSetting = new SysSettingDomainObject();
        public static readonly SysSettingPropertyDomainObject SysSettingProperty = new SysSettingPropertyDomainObject();
        public static readonly SysUserDomainObject SysUser = new SysUserDomainObject();
        public static readonly SysUserPermissionsDisplayViewDomainObject SysUserPermissionsDisplayView = new SysUserPermissionsDisplayViewDomainObject();
        public static readonly SysUserRoleDomainObject SysUserRole = new SysUserRoleDomainObject();
        public static readonly SysUsersDisplayViewDomainObject SysUsersDisplayView = new SysUsersDisplayViewDomainObject();
        public static readonly TerritoryDomainObject Territory = new TerritoryDomainObject();
        public static readonly DomainMetadataDictionary ObjResolver = new DomainMetadataDictionary(Categories, CategoryQuery, CustomerCustomerDemo, CustomerDemographic, CustomerQuery, Customers, EmployeeQuery, Employees, EmployeeTerritory, OrderDetails, OrderProductQuery, Orders, OrdersQuery, ProductQuery, Products, Region, RegionQuery, ReportFormQuery, ShipperQuery, Shippers, SupplierQuery, Suppliers, SysInfo, SysObject, SysObjectClass, SysObjectType, SysOperation, SysOperationLock, SysOperationResult, SysPermission, SysPermissionType, SysRefreshToken, SysResetPasswordToken, SysRole, SysRolePermission, SysSetting, SysSettingProperty, SysUser, SysUserPermissionsDisplayView, SysUserRole, SysUsersDisplayView, Territory);
    }
    


    //--
    #region Categories

    public sealed class CategoriesDomainObject : DomainObject<Categories, CategoriesDomainObject>
    {
        public CategoriesDomainObject()
            : base("Categories", DomainObjectKeys.Categories, 4, false)
        {
            CategoryName = AddProperty(new DomainProperty<string, Categories, CategoriesDomainObject>("CategoryName", DomainObjectPropertyKeys.Categories.CategoryName, this, false, false));
            Description = AddProperty(new DomainProperty<string, Categories, CategoriesDomainObject>("Description", DomainObjectPropertyKeys.Categories.Description, this, false, false));
            Id = AddProperty(new DomainProperty<int, Categories, CategoriesDomainObject>("Id", DomainObjectPropertyKeys.Categories.Id, this, false, false));
            Picture = AddProperty(new DomainProperty<byte[], Categories, CategoriesDomainObject>("Picture", DomainObjectPropertyKeys.Categories.Picture, this, false, false));
        }

        
        public DomainProperty<string, Categories, CategoriesDomainObject> CategoryName { get; private set; }

        public DomainProperty<string, Categories, CategoriesDomainObject> Description { get; private set; }

        public DomainProperty<int, Categories, CategoriesDomainObject> Id { get; private set; }

        public DomainProperty<byte[], Categories, CategoriesDomainObject> Picture { get; private set; }
    }
    #endregion
    #region CategoryQuery

    public sealed class CategoryQueryDomainObject : DomainObject<CategoryQuery, CategoryQueryDomainObject>
    {
        public CategoryQueryDomainObject()
            : base("CategoryQuery", DomainObjectKeys.CategoryQuery, 4, false)
        {
            CategoryName = AddProperty(new DomainProperty<string, CategoryQuery, CategoryQueryDomainObject>("CategoryName", DomainObjectPropertyKeys.CategoryQuery.CategoryName, this, false, false));
            Description = AddProperty(new DomainProperty<string, CategoryQuery, CategoryQueryDomainObject>("Description", DomainObjectPropertyKeys.CategoryQuery.Description, this, false, false));
            Id = AddProperty(new DomainProperty<int, CategoryQuery, CategoryQueryDomainObject>("Id", DomainObjectPropertyKeys.CategoryQuery.Id, this, false, false));
            Picture = AddProperty(new DomainProperty<byte[], CategoryQuery, CategoryQueryDomainObject>("Picture", DomainObjectPropertyKeys.CategoryQuery.Picture, this, false, false));
        }

        
        public DomainProperty<string, CategoryQuery, CategoryQueryDomainObject> CategoryName { get; private set; }

        public DomainProperty<string, CategoryQuery, CategoryQueryDomainObject> Description { get; private set; }

        public DomainProperty<int, CategoryQuery, CategoryQueryDomainObject> Id { get; private set; }

        public DomainProperty<byte[], CategoryQuery, CategoryQueryDomainObject> Picture { get; private set; }
    }
    #endregion
    #region CustomerCustomerDemo

    public sealed class CustomerCustomerDemoDomainObject : DomainObject<CustomerCustomerDemo, CustomerCustomerDemoDomainObject>
    {
        public CustomerCustomerDemoDomainObject()
            : base("CustomerCustomerDemo", DomainObjectKeys.CustomerCustomerDemo, 2, false)
        {
            CustomerID = AddProperty(new DomainProperty<int, CustomerCustomerDemo, CustomerCustomerDemoDomainObject>("CustomerID", DomainObjectPropertyKeys.CustomerCustomerDemo.CustomerID, this, false, false));
            CustomerTypeID = AddProperty(new DomainProperty<int, CustomerCustomerDemo, CustomerCustomerDemoDomainObject>("CustomerTypeID", DomainObjectPropertyKeys.CustomerCustomerDemo.CustomerTypeID, this, false, false));
        }

        
        public DomainProperty<int, CustomerCustomerDemo, CustomerCustomerDemoDomainObject> CustomerID { get; private set; }

        public DomainProperty<int, CustomerCustomerDemo, CustomerCustomerDemoDomainObject> CustomerTypeID { get; private set; }
    }
    #endregion
    #region CustomerDemographic

    public sealed class CustomerDemographicDomainObject : DomainObject<CustomerDemographic, CustomerDemographicDomainObject>
    {
        public CustomerDemographicDomainObject()
            : base("CustomerDemographic", DomainObjectKeys.CustomerDemographic, 2, false)
        {
            CustomerDesc = AddProperty(new DomainProperty<string, CustomerDemographic, CustomerDemographicDomainObject>("CustomerDesc", DomainObjectPropertyKeys.CustomerDemographic.CustomerDesc, this, false, false));
            Id = AddProperty(new DomainProperty<int, CustomerDemographic, CustomerDemographicDomainObject>("Id", DomainObjectPropertyKeys.CustomerDemographic.Id, this, false, false));
        }

        
        public DomainProperty<string, CustomerDemographic, CustomerDemographicDomainObject> CustomerDesc { get; private set; }

        public DomainProperty<int, CustomerDemographic, CustomerDemographicDomainObject> Id { get; private set; }
    }
    #endregion
    #region CustomerQuery

    public sealed class CustomerQueryDomainObject : DomainObject<CustomerQuery, CustomerQueryDomainObject>
    {
        public CustomerQueryDomainObject()
            : base("CustomerQuery", DomainObjectKeys.CustomerQuery, 11, false)
        {
            Address = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("Address", DomainObjectPropertyKeys.CustomerQuery.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("City", DomainObjectPropertyKeys.CustomerQuery.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("CompanyName", DomainObjectPropertyKeys.CustomerQuery.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("ContactName", DomainObjectPropertyKeys.CustomerQuery.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("ContactTitle", DomainObjectPropertyKeys.CustomerQuery.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("Country", DomainObjectPropertyKeys.CustomerQuery.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("Fax", DomainObjectPropertyKeys.CustomerQuery.Fax, this, false, false));
            Id = AddProperty(new DomainProperty<int, CustomerQuery, CustomerQueryDomainObject>("Id", DomainObjectPropertyKeys.CustomerQuery.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("Phone", DomainObjectPropertyKeys.CustomerQuery.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("PostalCode", DomainObjectPropertyKeys.CustomerQuery.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, CustomerQuery, CustomerQueryDomainObject>("Region", DomainObjectPropertyKeys.CustomerQuery.Region, this, false, false));
        }

        
        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> Address { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> City { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> ContactName { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> Country { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> Fax { get; private set; }

        public DomainProperty<int, CustomerQuery, CustomerQueryDomainObject> Id { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> Phone { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, CustomerQuery, CustomerQueryDomainObject> Region { get; private set; }
    }
    #endregion
    #region Customers

    public sealed class CustomersDomainObject : DomainObject<Customers, CustomersDomainObject>
    {
        public CustomersDomainObject()
            : base("Customers", DomainObjectKeys.Customers, 11, false)
        {
            Address = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("Address", DomainObjectPropertyKeys.Customers.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("City", DomainObjectPropertyKeys.Customers.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("CompanyName", DomainObjectPropertyKeys.Customers.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("ContactName", DomainObjectPropertyKeys.Customers.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("ContactTitle", DomainObjectPropertyKeys.Customers.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("Country", DomainObjectPropertyKeys.Customers.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("Fax", DomainObjectPropertyKeys.Customers.Fax, this, false, false));
            Id = AddProperty(new DomainProperty<int, Customers, CustomersDomainObject>("Id", DomainObjectPropertyKeys.Customers.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("Phone", DomainObjectPropertyKeys.Customers.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("PostalCode", DomainObjectPropertyKeys.Customers.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, Customers, CustomersDomainObject>("Region", DomainObjectPropertyKeys.Customers.Region, this, false, false));
        }

        
        public DomainProperty<string, Customers, CustomersDomainObject> Address { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> City { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> ContactName { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> Country { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> Fax { get; private set; }

        public DomainProperty<int, Customers, CustomersDomainObject> Id { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> Phone { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, Customers, CustomersDomainObject> Region { get; private set; }
    }
    #endregion
    #region EmployeeQuery

    public sealed class EmployeeQueryDomainObject : DomainObject<EmployeeQuery, EmployeeQueryDomainObject>
    {
        public EmployeeQueryDomainObject()
            : base("EmployeeQuery", DomainObjectKeys.EmployeeQuery, 20, false)
        {
            Address = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Address", DomainObjectPropertyKeys.EmployeeQuery.Address, this, false, false));
            BirthDate = AddProperty(new DomainProperty<DateTime?, EmployeeQuery, EmployeeQueryDomainObject>("BirthDate", DomainObjectPropertyKeys.EmployeeQuery.BirthDate, this, false, false));
            City = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("City", DomainObjectPropertyKeys.EmployeeQuery.City, this, false, false));
            Country = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Country", DomainObjectPropertyKeys.EmployeeQuery.Country, this, false, false));
            DocumentScanFileId = AddProperty(new DomainProperty<FileLink, EmployeeQuery, EmployeeQueryDomainObject>("DocumentScanFileId", DomainObjectPropertyKeys.EmployeeQuery.DocumentScanFileId, this, false, false));
            Employee_FullName = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Employee_FullName", DomainObjectPropertyKeys.EmployeeQuery.Employee_FullName, this, false, false));
            Extension = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Extension", DomainObjectPropertyKeys.EmployeeQuery.Extension, this, false, false));
            FileLink_DocumentScanFileId = AddProperty(new DomainProperty<int, EmployeeQuery, EmployeeQueryDomainObject>("FileLink_DocumentScanFileId", DomainObjectPropertyKeys.EmployeeQuery.DocumentScanFileId, this, true, false));
            FirstName = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("FirstName", DomainObjectPropertyKeys.EmployeeQuery.FirstName, this, false, false));
            HireDate = AddProperty(new DomainProperty<DateTime?, EmployeeQuery, EmployeeQueryDomainObject>("HireDate", DomainObjectPropertyKeys.EmployeeQuery.HireDate, this, false, false));
            HomePhone = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("HomePhone", DomainObjectPropertyKeys.EmployeeQuery.HomePhone, this, false, false));
            Id = AddProperty(new DomainProperty<int, EmployeeQuery, EmployeeQueryDomainObject>("Id", DomainObjectPropertyKeys.EmployeeQuery.Id, this, false, false));
            LastName = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("LastName", DomainObjectPropertyKeys.EmployeeQuery.LastName, this, false, false));
            Notes = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Notes", DomainObjectPropertyKeys.EmployeeQuery.Notes, this, false, false));
            Photo = AddProperty(new DomainProperty<byte[], EmployeeQuery, EmployeeQueryDomainObject>("Photo", DomainObjectPropertyKeys.EmployeeQuery.Photo, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("PostalCode", DomainObjectPropertyKeys.EmployeeQuery.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Region", DomainObjectPropertyKeys.EmployeeQuery.Region, this, false, false));
            ReportsTo = AddProperty(new DomainProperty<int?, EmployeeQuery, EmployeeQueryDomainObject>("ReportsTo", DomainObjectPropertyKeys.EmployeeQuery.ReportsTo, this, false, false));
            Title = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("Title", DomainObjectPropertyKeys.EmployeeQuery.Title, this, false, false));
            TitleOfCourtesy = AddProperty(new DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject>("TitleOfCourtesy", DomainObjectPropertyKeys.EmployeeQuery.TitleOfCourtesy, this, false, false));
        }

        
        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Address { get; private set; }

        public DomainProperty<DateTime?, EmployeeQuery, EmployeeQueryDomainObject> BirthDate { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> City { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Country { get; private set; }

        public DomainProperty<FileLink, EmployeeQuery, EmployeeQueryDomainObject> DocumentScanFileId { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Employee_FullName { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Extension { get; private set; }

        public DomainProperty<int, EmployeeQuery, EmployeeQueryDomainObject> FileLink_DocumentScanFileId { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> FirstName { get; private set; }

        public DomainProperty<DateTime?, EmployeeQuery, EmployeeQueryDomainObject> HireDate { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> HomePhone { get; private set; }

        public DomainProperty<int, EmployeeQuery, EmployeeQueryDomainObject> Id { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> LastName { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Notes { get; private set; }

        public DomainProperty<byte[], EmployeeQuery, EmployeeQueryDomainObject> Photo { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Region { get; private set; }

        public DomainProperty<int?, EmployeeQuery, EmployeeQueryDomainObject> ReportsTo { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> Title { get; private set; }

        public DomainProperty<string, EmployeeQuery, EmployeeQueryDomainObject> TitleOfCourtesy { get; private set; }
    }
    #endregion
    #region Employees

    public sealed class EmployeesDomainObject : DomainObject<Employees, EmployeesDomainObject>
    {
        public EmployeesDomainObject()
            : base("Employees", DomainObjectKeys.Employees, 20, false)
        {
            Address = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("Address", DomainObjectPropertyKeys.Employees.Address, this, false, false));
            BirthDate = AddProperty(new DomainProperty<DateTime?, Employees, EmployeesDomainObject>("BirthDate", DomainObjectPropertyKeys.Employees.BirthDate, this, false, false));
            City = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("City", DomainObjectPropertyKeys.Employees.City, this, false, false));
            Country = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("Country", DomainObjectPropertyKeys.Employees.Country, this, false, false));
            DocumentScanFileId = AddProperty(new DomainProperty<FileLink, Employees, EmployeesDomainObject>("DocumentScanFileId", DomainObjectPropertyKeys.Employees.DocumentScanFileId, this, false, false));
            Extension = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("Extension", DomainObjectPropertyKeys.Employees.Extension, this, false, false));
            FileLink_DocumentScanFileId = AddProperty(new DomainProperty<int, Employees, EmployeesDomainObject>("FileLink_DocumentScanFileId", DomainObjectPropertyKeys.Employees.DocumentScanFileId, this, true, false));
            FirstName = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("FirstName", DomainObjectPropertyKeys.Employees.FirstName, this, false, false));
            HireDate = AddProperty(new DomainProperty<DateTime?, Employees, EmployeesDomainObject>("HireDate", DomainObjectPropertyKeys.Employees.HireDate, this, false, false));
            HomePhone = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("HomePhone", DomainObjectPropertyKeys.Employees.HomePhone, this, false, false));
            Id = AddProperty(new DomainProperty<int, Employees, EmployeesDomainObject>("Id", DomainObjectPropertyKeys.Employees.Id, this, false, false));
            LastName = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("LastName", DomainObjectPropertyKeys.Employees.LastName, this, false, false));
            Notes = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("Notes", DomainObjectPropertyKeys.Employees.Notes, this, false, false));
            Photo = AddProperty(new DomainProperty<byte[], Employees, EmployeesDomainObject>("Photo", DomainObjectPropertyKeys.Employees.Photo, this, false, false));
            PhotoPath = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("PhotoPath", DomainObjectPropertyKeys.Employees.PhotoPath, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("PostalCode", DomainObjectPropertyKeys.Employees.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("Region", DomainObjectPropertyKeys.Employees.Region, this, false, false));
            ReportsTo = AddProperty(new DomainProperty<int?, Employees, EmployeesDomainObject>("ReportsTo", DomainObjectPropertyKeys.Employees.ReportsTo, this, false, false));
            Title = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("Title", DomainObjectPropertyKeys.Employees.Title, this, false, false));
            TitleOfCourtesy = AddProperty(new DomainProperty<string, Employees, EmployeesDomainObject>("TitleOfCourtesy", DomainObjectPropertyKeys.Employees.TitleOfCourtesy, this, false, false));
        }

        
        public DomainProperty<string, Employees, EmployeesDomainObject> Address { get; private set; }

        public DomainProperty<DateTime?, Employees, EmployeesDomainObject> BirthDate { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> City { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> Country { get; private set; }

        public DomainProperty<FileLink, Employees, EmployeesDomainObject> DocumentScanFileId { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> Extension { get; private set; }

        public DomainProperty<int, Employees, EmployeesDomainObject> FileLink_DocumentScanFileId { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> FirstName { get; private set; }

        public DomainProperty<DateTime?, Employees, EmployeesDomainObject> HireDate { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> HomePhone { get; private set; }

        public DomainProperty<int, Employees, EmployeesDomainObject> Id { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> LastName { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> Notes { get; private set; }

        public DomainProperty<byte[], Employees, EmployeesDomainObject> Photo { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> PhotoPath { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> Region { get; private set; }

        public DomainProperty<int?, Employees, EmployeesDomainObject> ReportsTo { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> Title { get; private set; }

        public DomainProperty<string, Employees, EmployeesDomainObject> TitleOfCourtesy { get; private set; }
    }
    #endregion
    #region EmployeeTerritory

    public sealed class EmployeeTerritoryDomainObject : DomainObject<EmployeeTerritory, EmployeeTerritoryDomainObject>
    {
        public EmployeeTerritoryDomainObject()
            : base("EmployeeTerritory", DomainObjectKeys.EmployeeTerritory, 2, false)
        {
            EmployeeID = AddProperty(new DomainProperty<int, EmployeeTerritory, EmployeeTerritoryDomainObject>("EmployeeID", DomainObjectPropertyKeys.EmployeeTerritory.EmployeeID, this, false, false));
            TerritoryID = AddProperty(new DomainProperty<int, EmployeeTerritory, EmployeeTerritoryDomainObject>("TerritoryID", DomainObjectPropertyKeys.EmployeeTerritory.TerritoryID, this, false, false));
        }

        
        public DomainProperty<int, EmployeeTerritory, EmployeeTerritoryDomainObject> EmployeeID { get; private set; }

        public DomainProperty<int, EmployeeTerritory, EmployeeTerritoryDomainObject> TerritoryID { get; private set; }
    }
    #endregion
    #region OrderDetails

    public sealed class OrderDetailsDomainObject : DomainObject<OrderDetails, OrderDetailsDomainObject>
    {
        public OrderDetailsDomainObject()
            : base("OrderDetails", DomainObjectKeys.OrderDetails, 5, false)
        {
            Discount = AddProperty(new DomainProperty<float, OrderDetails, OrderDetailsDomainObject>("Discount", DomainObjectPropertyKeys.OrderDetails.Discount, this, false, false));
            OrderID = AddProperty(new DomainProperty<int, OrderDetails, OrderDetailsDomainObject>("OrderID", DomainObjectPropertyKeys.OrderDetails.OrderID, this, false, false));
            ProductID = AddProperty(new DomainProperty<int, OrderDetails, OrderDetailsDomainObject>("ProductID", DomainObjectPropertyKeys.OrderDetails.ProductID, this, false, false));
            Quantity = AddProperty(new DomainProperty<short, OrderDetails, OrderDetailsDomainObject>("Quantity", DomainObjectPropertyKeys.OrderDetails.Quantity, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal, OrderDetails, OrderDetailsDomainObject>("UnitPrice", DomainObjectPropertyKeys.OrderDetails.UnitPrice, this, false, false));
        }

        
        public DomainProperty<float, OrderDetails, OrderDetailsDomainObject> Discount { get; private set; }

        public DomainProperty<int, OrderDetails, OrderDetailsDomainObject> OrderID { get; private set; }

        public DomainProperty<int, OrderDetails, OrderDetailsDomainObject> ProductID { get; private set; }

        public DomainProperty<short, OrderDetails, OrderDetailsDomainObject> Quantity { get; private set; }

        public DomainProperty<decimal, OrderDetails, OrderDetailsDomainObject> UnitPrice { get; private set; }
    }
    #endregion
    #region OrderProductQuery

    public sealed class OrderProductQueryDomainObject : DomainObject<OrderProductQuery, OrderProductQueryDomainObject>
    {
        public OrderProductQueryDomainObject()
            : base("OrderProductQuery", DomainObjectKeys.OrderProductQuery, 30, false)
        {
            Discount = AddProperty(new DomainProperty<float, OrderProductQuery, OrderProductQueryDomainObject>("Discount", DomainObjectPropertyKeys.OrderProductQuery.Discount, this, false, false));
            Id = AddProperty(new DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject>("Id", DomainObjectPropertyKeys.OrderProductQuery.Id, this, false, false));
            OrderID = AddProperty(new DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject>("OrderID", DomainObjectPropertyKeys.OrderProductQuery.OrderID, this, false, false));
            Orders_CustomerID = AddProperty(new DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject>("Orders_CustomerID", DomainObjectPropertyKeys.OrderProductQuery.Orders_CustomerID, this, false, false));
            Orders_EmployeeID = AddProperty(new DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject>("Orders_EmployeeID", DomainObjectPropertyKeys.OrderProductQuery.Orders_EmployeeID, this, false, false));
            Orders_Freight = AddProperty(new DomainProperty<decimal?, OrderProductQuery, OrderProductQueryDomainObject>("Orders_Freight", DomainObjectPropertyKeys.OrderProductQuery.Orders_Freight, this, false, false));
            Orders_Id = AddProperty(new DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject>("Orders_Id", DomainObjectPropertyKeys.OrderProductQuery.Orders_Id, this, false, false));
            Orders_OrderDate = AddProperty(new DomainProperty<DateTime?, OrderProductQuery, OrderProductQueryDomainObject>("Orders_OrderDate", DomainObjectPropertyKeys.OrderProductQuery.Orders_OrderDate, this, false, false));
            Orders_RequiredDate = AddProperty(new DomainProperty<DateTime?, OrderProductQuery, OrderProductQueryDomainObject>("Orders_RequiredDate", DomainObjectPropertyKeys.OrderProductQuery.Orders_RequiredDate, this, false, false));
            Orders_ShipAddress = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipAddress", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipAddress, this, false, false));
            Orders_ShipCity = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipCity", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipCity, this, false, false));
            Orders_ShipCountry = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipCountry", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipCountry, this, false, false));
            Orders_ShipName = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipName", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipName, this, false, false));
            Orders_ShippedDate = AddProperty(new DomainProperty<DateTime?, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShippedDate", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShippedDate, this, false, false));
            Orders_ShipPostalCode = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipPostalCode", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipPostalCode, this, false, false));
            Orders_ShipRegion = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipRegion", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipRegion, this, false, false));
            Orders_ShipVia = AddProperty(new DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject>("Orders_ShipVia", DomainObjectPropertyKeys.OrderProductQuery.Orders_ShipVia, this, false, false));
            ProductID = AddProperty(new DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject>("ProductID", DomainObjectPropertyKeys.OrderProductQuery.ProductID, this, false, false));
            Products_CategoryID = AddProperty(new DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject>("Products_CategoryID", DomainObjectPropertyKeys.OrderProductQuery.Products_CategoryID, this, false, false));
            Products_Discontinued = AddProperty(new DomainProperty<bool, OrderProductQuery, OrderProductQueryDomainObject>("Products_Discontinued", DomainObjectPropertyKeys.OrderProductQuery.Products_Discontinued, this, false, false));
            Products_Id = AddProperty(new DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject>("Products_Id", DomainObjectPropertyKeys.OrderProductQuery.Products_Id, this, false, false));
            Products_ProductName = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Products_ProductName", DomainObjectPropertyKeys.OrderProductQuery.Products_ProductName, this, false, false));
            Products_QuantityPerUnit = AddProperty(new DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject>("Products_QuantityPerUnit", DomainObjectPropertyKeys.OrderProductQuery.Products_QuantityPerUnit, this, false, false));
            Products_ReorderLevel = AddProperty(new DomainProperty<short?, OrderProductQuery, OrderProductQueryDomainObject>("Products_ReorderLevel", DomainObjectPropertyKeys.OrderProductQuery.Products_ReorderLevel, this, false, false));
            Products_SupplierID = AddProperty(new DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject>("Products_SupplierID", DomainObjectPropertyKeys.OrderProductQuery.Products_SupplierID, this, false, false));
            Products_UnitPrice = AddProperty(new DomainProperty<decimal?, OrderProductQuery, OrderProductQueryDomainObject>("Products_UnitPrice", DomainObjectPropertyKeys.OrderProductQuery.Products_UnitPrice, this, false, false));
            Products_UnitsInStock = AddProperty(new DomainProperty<short?, OrderProductQuery, OrderProductQueryDomainObject>("Products_UnitsInStock", DomainObjectPropertyKeys.OrderProductQuery.Products_UnitsInStock, this, false, false));
            Products_UnitsOnOrder = AddProperty(new DomainProperty<short?, OrderProductQuery, OrderProductQueryDomainObject>("Products_UnitsOnOrder", DomainObjectPropertyKeys.OrderProductQuery.Products_UnitsOnOrder, this, false, false));
            Quantity = AddProperty(new DomainProperty<short, OrderProductQuery, OrderProductQueryDomainObject>("Quantity", DomainObjectPropertyKeys.OrderProductQuery.Quantity, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal, OrderProductQuery, OrderProductQueryDomainObject>("UnitPrice", DomainObjectPropertyKeys.OrderProductQuery.UnitPrice, this, false, false));
        }

        
        public DomainProperty<float, OrderProductQuery, OrderProductQueryDomainObject> Discount { get; private set; }

        public DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject> Id { get; private set; }

        public DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject> OrderID { get; private set; }

        public DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject> Orders_CustomerID { get; private set; }

        public DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject> Orders_EmployeeID { get; private set; }

        public DomainProperty<decimal?, OrderProductQuery, OrderProductQueryDomainObject> Orders_Freight { get; private set; }

        public DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject> Orders_Id { get; private set; }

        public DomainProperty<DateTime?, OrderProductQuery, OrderProductQueryDomainObject> Orders_OrderDate { get; private set; }

        public DomainProperty<DateTime?, OrderProductQuery, OrderProductQueryDomainObject> Orders_RequiredDate { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipAddress { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipCity { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipCountry { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipName { get; private set; }

        public DomainProperty<DateTime?, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShippedDate { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipPostalCode { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipRegion { get; private set; }

        public DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject> Orders_ShipVia { get; private set; }

        public DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject> ProductID { get; private set; }

        public DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject> Products_CategoryID { get; private set; }

        public DomainProperty<bool, OrderProductQuery, OrderProductQueryDomainObject> Products_Discontinued { get; private set; }

        public DomainProperty<int, OrderProductQuery, OrderProductQueryDomainObject> Products_Id { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Products_ProductName { get; private set; }

        public DomainProperty<string, OrderProductQuery, OrderProductQueryDomainObject> Products_QuantityPerUnit { get; private set; }

        public DomainProperty<short?, OrderProductQuery, OrderProductQueryDomainObject> Products_ReorderLevel { get; private set; }

        public DomainProperty<int?, OrderProductQuery, OrderProductQueryDomainObject> Products_SupplierID { get; private set; }

        public DomainProperty<decimal?, OrderProductQuery, OrderProductQueryDomainObject> Products_UnitPrice { get; private set; }

        public DomainProperty<short?, OrderProductQuery, OrderProductQueryDomainObject> Products_UnitsInStock { get; private set; }

        public DomainProperty<short?, OrderProductQuery, OrderProductQueryDomainObject> Products_UnitsOnOrder { get; private set; }

        public DomainProperty<short, OrderProductQuery, OrderProductQueryDomainObject> Quantity { get; private set; }

        public DomainProperty<decimal, OrderProductQuery, OrderProductQueryDomainObject> UnitPrice { get; private set; }
    }
    #endregion
    #region Orders

    public sealed class OrdersDomainObject : DomainObject<Orders, OrdersDomainObject>
    {
        public OrdersDomainObject()
            : base("Orders", DomainObjectKeys.Orders, 14, false)
        {
            CustomerID = AddProperty(new DomainProperty<int, Orders, OrdersDomainObject>("CustomerID", DomainObjectPropertyKeys.Orders.CustomerID, this, false, false));
            EmployeeID = AddProperty(new DomainProperty<int?, Orders, OrdersDomainObject>("EmployeeID", DomainObjectPropertyKeys.Orders.EmployeeID, this, false, false));
            Freight = AddProperty(new DomainProperty<decimal?, Orders, OrdersDomainObject>("Freight", DomainObjectPropertyKeys.Orders.Freight, this, false, false));
            Id = AddProperty(new DomainProperty<int, Orders, OrdersDomainObject>("Id", DomainObjectPropertyKeys.Orders.Id, this, false, false));
            OrderDate = AddProperty(new DomainProperty<DateTime?, Orders, OrdersDomainObject>("OrderDate", DomainObjectPropertyKeys.Orders.OrderDate, this, false, false));
            RequiredDate = AddProperty(new DomainProperty<DateTime?, Orders, OrdersDomainObject>("RequiredDate", DomainObjectPropertyKeys.Orders.RequiredDate, this, false, false));
            ShipAddress = AddProperty(new DomainProperty<string, Orders, OrdersDomainObject>("ShipAddress", DomainObjectPropertyKeys.Orders.ShipAddress, this, false, false));
            ShipCity = AddProperty(new DomainProperty<string, Orders, OrdersDomainObject>("ShipCity", DomainObjectPropertyKeys.Orders.ShipCity, this, false, false));
            ShipCountry = AddProperty(new DomainProperty<string, Orders, OrdersDomainObject>("ShipCountry", DomainObjectPropertyKeys.Orders.ShipCountry, this, false, false));
            ShipName = AddProperty(new DomainProperty<string, Orders, OrdersDomainObject>("ShipName", DomainObjectPropertyKeys.Orders.ShipName, this, false, false));
            ShippedDate = AddProperty(new DomainProperty<DateTime?, Orders, OrdersDomainObject>("ShippedDate", DomainObjectPropertyKeys.Orders.ShippedDate, this, false, false));
            ShipPostalCode = AddProperty(new DomainProperty<string, Orders, OrdersDomainObject>("ShipPostalCode", DomainObjectPropertyKeys.Orders.ShipPostalCode, this, false, false));
            ShipRegion = AddProperty(new DomainProperty<string, Orders, OrdersDomainObject>("ShipRegion", DomainObjectPropertyKeys.Orders.ShipRegion, this, false, false));
            ShipVia = AddProperty(new DomainProperty<int?, Orders, OrdersDomainObject>("ShipVia", DomainObjectPropertyKeys.Orders.ShipVia, this, false, false));
        }

        
        public DomainProperty<int, Orders, OrdersDomainObject> CustomerID { get; private set; }

        public DomainProperty<int?, Orders, OrdersDomainObject> EmployeeID { get; private set; }

        public DomainProperty<decimal?, Orders, OrdersDomainObject> Freight { get; private set; }

        public DomainProperty<int, Orders, OrdersDomainObject> Id { get; private set; }

        public DomainProperty<DateTime?, Orders, OrdersDomainObject> OrderDate { get; private set; }

        public DomainProperty<DateTime?, Orders, OrdersDomainObject> RequiredDate { get; private set; }

        public DomainProperty<string, Orders, OrdersDomainObject> ShipAddress { get; private set; }

        public DomainProperty<string, Orders, OrdersDomainObject> ShipCity { get; private set; }

        public DomainProperty<string, Orders, OrdersDomainObject> ShipCountry { get; private set; }

        public DomainProperty<string, Orders, OrdersDomainObject> ShipName { get; private set; }

        public DomainProperty<DateTime?, Orders, OrdersDomainObject> ShippedDate { get; private set; }

        public DomainProperty<string, Orders, OrdersDomainObject> ShipPostalCode { get; private set; }

        public DomainProperty<string, Orders, OrdersDomainObject> ShipRegion { get; private set; }

        public DomainProperty<int?, Orders, OrdersDomainObject> ShipVia { get; private set; }
    }
    #endregion
    #region OrdersQuery

    public sealed class OrdersQueryDomainObject : DomainObject<OrdersQuery, OrdersQueryDomainObject>
    {
        public OrdersQueryDomainObject()
            : base("OrdersQuery", DomainObjectKeys.OrdersQuery, 46, false)
        {
            CustomerID = AddProperty(new DomainProperty<int, OrdersQuery, OrdersQueryDomainObject>("CustomerID", DomainObjectPropertyKeys.OrdersQuery.CustomerID, this, false, false));
            Customers_Address = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_Address", DomainObjectPropertyKeys.OrdersQuery.Customers_Address, this, false, false));
            Customers_City = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_City", DomainObjectPropertyKeys.OrdersQuery.Customers_City, this, false, false));
            Customers_CompanyName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_CompanyName", DomainObjectPropertyKeys.OrdersQuery.Customers_CompanyName, this, false, false));
            Customers_ContactName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_ContactName", DomainObjectPropertyKeys.OrdersQuery.Customers_ContactName, this, false, false));
            Customers_ContactTitle = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_ContactTitle", DomainObjectPropertyKeys.OrdersQuery.Customers_ContactTitle, this, false, false));
            Customers_Country = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_Country", DomainObjectPropertyKeys.OrdersQuery.Customers_Country, this, false, false));
            Customers_Fax = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_Fax", DomainObjectPropertyKeys.OrdersQuery.Customers_Fax, this, false, false));
            Customers_Id = AddProperty(new DomainProperty<int, OrdersQuery, OrdersQueryDomainObject>("Customers_Id", DomainObjectPropertyKeys.OrdersQuery.Customers_Id, this, false, false));
            Customers_Phone = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_Phone", DomainObjectPropertyKeys.OrdersQuery.Customers_Phone, this, false, false));
            Customers_PostalCode = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_PostalCode", DomainObjectPropertyKeys.OrdersQuery.Customers_PostalCode, this, false, false));
            Customers_Region = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Customers_Region", DomainObjectPropertyKeys.OrdersQuery.Customers_Region, this, false, false));
            EmployeeFullName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("EmployeeFullName", DomainObjectPropertyKeys.OrdersQuery.EmployeeFullName, this, false, false));
            EmployeeID = AddProperty(new DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject>("EmployeeID", DomainObjectPropertyKeys.OrdersQuery.EmployeeID, this, false, false));
            Employees_Address = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_Address", DomainObjectPropertyKeys.OrdersQuery.Employees_Address, this, false, false));
            Employees_BirthDate = AddProperty(new DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject>("Employees_BirthDate", DomainObjectPropertyKeys.OrdersQuery.Employees_BirthDate, this, false, false));
            Employees_City = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_City", DomainObjectPropertyKeys.OrdersQuery.Employees_City, this, false, false));
            Employees_Country = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_Country", DomainObjectPropertyKeys.OrdersQuery.Employees_Country, this, false, false));
            Employees_Extension = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_Extension", DomainObjectPropertyKeys.OrdersQuery.Employees_Extension, this, false, false));
            Employees_FirstName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_FirstName", DomainObjectPropertyKeys.OrdersQuery.Employees_FirstName, this, false, false));
            Employees_HireDate = AddProperty(new DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject>("Employees_HireDate", DomainObjectPropertyKeys.OrdersQuery.Employees_HireDate, this, false, false));
            Employees_HomePhone = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_HomePhone", DomainObjectPropertyKeys.OrdersQuery.Employees_HomePhone, this, false, false));
            Employees_Id = AddProperty(new DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject>("Employees_Id", DomainObjectPropertyKeys.OrdersQuery.Employees_Id, this, false, false));
            Employees_LastName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_LastName", DomainObjectPropertyKeys.OrdersQuery.Employees_LastName, this, false, false));
            Employees_Notes = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_Notes", DomainObjectPropertyKeys.OrdersQuery.Employees_Notes, this, false, false));
            Employees_PhotoPath = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_PhotoPath", DomainObjectPropertyKeys.OrdersQuery.Employees_PhotoPath, this, false, false));
            Employees_PostalCode = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_PostalCode", DomainObjectPropertyKeys.OrdersQuery.Employees_PostalCode, this, false, false));
            Employees_Region = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_Region", DomainObjectPropertyKeys.OrdersQuery.Employees_Region, this, false, false));
            Employees_ReportsTo = AddProperty(new DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject>("Employees_ReportsTo", DomainObjectPropertyKeys.OrdersQuery.Employees_ReportsTo, this, false, false));
            Employees_Title = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_Title", DomainObjectPropertyKeys.OrdersQuery.Employees_Title, this, false, false));
            Employees_TitleOfCourtesy = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Employees_TitleOfCourtesy", DomainObjectPropertyKeys.OrdersQuery.Employees_TitleOfCourtesy, this, false, false));
            Freight = AddProperty(new DomainProperty<decimal?, OrdersQuery, OrdersQueryDomainObject>("Freight", DomainObjectPropertyKeys.OrdersQuery.Freight, this, false, false));
            Id = AddProperty(new DomainProperty<int, OrdersQuery, OrdersQueryDomainObject>("Id", DomainObjectPropertyKeys.OrdersQuery.Id, this, false, false));
            OrderDate = AddProperty(new DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject>("OrderDate", DomainObjectPropertyKeys.OrdersQuery.OrderDate, this, false, false));
            RequiredDate = AddProperty(new DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject>("RequiredDate", DomainObjectPropertyKeys.OrdersQuery.RequiredDate, this, false, false));
            ShipAddress = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("ShipAddress", DomainObjectPropertyKeys.OrdersQuery.ShipAddress, this, false, false));
            ShipCity = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("ShipCity", DomainObjectPropertyKeys.OrdersQuery.ShipCity, this, false, false));
            ShipCountry = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("ShipCountry", DomainObjectPropertyKeys.OrdersQuery.ShipCountry, this, false, false));
            ShipName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("ShipName", DomainObjectPropertyKeys.OrdersQuery.ShipName, this, false, false));
            ShippedDate = AddProperty(new DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject>("ShippedDate", DomainObjectPropertyKeys.OrdersQuery.ShippedDate, this, false, false));
            Shippers_CompanyName = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Shippers_CompanyName", DomainObjectPropertyKeys.OrdersQuery.Shippers_CompanyName, this, false, false));
            Shippers_Id = AddProperty(new DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject>("Shippers_Id", DomainObjectPropertyKeys.OrdersQuery.Shippers_Id, this, false, false));
            Shippers_Phone = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("Shippers_Phone", DomainObjectPropertyKeys.OrdersQuery.Shippers_Phone, this, false, false));
            ShipPostalCode = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("ShipPostalCode", DomainObjectPropertyKeys.OrdersQuery.ShipPostalCode, this, false, false));
            ShipRegion = AddProperty(new DomainProperty<string, OrdersQuery, OrdersQueryDomainObject>("ShipRegion", DomainObjectPropertyKeys.OrdersQuery.ShipRegion, this, false, false));
            ShipVia = AddProperty(new DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject>("ShipVia", DomainObjectPropertyKeys.OrdersQuery.ShipVia, this, false, false));
        }

        
        public DomainProperty<int, OrdersQuery, OrdersQueryDomainObject> CustomerID { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_Address { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_City { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_CompanyName { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_ContactName { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_ContactTitle { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_Country { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_Fax { get; private set; }

        public DomainProperty<int, OrdersQuery, OrdersQueryDomainObject> Customers_Id { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_Phone { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_PostalCode { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Customers_Region { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> EmployeeFullName { get; private set; }

        public DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject> EmployeeID { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_Address { get; private set; }

        public DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject> Employees_BirthDate { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_City { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_Country { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_Extension { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_FirstName { get; private set; }

        public DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject> Employees_HireDate { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_HomePhone { get; private set; }

        public DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject> Employees_Id { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_LastName { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_Notes { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_PhotoPath { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_PostalCode { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_Region { get; private set; }

        public DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject> Employees_ReportsTo { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_Title { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Employees_TitleOfCourtesy { get; private set; }

        public DomainProperty<decimal?, OrdersQuery, OrdersQueryDomainObject> Freight { get; private set; }

        public DomainProperty<int, OrdersQuery, OrdersQueryDomainObject> Id { get; private set; }

        public DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject> OrderDate { get; private set; }

        public DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject> RequiredDate { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> ShipAddress { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> ShipCity { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> ShipCountry { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> ShipName { get; private set; }

        public DomainProperty<DateTime?, OrdersQuery, OrdersQueryDomainObject> ShippedDate { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Shippers_CompanyName { get; private set; }

        public DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject> Shippers_Id { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> Shippers_Phone { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> ShipPostalCode { get; private set; }

        public DomainProperty<string, OrdersQuery, OrdersQueryDomainObject> ShipRegion { get; private set; }

        public DomainProperty<int?, OrdersQuery, OrdersQueryDomainObject> ShipVia { get; private set; }
    }
    #endregion
    #region ProductQuery

    public sealed class ProductQueryDomainObject : DomainObject<ProductQuery, ProductQueryDomainObject>
    {
        public ProductQueryDomainObject()
            : base("ProductQuery", DomainObjectKeys.ProductQuery, 25, false)
        {
            Categories_CategoryName = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Categories_CategoryName", DomainObjectPropertyKeys.ProductQuery.Categories_CategoryName, this, false, false));
            Categories_Description = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Categories_Description", DomainObjectPropertyKeys.ProductQuery.Categories_Description, this, false, false));
            Categories_Id = AddProperty(new DomainProperty<int?, ProductQuery, ProductQueryDomainObject>("Categories_Id", DomainObjectPropertyKeys.ProductQuery.Categories_Id, this, false, false));
            CategoryID = AddProperty(new DomainProperty<int?, ProductQuery, ProductQueryDomainObject>("CategoryID", DomainObjectPropertyKeys.ProductQuery.CategoryID, this, false, false));
            Discontinued = AddProperty(new DomainProperty<bool, ProductQuery, ProductQueryDomainObject>("Discontinued", DomainObjectPropertyKeys.ProductQuery.Discontinued, this, false, false));
            Id = AddProperty(new DomainProperty<int, ProductQuery, ProductQueryDomainObject>("Id", DomainObjectPropertyKeys.ProductQuery.Id, this, false, false));
            ProductName = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("ProductName", DomainObjectPropertyKeys.ProductQuery.ProductName, this, false, false));
            QuantityPerUnit = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("QuantityPerUnit", DomainObjectPropertyKeys.ProductQuery.QuantityPerUnit, this, false, false));
            ReorderLevel = AddProperty(new DomainProperty<short?, ProductQuery, ProductQueryDomainObject>("ReorderLevel", DomainObjectPropertyKeys.ProductQuery.ReorderLevel, this, false, false));
            SupplierID = AddProperty(new DomainProperty<int?, ProductQuery, ProductQueryDomainObject>("SupplierID", DomainObjectPropertyKeys.ProductQuery.SupplierID, this, false, false));
            Suppliers_Address = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_Address", DomainObjectPropertyKeys.ProductQuery.Suppliers_Address, this, false, false));
            Suppliers_City = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_City", DomainObjectPropertyKeys.ProductQuery.Suppliers_City, this, false, false));
            Suppliers_CompanyName = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_CompanyName", DomainObjectPropertyKeys.ProductQuery.Suppliers_CompanyName, this, false, false));
            Suppliers_ContactName = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_ContactName", DomainObjectPropertyKeys.ProductQuery.Suppliers_ContactName, this, false, false));
            Suppliers_ContactTitle = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_ContactTitle", DomainObjectPropertyKeys.ProductQuery.Suppliers_ContactTitle, this, false, false));
            Suppliers_Country = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_Country", DomainObjectPropertyKeys.ProductQuery.Suppliers_Country, this, false, false));
            Suppliers_Fax = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_Fax", DomainObjectPropertyKeys.ProductQuery.Suppliers_Fax, this, false, false));
            Suppliers_HomePage = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_HomePage", DomainObjectPropertyKeys.ProductQuery.Suppliers_HomePage, this, false, false));
            Suppliers_Id = AddProperty(new DomainProperty<int?, ProductQuery, ProductQueryDomainObject>("Suppliers_Id", DomainObjectPropertyKeys.ProductQuery.Suppliers_Id, this, false, false));
            Suppliers_Phone = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_Phone", DomainObjectPropertyKeys.ProductQuery.Suppliers_Phone, this, false, false));
            Suppliers_PostalCode = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_PostalCode", DomainObjectPropertyKeys.ProductQuery.Suppliers_PostalCode, this, false, false));
            Suppliers_Region = AddProperty(new DomainProperty<string, ProductQuery, ProductQueryDomainObject>("Suppliers_Region", DomainObjectPropertyKeys.ProductQuery.Suppliers_Region, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal?, ProductQuery, ProductQueryDomainObject>("UnitPrice", DomainObjectPropertyKeys.ProductQuery.UnitPrice, this, false, false));
            UnitsInStock = AddProperty(new DomainProperty<short?, ProductQuery, ProductQueryDomainObject>("UnitsInStock", DomainObjectPropertyKeys.ProductQuery.UnitsInStock, this, false, false));
            UnitsOnOrder = AddProperty(new DomainProperty<short?, ProductQuery, ProductQueryDomainObject>("UnitsOnOrder", DomainObjectPropertyKeys.ProductQuery.UnitsOnOrder, this, false, false));
        }

        
        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Categories_CategoryName { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Categories_Description { get; private set; }

        public DomainProperty<int?, ProductQuery, ProductQueryDomainObject> Categories_Id { get; private set; }

        public DomainProperty<int?, ProductQuery, ProductQueryDomainObject> CategoryID { get; private set; }

        public DomainProperty<bool, ProductQuery, ProductQueryDomainObject> Discontinued { get; private set; }

        public DomainProperty<int, ProductQuery, ProductQueryDomainObject> Id { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> ProductName { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> QuantityPerUnit { get; private set; }

        public DomainProperty<short?, ProductQuery, ProductQueryDomainObject> ReorderLevel { get; private set; }

        public DomainProperty<int?, ProductQuery, ProductQueryDomainObject> SupplierID { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_Address { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_City { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_CompanyName { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_ContactName { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_ContactTitle { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_Country { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_Fax { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_HomePage { get; private set; }

        public DomainProperty<int?, ProductQuery, ProductQueryDomainObject> Suppliers_Id { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_Phone { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_PostalCode { get; private set; }

        public DomainProperty<string, ProductQuery, ProductQueryDomainObject> Suppliers_Region { get; private set; }

        public DomainProperty<decimal?, ProductQuery, ProductQueryDomainObject> UnitPrice { get; private set; }

        public DomainProperty<short?, ProductQuery, ProductQueryDomainObject> UnitsInStock { get; private set; }

        public DomainProperty<short?, ProductQuery, ProductQueryDomainObject> UnitsOnOrder { get; private set; }
    }
    #endregion
    #region Products

    public sealed class ProductsDomainObject : DomainObject<Products, ProductsDomainObject>
    {
        public ProductsDomainObject()
            : base("Products", DomainObjectKeys.Products, 10, false)
        {
            CategoryID = AddProperty(new DomainProperty<int?, Products, ProductsDomainObject>("CategoryID", DomainObjectPropertyKeys.Products.CategoryID, this, false, false));
            Discontinued = AddProperty(new DomainProperty<bool, Products, ProductsDomainObject>("Discontinued", DomainObjectPropertyKeys.Products.Discontinued, this, false, false));
            Id = AddProperty(new DomainProperty<int, Products, ProductsDomainObject>("Id", DomainObjectPropertyKeys.Products.Id, this, false, false));
            ProductName = AddProperty(new DomainProperty<string, Products, ProductsDomainObject>("ProductName", DomainObjectPropertyKeys.Products.ProductName, this, false, false));
            QuantityPerUnit = AddProperty(new DomainProperty<string, Products, ProductsDomainObject>("QuantityPerUnit", DomainObjectPropertyKeys.Products.QuantityPerUnit, this, false, false));
            ReorderLevel = AddProperty(new DomainProperty<short?, Products, ProductsDomainObject>("ReorderLevel", DomainObjectPropertyKeys.Products.ReorderLevel, this, false, false));
            SupplierID = AddProperty(new DomainProperty<int?, Products, ProductsDomainObject>("SupplierID", DomainObjectPropertyKeys.Products.SupplierID, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal?, Products, ProductsDomainObject>("UnitPrice", DomainObjectPropertyKeys.Products.UnitPrice, this, false, false));
            UnitsInStock = AddProperty(new DomainProperty<short?, Products, ProductsDomainObject>("UnitsInStock", DomainObjectPropertyKeys.Products.UnitsInStock, this, false, false));
            UnitsOnOrder = AddProperty(new DomainProperty<short?, Products, ProductsDomainObject>("UnitsOnOrder", DomainObjectPropertyKeys.Products.UnitsOnOrder, this, false, false));
        }

        
        public DomainProperty<int?, Products, ProductsDomainObject> CategoryID { get; private set; }

        public DomainProperty<bool, Products, ProductsDomainObject> Discontinued { get; private set; }

        public DomainProperty<int, Products, ProductsDomainObject> Id { get; private set; }

        public DomainProperty<string, Products, ProductsDomainObject> ProductName { get; private set; }

        public DomainProperty<string, Products, ProductsDomainObject> QuantityPerUnit { get; private set; }

        public DomainProperty<short?, Products, ProductsDomainObject> ReorderLevel { get; private set; }

        public DomainProperty<int?, Products, ProductsDomainObject> SupplierID { get; private set; }

        public DomainProperty<decimal?, Products, ProductsDomainObject> UnitPrice { get; private set; }

        public DomainProperty<short?, Products, ProductsDomainObject> UnitsInStock { get; private set; }

        public DomainProperty<short?, Products, ProductsDomainObject> UnitsOnOrder { get; private set; }
    }
    #endregion
    #region Region

    public sealed class RegionDomainObject : DomainObject<Region, RegionDomainObject>
    {
        public RegionDomainObject()
            : base("Region", DomainObjectKeys.Region, 2, false)
        {
            Id = AddProperty(new DomainProperty<int, Region, RegionDomainObject>("Id", DomainObjectPropertyKeys.Region.Id, this, false, false));
            RegionDescription = AddProperty(new DomainProperty<string, Region, RegionDomainObject>("RegionDescription", DomainObjectPropertyKeys.Region.RegionDescription, this, false, false));
        }

        
        public DomainProperty<int, Region, RegionDomainObject> Id { get; private set; }

        public DomainProperty<string, Region, RegionDomainObject> RegionDescription { get; private set; }
    }
    #endregion
    #region RegionQuery

    public sealed class RegionQueryDomainObject : DomainObject<RegionQuery, RegionQueryDomainObject>
    {
        public RegionQueryDomainObject()
            : base("RegionQuery", DomainObjectKeys.RegionQuery, 2, false)
        {
            Id = AddProperty(new DomainProperty<int, RegionQuery, RegionQueryDomainObject>("Id", DomainObjectPropertyKeys.RegionQuery.Id, this, false, false));
            RegionDescription = AddProperty(new DomainProperty<string, RegionQuery, RegionQueryDomainObject>("RegionDescription", DomainObjectPropertyKeys.RegionQuery.RegionDescription, this, false, false));
        }

        
        public DomainProperty<int, RegionQuery, RegionQueryDomainObject> Id { get; private set; }

        public DomainProperty<string, RegionQuery, RegionQueryDomainObject> RegionDescription { get; private set; }
    }
    #endregion
    #region ReportFormQuery

    public sealed class ReportFormQueryDomainObject : DomainObject<ReportFormQuery, ReportFormQueryDomainObject>
    {
        public ReportFormQueryDomainObject()
            : base("ReportFormQuery", DomainObjectKeys.ReportFormQuery, 6, false)
        {
            CustomerId = AddProperty(new DomainProperty<int?, ReportFormQuery, ReportFormQueryDomainObject>("CustomerId", DomainObjectPropertyKeys.ReportFormQuery.CustomerId, this, false, false));
            EmployeeId = AddProperty(new DomainProperty<int?, ReportFormQuery, ReportFormQueryDomainObject>("EmployeeId", DomainObjectPropertyKeys.ReportFormQuery.EmployeeId, this, false, false));
            From = AddProperty(new DomainProperty<DateTime?, ReportFormQuery, ReportFormQueryDomainObject>("From", DomainObjectPropertyKeys.ReportFormQuery.From, this, false, false));
            Id = AddProperty(new DomainProperty<int, ReportFormQuery, ReportFormQueryDomainObject>("Id", DomainObjectPropertyKeys.ReportFormQuery.Id, this, false, false));
            To = AddProperty(new DomainProperty<DateTime?, ReportFormQuery, ReportFormQueryDomainObject>("To", DomainObjectPropertyKeys.ReportFormQuery.To, this, false, false));
            useExcel = AddProperty(new DomainProperty<bool, ReportFormQuery, ReportFormQueryDomainObject>("useExcel", DomainObjectPropertyKeys.ReportFormQuery.useExcel, this, false, false));
        }

        
        public DomainProperty<int?, ReportFormQuery, ReportFormQueryDomainObject> CustomerId { get; private set; }

        public DomainProperty<int?, ReportFormQuery, ReportFormQueryDomainObject> EmployeeId { get; private set; }

        public DomainProperty<DateTime?, ReportFormQuery, ReportFormQueryDomainObject> From { get; private set; }

        public DomainProperty<int, ReportFormQuery, ReportFormQueryDomainObject> Id { get; private set; }

        public DomainProperty<DateTime?, ReportFormQuery, ReportFormQueryDomainObject> To { get; private set; }

        public DomainProperty<bool, ReportFormQuery, ReportFormQueryDomainObject> useExcel { get; private set; }
    }
    #endregion
    #region ShipperQuery

    public sealed class ShipperQueryDomainObject : DomainObject<ShipperQuery, ShipperQueryDomainObject>
    {
        public ShipperQueryDomainObject()
            : base("ShipperQuery", DomainObjectKeys.ShipperQuery, 3, false)
        {
            CompanyName = AddProperty(new DomainProperty<string, ShipperQuery, ShipperQueryDomainObject>("CompanyName", DomainObjectPropertyKeys.ShipperQuery.CompanyName, this, false, false));
            Id = AddProperty(new DomainProperty<int, ShipperQuery, ShipperQueryDomainObject>("Id", DomainObjectPropertyKeys.ShipperQuery.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, ShipperQuery, ShipperQueryDomainObject>("Phone", DomainObjectPropertyKeys.ShipperQuery.Phone, this, false, false));
        }

        
        public DomainProperty<string, ShipperQuery, ShipperQueryDomainObject> CompanyName { get; private set; }

        public DomainProperty<int, ShipperQuery, ShipperQueryDomainObject> Id { get; private set; }

        public DomainProperty<string, ShipperQuery, ShipperQueryDomainObject> Phone { get; private set; }
    }
    #endregion
    #region Shippers

    public sealed class ShippersDomainObject : DomainObject<Shippers, ShippersDomainObject>
    {
        public ShippersDomainObject()
            : base("Shippers", DomainObjectKeys.Shippers, 3, false)
        {
            CompanyName = AddProperty(new DomainProperty<string, Shippers, ShippersDomainObject>("CompanyName", DomainObjectPropertyKeys.Shippers.CompanyName, this, false, false));
            Id = AddProperty(new DomainProperty<int, Shippers, ShippersDomainObject>("Id", DomainObjectPropertyKeys.Shippers.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, Shippers, ShippersDomainObject>("Phone", DomainObjectPropertyKeys.Shippers.Phone, this, false, false));
        }

        
        public DomainProperty<string, Shippers, ShippersDomainObject> CompanyName { get; private set; }

        public DomainProperty<int, Shippers, ShippersDomainObject> Id { get; private set; }

        public DomainProperty<string, Shippers, ShippersDomainObject> Phone { get; private set; }
    }
    #endregion
    #region SupplierQuery

    public sealed class SupplierQueryDomainObject : DomainObject<SupplierQuery, SupplierQueryDomainObject>
    {
        public SupplierQueryDomainObject()
            : base("SupplierQuery", DomainObjectKeys.SupplierQuery, 12, false)
        {
            Address = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("Address", DomainObjectPropertyKeys.SupplierQuery.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("City", DomainObjectPropertyKeys.SupplierQuery.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("CompanyName", DomainObjectPropertyKeys.SupplierQuery.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("ContactName", DomainObjectPropertyKeys.SupplierQuery.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("ContactTitle", DomainObjectPropertyKeys.SupplierQuery.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("Country", DomainObjectPropertyKeys.SupplierQuery.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("Fax", DomainObjectPropertyKeys.SupplierQuery.Fax, this, false, false));
            HomePage = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("HomePage", DomainObjectPropertyKeys.SupplierQuery.HomePage, this, false, false));
            Id = AddProperty(new DomainProperty<int, SupplierQuery, SupplierQueryDomainObject>("Id", DomainObjectPropertyKeys.SupplierQuery.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("Phone", DomainObjectPropertyKeys.SupplierQuery.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("PostalCode", DomainObjectPropertyKeys.SupplierQuery.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, SupplierQuery, SupplierQueryDomainObject>("Region", DomainObjectPropertyKeys.SupplierQuery.Region, this, false, false));
        }

        
        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> Address { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> City { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> ContactName { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> Country { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> Fax { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> HomePage { get; private set; }

        public DomainProperty<int, SupplierQuery, SupplierQueryDomainObject> Id { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> Phone { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, SupplierQuery, SupplierQueryDomainObject> Region { get; private set; }
    }
    #endregion
    #region Suppliers

    public sealed class SuppliersDomainObject : DomainObject<Suppliers, SuppliersDomainObject>
    {
        public SuppliersDomainObject()
            : base("Suppliers", DomainObjectKeys.Suppliers, 12, false)
        {
            Address = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("Address", DomainObjectPropertyKeys.Suppliers.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("City", DomainObjectPropertyKeys.Suppliers.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("CompanyName", DomainObjectPropertyKeys.Suppliers.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("ContactName", DomainObjectPropertyKeys.Suppliers.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("ContactTitle", DomainObjectPropertyKeys.Suppliers.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("Country", DomainObjectPropertyKeys.Suppliers.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("Fax", DomainObjectPropertyKeys.Suppliers.Fax, this, false, false));
            HomePage = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("HomePage", DomainObjectPropertyKeys.Suppliers.HomePage, this, false, false));
            Id = AddProperty(new DomainProperty<int, Suppliers, SuppliersDomainObject>("Id", DomainObjectPropertyKeys.Suppliers.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("Phone", DomainObjectPropertyKeys.Suppliers.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("PostalCode", DomainObjectPropertyKeys.Suppliers.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, Suppliers, SuppliersDomainObject>("Region", DomainObjectPropertyKeys.Suppliers.Region, this, false, false));
        }

        
        public DomainProperty<string, Suppliers, SuppliersDomainObject> Address { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> City { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> ContactName { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> Country { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> Fax { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> HomePage { get; private set; }

        public DomainProperty<int, Suppliers, SuppliersDomainObject> Id { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> Phone { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, Suppliers, SuppliersDomainObject> Region { get; private set; }
    }
    #endregion
    #region SysInfo

    public sealed class SysInfoDomainObject : DomainObject<SysInfo, SysInfoDomainObject>
    {
        public SysInfoDomainObject()
            : base("SysInfo", DomainObjectKeys.SysInfo, 3, true)
        {
            DomainVersion = AddProperty(new DomainProperty<string, SysInfo, SysInfoDomainObject>("DomainVersion", DomainObjectPropertyKeys.SysInfo.DomainVersion, this, false, true));
            LastInitialization = AddProperty(new DomainProperty<DateTime, SysInfo, SysInfoDomainObject>("LastInitialization", DomainObjectPropertyKeys.SysInfo.LastInitialization, this, false, true));
            SystemVersion = AddProperty(new DomainProperty<string, SysInfo, SysInfoDomainObject>("SystemVersion", DomainObjectPropertyKeys.SysInfo.SystemVersion, this, false, true));
        }

        
        public DomainProperty<string, SysInfo, SysInfoDomainObject> DomainVersion { get; private set; }

        public DomainProperty<DateTime, SysInfo, SysInfoDomainObject> LastInitialization { get; private set; }

        public DomainProperty<string, SysInfo, SysInfoDomainObject> SystemVersion { get; private set; }
    }
    #endregion
    #region SysObject

    public sealed class SysObjectDomainObject : DomainObject<SysObject, SysObjectDomainObject>
    {
        public SysObjectDomainObject()
            : base("SysObject", DomainObjectKeys.SysObject, 9, true)
        {
            ClassId = AddProperty(new DomainProperty<byte, SysObject, SysObjectDomainObject>("ClassId", DomainObjectPropertyKeys.SysObject.ClassId, this, false, true));
            CodeName = AddProperty(new DomainProperty<string, SysObject, SysObjectDomainObject>("CodeName", DomainObjectPropertyKeys.SysObject.CodeName, this, false, true));
            DbFieldId = AddProperty(new DomainProperty<int?, SysObject, SysObjectDomainObject>("DbFieldId", DomainObjectPropertyKeys.SysObject.DbFieldId, this, false, true));
            DbObjectId = AddProperty(new DomainProperty<int?, SysObject, SysObjectDomainObject>("DbObjectId", DomainObjectPropertyKeys.SysObject.DbObjectId, this, false, true));
            Description = AddProperty(new DomainProperty<string, SysObject, SysObjectDomainObject>("Description", DomainObjectPropertyKeys.SysObject.Description, this, false, true));
            DisplayName = AddProperty(new DomainProperty<string, SysObject, SysObjectDomainObject>("DisplayName", DomainObjectPropertyKeys.SysObject.DisplayName, this, false, true));
            Guid = AddProperty(new DomainProperty<Guid, SysObject, SysObjectDomainObject>("Guid", DomainObjectPropertyKeys.SysObject.Guid, this, false, true));
            Id = AddProperty(new DomainProperty<int, SysObject, SysObjectDomainObject>("Id", DomainObjectPropertyKeys.SysObject.Id, this, false, true));
            ParentId = AddProperty(new DomainProperty<int, SysObject, SysObjectDomainObject>("ParentId", DomainObjectPropertyKeys.SysObject.ParentId, this, false, true));
        }

        
        public DomainProperty<byte, SysObject, SysObjectDomainObject> ClassId { get; private set; }

        public DomainProperty<string, SysObject, SysObjectDomainObject> CodeName { get; private set; }

        public DomainProperty<int?, SysObject, SysObjectDomainObject> DbFieldId { get; private set; }

        public DomainProperty<int?, SysObject, SysObjectDomainObject> DbObjectId { get; private set; }

        public DomainProperty<string, SysObject, SysObjectDomainObject> Description { get; private set; }

        public DomainProperty<string, SysObject, SysObjectDomainObject> DisplayName { get; private set; }

        public DomainProperty<Guid, SysObject, SysObjectDomainObject> Guid { get; private set; }

        public DomainProperty<int, SysObject, SysObjectDomainObject> Id { get; private set; }

        public DomainProperty<int, SysObject, SysObjectDomainObject> ParentId { get; private set; }
    }
    #endregion
    #region SysObjectClass

    public sealed class SysObjectClassDomainObject : DomainObject<SysObjectClass, SysObjectClassDomainObject>
    {
        public SysObjectClassDomainObject()
            : base("SysObjectClass", DomainObjectKeys.SysObjectClass, 4, true)
        {
            CodeName = AddProperty(new DomainProperty<string, SysObjectClass, SysObjectClassDomainObject>("CodeName", DomainObjectPropertyKeys.SysObjectClass.CodeName, this, false, true));
            Description = AddProperty(new DomainProperty<string, SysObjectClass, SysObjectClassDomainObject>("Description", DomainObjectPropertyKeys.SysObjectClass.Description, this, false, true));
            DisplayName = AddProperty(new DomainProperty<string, SysObjectClass, SysObjectClassDomainObject>("DisplayName", DomainObjectPropertyKeys.SysObjectClass.DisplayName, this, false, true));
            Id = AddProperty(new DomainProperty<byte, SysObjectClass, SysObjectClassDomainObject>("Id", DomainObjectPropertyKeys.SysObjectClass.Id, this, false, true));
        }

        
        public DomainProperty<string, SysObjectClass, SysObjectClassDomainObject> CodeName { get; private set; }

        public DomainProperty<string, SysObjectClass, SysObjectClassDomainObject> Description { get; private set; }

        public DomainProperty<string, SysObjectClass, SysObjectClassDomainObject> DisplayName { get; private set; }

        public DomainProperty<byte, SysObjectClass, SysObjectClassDomainObject> Id { get; private set; }
    }
    #endregion
    #region SysObjectType

    public sealed class SysObjectTypeDomainObject : DomainObject<SysObjectType, SysObjectTypeDomainObject>
    {
        public SysObjectTypeDomainObject()
            : base("SysObjectType", DomainObjectKeys.SysObjectType, 2, true)
        {
            Id = AddProperty(new DomainProperty<int, SysObjectType, SysObjectTypeDomainObject>("Id", DomainObjectPropertyKeys.SysObjectType.Id, this, false, true));
            Name = AddProperty(new DomainProperty<string, SysObjectType, SysObjectTypeDomainObject>("Name", DomainObjectPropertyKeys.SysObjectType.Name, this, false, true));
        }

        
        public DomainProperty<int, SysObjectType, SysObjectTypeDomainObject> Id { get; private set; }

        public DomainProperty<string, SysObjectType, SysObjectTypeDomainObject> Name { get; private set; }
    }
    #endregion
    #region SysOperation

    public sealed class SysOperationDomainObject : DomainObject<SysOperation, SysOperationDomainObject>
    {
        public SysOperationDomainObject()
            : base("SysOperation", DomainObjectKeys.SysOperation, 8, true)
        {
            ActionId = AddProperty(new DomainProperty<int, SysOperation, SysOperationDomainObject>("ActionId", DomainObjectPropertyKeys.SysOperation.ActionId, this, false, true));
            Date = AddProperty(new DomainProperty<DateTime, SysOperation, SysOperationDomainObject>("Date", DomainObjectPropertyKeys.SysOperation.Date, this, false, true));
            Id = AddProperty(new DomainProperty<long, SysOperation, SysOperationDomainObject>("Id", DomainObjectPropertyKeys.SysOperation.Id, this, false, true));
            OperationDetails = AddProperty(new DomainProperty<string, SysOperation, SysOperationDomainObject>("OperationDetails", DomainObjectPropertyKeys.SysOperation.OperationDetails, this, false, true));
            OperationResultId = AddProperty(new DomainProperty<byte, SysOperation, SysOperationDomainObject>("OperationResultId", DomainObjectPropertyKeys.SysOperation.OperationResultId, this, false, true));
            Request = AddProperty(new DomainProperty<string, SysOperation, SysOperationDomainObject>("Request", DomainObjectPropertyKeys.SysOperation.Request, this, false, true));
            RequestContent = AddProperty(new DomainProperty<string, SysOperation, SysOperationDomainObject>("RequestContent", DomainObjectPropertyKeys.SysOperation.RequestContent, this, false, true));
            UserID = AddProperty(new DomainProperty<int, SysOperation, SysOperationDomainObject>("UserID", DomainObjectPropertyKeys.SysOperation.UserID, this, false, true));
        }

        
        public DomainProperty<int, SysOperation, SysOperationDomainObject> ActionId { get; private set; }

        public DomainProperty<DateTime, SysOperation, SysOperationDomainObject> Date { get; private set; }

        public DomainProperty<long, SysOperation, SysOperationDomainObject> Id { get; private set; }

        public DomainProperty<string, SysOperation, SysOperationDomainObject> OperationDetails { get; private set; }

        public DomainProperty<byte, SysOperation, SysOperationDomainObject> OperationResultId { get; private set; }

        public DomainProperty<string, SysOperation, SysOperationDomainObject> Request { get; private set; }

        public DomainProperty<string, SysOperation, SysOperationDomainObject> RequestContent { get; private set; }

        public DomainProperty<int, SysOperation, SysOperationDomainObject> UserID { get; private set; }
    }
    #endregion
    #region SysOperationLock

    public sealed class SysOperationLockDomainObject : DomainObject<SysOperationLock, SysOperationLockDomainObject>
    {
        public SysOperationLockDomainObject()
            : base("SysOperationLock", DomainObjectKeys.SysOperationLock, 7, true)
        {
            AquiredTime = AddProperty(new DomainProperty<DateTime, SysOperationLock, SysOperationLockDomainObject>("AquiredTime", DomainObjectPropertyKeys.SysOperationLock.AquiredTime, this, false, true));
            ExpirationTime = AddProperty(new DomainProperty<DateTime, SysOperationLock, SysOperationLockDomainObject>("ExpirationTime", DomainObjectPropertyKeys.SysOperationLock.ExpirationTime, this, false, true));
            MachineName = AddProperty(new DomainProperty<string, SysOperationLock, SysOperationLockDomainObject>("MachineName", DomainObjectPropertyKeys.SysOperationLock.MachineName, this, false, true));
            OperationContext = AddProperty(new DomainProperty<string, SysOperationLock, SysOperationLockDomainObject>("OperationContext", DomainObjectPropertyKeys.SysOperationLock.OperationContext, this, false, true));
            OperationName = AddProperty(new DomainProperty<string, SysOperationLock, SysOperationLockDomainObject>("OperationName", DomainObjectPropertyKeys.SysOperationLock.OperationName, this, false, true));
            ProcessId = AddProperty(new DomainProperty<int?, SysOperationLock, SysOperationLockDomainObject>("ProcessId", DomainObjectPropertyKeys.SysOperationLock.ProcessId, this, false, true));
            UserId = AddProperty(new DomainProperty<int, SysOperationLock, SysOperationLockDomainObject>("UserId", DomainObjectPropertyKeys.SysOperationLock.UserId, this, false, true));
        }

        
        public DomainProperty<DateTime, SysOperationLock, SysOperationLockDomainObject> AquiredTime { get; private set; }

        public DomainProperty<DateTime, SysOperationLock, SysOperationLockDomainObject> ExpirationTime { get; private set; }

        public DomainProperty<string, SysOperationLock, SysOperationLockDomainObject> MachineName { get; private set; }

        public DomainProperty<string, SysOperationLock, SysOperationLockDomainObject> OperationContext { get; private set; }

        public DomainProperty<string, SysOperationLock, SysOperationLockDomainObject> OperationName { get; private set; }

        public DomainProperty<int?, SysOperationLock, SysOperationLockDomainObject> ProcessId { get; private set; }

        public DomainProperty<int, SysOperationLock, SysOperationLockDomainObject> UserId { get; private set; }
    }
    #endregion
    #region SysOperationResult

    public sealed class SysOperationResultDomainObject : DomainObject<SysOperationResult, SysOperationResultDomainObject>
    {
        public SysOperationResultDomainObject()
            : base("SysOperationResult", DomainObjectKeys.SysOperationResult, 2, true)
        {
            Id = AddProperty(new DomainProperty<byte, SysOperationResult, SysOperationResultDomainObject>("Id", DomainObjectPropertyKeys.SysOperationResult.Id, this, false, true));
            Name = AddProperty(new DomainProperty<string, SysOperationResult, SysOperationResultDomainObject>("Name", DomainObjectPropertyKeys.SysOperationResult.Name, this, false, true));
        }

        
        public DomainProperty<byte, SysOperationResult, SysOperationResultDomainObject> Id { get; private set; }

        public DomainProperty<string, SysOperationResult, SysOperationResultDomainObject> Name { get; private set; }
    }
    #endregion
    #region SysPermission

    public sealed class SysPermissionDomainObject : DomainObject<SysPermission, SysPermissionDomainObject>
    {
        public SysPermissionDomainObject()
            : base("SysPermission", DomainObjectKeys.SysPermission, 7, true)
        {
            CodeName = AddProperty(new DomainProperty<string, SysPermission, SysPermissionDomainObject>("CodeName", DomainObjectPropertyKeys.SysPermission.CodeName, this, false, true));
            Description = AddProperty(new DomainProperty<string, SysPermission, SysPermissionDomainObject>("Description", DomainObjectPropertyKeys.SysPermission.Description, this, false, true));
            DisplayName = AddProperty(new DomainProperty<string, SysPermission, SysPermissionDomainObject>("DisplayName", DomainObjectPropertyKeys.SysPermission.DisplayName, this, false, true));
            Guid = AddProperty(new DomainProperty<Guid, SysPermission, SysPermissionDomainObject>("Guid", DomainObjectPropertyKeys.SysPermission.Guid, this, false, true));
            Id = AddProperty(new DomainProperty<int, SysPermission, SysPermissionDomainObject>("Id", DomainObjectPropertyKeys.SysPermission.Id, this, false, true));
            ObjectId = AddProperty(new DomainProperty<int, SysPermission, SysPermissionDomainObject>("ObjectId", DomainObjectPropertyKeys.SysPermission.ObjectId, this, false, true));
            Type = AddProperty(new DomainProperty<byte, SysPermission, SysPermissionDomainObject>("Type", DomainObjectPropertyKeys.SysPermission.Type, this, false, true));
        }

        
        public DomainProperty<string, SysPermission, SysPermissionDomainObject> CodeName { get; private set; }

        public DomainProperty<string, SysPermission, SysPermissionDomainObject> Description { get; private set; }

        public DomainProperty<string, SysPermission, SysPermissionDomainObject> DisplayName { get; private set; }

        public DomainProperty<Guid, SysPermission, SysPermissionDomainObject> Guid { get; private set; }

        public DomainProperty<int, SysPermission, SysPermissionDomainObject> Id { get; private set; }

        public DomainProperty<int, SysPermission, SysPermissionDomainObject> ObjectId { get; private set; }

        public DomainProperty<byte, SysPermission, SysPermissionDomainObject> Type { get; private set; }
    }
    #endregion
    #region SysPermissionType

    public sealed class SysPermissionTypeDomainObject : DomainObject<SysPermissionType, SysPermissionTypeDomainObject>
    {
        public SysPermissionTypeDomainObject()
            : base("SysPermissionType", DomainObjectKeys.SysPermissionType, 4, true)
        {
            CodeName = AddProperty(new DomainProperty<string, SysPermissionType, SysPermissionTypeDomainObject>("CodeName", DomainObjectPropertyKeys.SysPermissionType.CodeName, this, false, true));
            Description = AddProperty(new DomainProperty<string, SysPermissionType, SysPermissionTypeDomainObject>("Description", DomainObjectPropertyKeys.SysPermissionType.Description, this, false, true));
            DisplayName = AddProperty(new DomainProperty<string, SysPermissionType, SysPermissionTypeDomainObject>("DisplayName", DomainObjectPropertyKeys.SysPermissionType.DisplayName, this, false, true));
            Id = AddProperty(new DomainProperty<byte, SysPermissionType, SysPermissionTypeDomainObject>("Id", DomainObjectPropertyKeys.SysPermissionType.Id, this, false, true));
        }

        
        public DomainProperty<string, SysPermissionType, SysPermissionTypeDomainObject> CodeName { get; private set; }

        public DomainProperty<string, SysPermissionType, SysPermissionTypeDomainObject> Description { get; private set; }

        public DomainProperty<string, SysPermissionType, SysPermissionTypeDomainObject> DisplayName { get; private set; }

        public DomainProperty<byte, SysPermissionType, SysPermissionTypeDomainObject> Id { get; private set; }
    }
    #endregion
    #region SysRefreshToken

    public sealed class SysRefreshTokenDomainObject : DomainObject<SysRefreshToken, SysRefreshTokenDomainObject>
    {
        public SysRefreshTokenDomainObject()
            : base("SysRefreshToken", DomainObjectKeys.SysRefreshToken, 4, true)
        {
            ClientId = AddProperty(new DomainProperty<string, SysRefreshToken, SysRefreshTokenDomainObject>("ClientId", DomainObjectPropertyKeys.SysRefreshToken.ClientId, this, false, true));
            ExpiresUtc = AddProperty(new DomainProperty<DateTimeOffset, SysRefreshToken, SysRefreshTokenDomainObject>("ExpiresUtc", DomainObjectPropertyKeys.SysRefreshToken.ExpiresUtc, this, false, true));
            Token = AddProperty(new DomainProperty<string, SysRefreshToken, SysRefreshTokenDomainObject>("Token", DomainObjectPropertyKeys.SysRefreshToken.Token, this, false, true));
            UserId = AddProperty(new DomainProperty<int, SysRefreshToken, SysRefreshTokenDomainObject>("UserId", DomainObjectPropertyKeys.SysRefreshToken.UserId, this, false, true));
        }

        
        public DomainProperty<string, SysRefreshToken, SysRefreshTokenDomainObject> ClientId { get; private set; }

        public DomainProperty<DateTimeOffset, SysRefreshToken, SysRefreshTokenDomainObject> ExpiresUtc { get; private set; }

        public DomainProperty<string, SysRefreshToken, SysRefreshTokenDomainObject> Token { get; private set; }

        public DomainProperty<int, SysRefreshToken, SysRefreshTokenDomainObject> UserId { get; private set; }
    }
    #endregion
    #region SysResetPasswordToken

    public sealed class SysResetPasswordTokenDomainObject : DomainObject<SysResetPasswordToken, SysResetPasswordTokenDomainObject>
    {
        public SysResetPasswordTokenDomainObject()
            : base("SysResetPasswordToken", DomainObjectKeys.SysResetPasswordToken, 5, true)
        {
            Id = AddProperty(new DomainProperty<int, SysResetPasswordToken, SysResetPasswordTokenDomainObject>("Id", DomainObjectPropertyKeys.SysResetPasswordToken.Id, this, false, true));
            IsExecuted = AddProperty(new DomainProperty<bool, SysResetPasswordToken, SysResetPasswordTokenDomainObject>("IsExecuted", DomainObjectPropertyKeys.SysResetPasswordToken.IsExecuted, this, false, true));
            Token = AddProperty(new DomainProperty<string, SysResetPasswordToken, SysResetPasswordTokenDomainObject>("Token", DomainObjectPropertyKeys.SysResetPasswordToken.Token, this, false, true));
            UserId = AddProperty(new DomainProperty<int, SysResetPasswordToken, SysResetPasswordTokenDomainObject>("UserId", DomainObjectPropertyKeys.SysResetPasswordToken.UserId, this, false, true));
            ValidFrom = AddProperty(new DomainProperty<DateTimeOffset, SysResetPasswordToken, SysResetPasswordTokenDomainObject>("ValidFrom", DomainObjectPropertyKeys.SysResetPasswordToken.ValidFrom, this, false, true));
        }

        
        public DomainProperty<int, SysResetPasswordToken, SysResetPasswordTokenDomainObject> Id { get; private set; }

        public DomainProperty<bool, SysResetPasswordToken, SysResetPasswordTokenDomainObject> IsExecuted { get; private set; }

        public DomainProperty<string, SysResetPasswordToken, SysResetPasswordTokenDomainObject> Token { get; private set; }

        public DomainProperty<int, SysResetPasswordToken, SysResetPasswordTokenDomainObject> UserId { get; private set; }

        public DomainProperty<DateTimeOffset, SysResetPasswordToken, SysResetPasswordTokenDomainObject> ValidFrom { get; private set; }
    }
    #endregion
    #region SysRole

    public sealed class SysRoleDomainObject : DomainObject<SysRole, SysRoleDomainObject>
    {
        public SysRoleDomainObject()
            : base("SysRole", DomainObjectKeys.SysRole, 6, true)
        {
            Description = AddProperty(new DomainProperty<string, SysRole, SysRoleDomainObject>("Description", DomainObjectPropertyKeys.SysRole.Description, this, false, true));
            Id = AddProperty(new DomainProperty<int, SysRole, SysRoleDomainObject>("Id", DomainObjectPropertyKeys.SysRole.Id, this, false, true));
            IsOwnByUser = AddProperty(new DomainProperty<bool, SysRole, SysRoleDomainObject>("IsOwnByUser", DomainObjectPropertyKeys.SysRole.IsOwnByUser, this, false, true));
            IsSystem = AddProperty(new DomainProperty<bool, SysRole, SysRoleDomainObject>("IsSystem", DomainObjectPropertyKeys.SysRole.IsSystem, this, false, true));
            Name = AddProperty(new DomainProperty<string, SysRole, SysRoleDomainObject>("Name", DomainObjectPropertyKeys.SysRole.Name, this, false, true));
            OwnerUserID = AddProperty(new DomainProperty<int?, SysRole, SysRoleDomainObject>("OwnerUserID", DomainObjectPropertyKeys.SysRole.OwnerUserID, this, false, true));
        }

        
        public DomainProperty<string, SysRole, SysRoleDomainObject> Description { get; private set; }

        public DomainProperty<int, SysRole, SysRoleDomainObject> Id { get; private set; }

        public DomainProperty<bool, SysRole, SysRoleDomainObject> IsOwnByUser { get; private set; }

        public DomainProperty<bool, SysRole, SysRoleDomainObject> IsSystem { get; private set; }

        public DomainProperty<string, SysRole, SysRoleDomainObject> Name { get; private set; }

        public DomainProperty<int?, SysRole, SysRoleDomainObject> OwnerUserID { get; private set; }
    }
    #endregion
    #region SysRolePermission

    public sealed class SysRolePermissionDomainObject : DomainObject<SysRolePermission, SysRolePermissionDomainObject>
    {
        public SysRolePermissionDomainObject()
            : base("SysRolePermission", DomainObjectKeys.SysRolePermission, 3, true)
        {
            Id = AddProperty(new DomainProperty<int, SysRolePermission, SysRolePermissionDomainObject>("Id", DomainObjectPropertyKeys.SysRolePermission.Id, this, false, true));
            PermissionId = AddProperty(new DomainProperty<int, SysRolePermission, SysRolePermissionDomainObject>("PermissionId", DomainObjectPropertyKeys.SysRolePermission.PermissionId, this, false, true));
            RoleId = AddProperty(new DomainProperty<int, SysRolePermission, SysRolePermissionDomainObject>("RoleId", DomainObjectPropertyKeys.SysRolePermission.RoleId, this, false, true));
        }

        
        public DomainProperty<int, SysRolePermission, SysRolePermissionDomainObject> Id { get; private set; }

        public DomainProperty<int, SysRolePermission, SysRolePermissionDomainObject> PermissionId { get; private set; }

        public DomainProperty<int, SysRolePermission, SysRolePermissionDomainObject> RoleId { get; private set; }
    }
    #endregion
    #region SysSetting

    public sealed class SysSettingDomainObject : DomainObject<SysSetting, SysSettingDomainObject>
    {
        public SysSettingDomainObject()
            : base("SysSetting", DomainObjectKeys.SysSetting, 4, true)
        {
            Id = AddProperty(new DomainProperty<int, SysSetting, SysSettingDomainObject>("Id", DomainObjectPropertyKeys.SysSetting.Id, this, false, true));
            SettingPropertyId = AddProperty(new DomainProperty<int, SysSetting, SysSettingDomainObject>("SettingPropertyId", DomainObjectPropertyKeys.SysSetting.SettingPropertyId, this, false, true));
            StringValue = AddProperty(new DomainProperty<string, SysSetting, SysSettingDomainObject>("StringValue", DomainObjectPropertyKeys.SysSetting.StringValue, this, false, true));
            UserId = AddProperty(new DomainProperty<int?, SysSetting, SysSettingDomainObject>("UserId", DomainObjectPropertyKeys.SysSetting.UserId, this, false, true));
        }

        
        public DomainProperty<int, SysSetting, SysSettingDomainObject> Id { get; private set; }

        public DomainProperty<int, SysSetting, SysSettingDomainObject> SettingPropertyId { get; private set; }

        public DomainProperty<string, SysSetting, SysSettingDomainObject> StringValue { get; private set; }

        public DomainProperty<int?, SysSetting, SysSettingDomainObject> UserId { get; private set; }
    }
    #endregion
    #region SysSettingProperty

    public sealed class SysSettingPropertyDomainObject : DomainObject<SysSettingProperty, SysSettingPropertyDomainObject>
    {
        public SysSettingPropertyDomainObject()
            : base("SysSettingProperty", DomainObjectKeys.SysSettingProperty, 8, true)
        {
            DefaultType = AddProperty(new DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject>("DefaultType", DomainObjectPropertyKeys.SysSettingProperty.DefaultType, this, false, true));
            Description = AddProperty(new DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject>("Description", DomainObjectPropertyKeys.SysSettingProperty.Description, this, false, true));
            GroupName = AddProperty(new DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject>("GroupName", DomainObjectPropertyKeys.SysSettingProperty.GroupName, this, false, true));
            Id = AddProperty(new DomainProperty<int, SysSettingProperty, SysSettingPropertyDomainObject>("Id", DomainObjectPropertyKeys.SysSettingProperty.Id, this, false, true));
            IsManaged = AddProperty(new DomainProperty<bool, SysSettingProperty, SysSettingPropertyDomainObject>("IsManaged", DomainObjectPropertyKeys.SysSettingProperty.IsManaged, this, false, true));
            IsOverridable = AddProperty(new DomainProperty<bool, SysSettingProperty, SysSettingPropertyDomainObject>("IsOverridable", DomainObjectPropertyKeys.SysSettingProperty.IsOverridable, this, false, true));
            Name = AddProperty(new DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject>("Name", DomainObjectPropertyKeys.SysSettingProperty.Name, this, false, true));
            UIEditorType = AddProperty(new DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject>("UIEditorType", DomainObjectPropertyKeys.SysSettingProperty.UIEditorType, this, false, true));
        }

        
        public DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject> DefaultType { get; private set; }

        public DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject> Description { get; private set; }

        public DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject> GroupName { get; private set; }

        public DomainProperty<int, SysSettingProperty, SysSettingPropertyDomainObject> Id { get; private set; }

        public DomainProperty<bool, SysSettingProperty, SysSettingPropertyDomainObject> IsManaged { get; private set; }

        public DomainProperty<bool, SysSettingProperty, SysSettingPropertyDomainObject> IsOverridable { get; private set; }

        public DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject> Name { get; private set; }

        public DomainProperty<string, SysSettingProperty, SysSettingPropertyDomainObject> UIEditorType { get; private set; }
    }
    #endregion
    #region SysUser

    public sealed class SysUserDomainObject : DomainObject<SysUser, SysUserDomainObject>
    {
        public SysUserDomainObject()
            : base("SysUser", DomainObjectKeys.SysUser, 14, true)
        {
            AccountName = AddProperty(new DomainProperty<string, SysUser, SysUserDomainObject>("AccountName", DomainObjectPropertyKeys.SysUser.AccountName, this, false, true));
            CreateDate = AddProperty(new DomainProperty<DateTime, SysUser, SysUserDomainObject>("CreateDate", DomainObjectPropertyKeys.SysUser.CreateDate, this, false, false));
            DeactivationDate = AddProperty(new DomainProperty<DateTime?, SysUser, SysUserDomainObject>("DeactivationDate", DomainObjectPropertyKeys.SysUser.DeactivationDate, this, false, true));
            Description = AddProperty(new DomainProperty<string, SysUser, SysUserDomainObject>("Description", DomainObjectPropertyKeys.SysUser.Description, this, false, true));
            DisplayName = AddProperty(new DomainProperty<string, SysUser, SysUserDomainObject>("DisplayName", DomainObjectPropertyKeys.SysUser.DisplayName, this, false, true));
            EMail = AddProperty(new DomainProperty<string, SysUser, SysUserDomainObject>("EMail", DomainObjectPropertyKeys.SysUser.EMail, this, false, true));
            EmailToken = AddProperty(new DomainProperty<string, SysUser, SysUserDomainObject>("EmailToken", DomainObjectPropertyKeys.SysUser.EmailToken, this, false, true));
            FullAccess = AddProperty(new DomainProperty<bool, SysUser, SysUserDomainObject>("FullAccess", DomainObjectPropertyKeys.SysUser.FullAccess, this, false, true));
            Id = AddProperty(new DomainProperty<int, SysUser, SysUserDomainObject>("Id", DomainObjectPropertyKeys.SysUser.Id, this, false, true));
            IsAnonymous = AddProperty(new DomainProperty<bool, SysUser, SysUserDomainObject>("IsAnonymous", DomainObjectPropertyKeys.SysUser.IsAnonymous, this, false, true));
            IsDeactivated = AddProperty(new DomainProperty<bool, SysUser, SysUserDomainObject>("IsDeactivated", DomainObjectPropertyKeys.SysUser.IsDeactivated, this, false, true));
            IsEmailConfirmed = AddProperty(new DomainProperty<bool, SysUser, SysUserDomainObject>("IsEmailConfirmed", DomainObjectPropertyKeys.SysUser.IsEmailConfirmed, this, false, true));
            IsSystemUser = AddProperty(new DomainProperty<bool, SysUser, SysUserDomainObject>("IsSystemUser", DomainObjectPropertyKeys.SysUser.IsSystemUser, this, false, true));
            PasswordHash = AddProperty(new DomainProperty<byte[], SysUser, SysUserDomainObject>("PasswordHash", DomainObjectPropertyKeys.SysUser.PasswordHash, this, false, true));
        }

        
        public DomainProperty<string, SysUser, SysUserDomainObject> AccountName { get; private set; }

        public DomainProperty<DateTime, SysUser, SysUserDomainObject> CreateDate { get; private set; }

        public DomainProperty<DateTime?, SysUser, SysUserDomainObject> DeactivationDate { get; private set; }

        public DomainProperty<string, SysUser, SysUserDomainObject> Description { get; private set; }

        public DomainProperty<string, SysUser, SysUserDomainObject> DisplayName { get; private set; }

        public DomainProperty<string, SysUser, SysUserDomainObject> EMail { get; private set; }

        public DomainProperty<string, SysUser, SysUserDomainObject> EmailToken { get; private set; }

        public DomainProperty<bool, SysUser, SysUserDomainObject> FullAccess { get; private set; }

        public DomainProperty<int, SysUser, SysUserDomainObject> Id { get; private set; }

        public DomainProperty<bool, SysUser, SysUserDomainObject> IsAnonymous { get; private set; }

        public DomainProperty<bool, SysUser, SysUserDomainObject> IsDeactivated { get; private set; }

        public DomainProperty<bool, SysUser, SysUserDomainObject> IsEmailConfirmed { get; private set; }

        public DomainProperty<bool, SysUser, SysUserDomainObject> IsSystemUser { get; private set; }

        public DomainProperty<byte[], SysUser, SysUserDomainObject> PasswordHash { get; private set; }
    }
    #endregion
    #region SysUserPermissionsDisplayView

    public sealed class SysUserPermissionsDisplayViewDomainObject : DomainObject<SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject>
    {
        public SysUserPermissionsDisplayViewDomainObject()
            : base("SysUserPermissionsDisplayView", DomainObjectKeys.SysUserPermissionsDisplayView, 4, true)
        {
            PermissionId = AddProperty(new DomainProperty<int, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject>("PermissionId", DomainObjectPropertyKeys.SysUserPermissionsDisplayView.PermissionId, this, false, true));
            PermissionName = AddProperty(new DomainProperty<string, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject>("PermissionName", DomainObjectPropertyKeys.SysUserPermissionsDisplayView.PermissionName, this, false, true));
            Roles = AddProperty(new DomainProperty<string, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject>("Roles", DomainObjectPropertyKeys.SysUserPermissionsDisplayView.Roles, this, false, true));
            UserId = AddProperty(new DomainProperty<int, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject>("UserId", DomainObjectPropertyKeys.SysUserPermissionsDisplayView.UserId, this, false, true));
        }

        
        public DomainProperty<int, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject> PermissionId { get; private set; }

        public DomainProperty<string, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject> PermissionName { get; private set; }

        public DomainProperty<string, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject> Roles { get; private set; }

        public DomainProperty<int, SysUserPermissionsDisplayView, SysUserPermissionsDisplayViewDomainObject> UserId { get; private set; }
    }
    #endregion
    #region SysUserRole

    public sealed class SysUserRoleDomainObject : DomainObject<SysUserRole, SysUserRoleDomainObject>
    {
        public SysUserRoleDomainObject()
            : base("SysUserRole", DomainObjectKeys.SysUserRole, 3, true)
        {
            Id = AddProperty(new DomainProperty<int, SysUserRole, SysUserRoleDomainObject>("Id", DomainObjectPropertyKeys.SysUserRole.Id, this, false, true));
            RoleId = AddProperty(new DomainProperty<int, SysUserRole, SysUserRoleDomainObject>("RoleId", DomainObjectPropertyKeys.SysUserRole.RoleId, this, false, true));
            UserId = AddProperty(new DomainProperty<int, SysUserRole, SysUserRoleDomainObject>("UserId", DomainObjectPropertyKeys.SysUserRole.UserId, this, false, true));
        }

        
        public DomainProperty<int, SysUserRole, SysUserRoleDomainObject> Id { get; private set; }

        public DomainProperty<int, SysUserRole, SysUserRoleDomainObject> RoleId { get; private set; }

        public DomainProperty<int, SysUserRole, SysUserRoleDomainObject> UserId { get; private set; }
    }
    #endregion
    #region SysUsersDisplayView

    public sealed class SysUsersDisplayViewDomainObject : DomainObject<SysUsersDisplayView, SysUsersDisplayViewDomainObject>
    {
        public SysUsersDisplayViewDomainObject()
            : base("SysUsersDisplayView", DomainObjectKeys.SysUsersDisplayView, 2, true)
        {
            Id = AddProperty(new DomainProperty<int, SysUsersDisplayView, SysUsersDisplayViewDomainObject>("Id", DomainObjectPropertyKeys.SysUsersDisplayView.Id, this, false, true));
            UserRoleId = AddProperty(new DomainProperty<int?, SysUsersDisplayView, SysUsersDisplayViewDomainObject>("UserRoleId", DomainObjectPropertyKeys.SysUsersDisplayView.UserRoleId, this, false, true));
        }

        
        public DomainProperty<int, SysUsersDisplayView, SysUsersDisplayViewDomainObject> Id { get; private set; }

        public DomainProperty<int?, SysUsersDisplayView, SysUsersDisplayViewDomainObject> UserRoleId { get; private set; }
    }
    #endregion
    #region Territory

    public sealed class TerritoryDomainObject : DomainObject<Territory, TerritoryDomainObject>
    {
        public TerritoryDomainObject()
            : base("Territory", DomainObjectKeys.Territory, 3, false)
        {
            Id = AddProperty(new DomainProperty<int, Territory, TerritoryDomainObject>("Id", DomainObjectPropertyKeys.Territory.Id, this, false, false));
            RegionID = AddProperty(new DomainProperty<int, Territory, TerritoryDomainObject>("RegionID", DomainObjectPropertyKeys.Territory.RegionID, this, false, false));
            TerritoryDescription = AddProperty(new DomainProperty<string, Territory, TerritoryDomainObject>("TerritoryDescription", DomainObjectPropertyKeys.Territory.TerritoryDescription, this, false, false));
        }

        
        public DomainProperty<int, Territory, TerritoryDomainObject> Id { get; private set; }

        public DomainProperty<int, Territory, TerritoryDomainObject> RegionID { get; private set; }

        public DomainProperty<string, Territory, TerritoryDomainObject> TerritoryDescription { get; private set; }
    }
    #endregion
}

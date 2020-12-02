using System;
using BusinessFramework.WebAPI.Contracts.Files;
using BusinessFramework.WebAPI.Contracts.Metadata;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain objects
    /// </summary>
    public static class DomainObjects
    {
        public static readonly CategoryDomainObject Category = new CategoryDomainObject();
        public static readonly CustomerDomainObject Customer = new CustomerDomainObject();
        public static readonly EmployeeDomainObject Employee = new EmployeeDomainObject();
        public static readonly OrderDomainObject Order = new OrderDomainObject();
        public static readonly OrderDetailDomainObject OrderDetail = new OrderDetailDomainObject();
        public static readonly OrderStatusDomainObject OrderStatus = new OrderStatusDomainObject();
        public static readonly ProductDomainObject Product = new ProductDomainObject();
        public static readonly QCategoriesDomainObject QCategories = new QCategoriesDomainObject();
        public static readonly QCustomersDomainObject QCustomers = new QCustomersDomainObject();
        public static readonly QEmployeesDomainObject QEmployees = new QEmployeesDomainObject();
        public static readonly QOrderProductsDomainObject QOrderProducts = new QOrderProductsDomainObject();
        public static readonly QOrdersDomainObject QOrders = new QOrdersDomainObject();
        public static readonly QProductsDomainObject QProducts = new QProductsDomainObject();
        public static readonly QShippersDomainObject QShippers = new QShippersDomainObject();
        public static readonly QSuppliersDomainObject QSuppliers = new QSuppliersDomainObject();
        public static readonly ShipperDomainObject Shipper = new ShipperDomainObject();
        public static readonly SupplierDomainObject Supplier = new SupplierDomainObject();
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
        public static readonly VSalesByCategoryDomainObject VSalesByCategory = new VSalesByCategoryDomainObject();
        public static readonly DomainMetadataDictionary ObjResolver = new DomainMetadataDictionary(Category, Customer, Employee, Order, OrderDetail, OrderStatus, Product, QCategories, QCustomers, QEmployees, QOrderProducts, QOrders, QProducts, QShippers, QSuppliers, Shipper, Supplier, SysInfo, SysObject, SysObjectClass, SysObjectType, SysOperation, SysOperationLock, SysOperationResult, SysPermission, SysPermissionType, SysRefreshToken, SysResetPasswordToken, SysRole, SysRolePermission, SysSetting, SysSettingProperty, SysUser, SysUserPermissionsDisplayView, SysUserRole, SysUsersDisplayView, VSalesByCategory);
    }
    


    //--
    #region Category

    public sealed class CategoryDomainObject : DomainObject<Category, CategoryDomainObject>
    {
        public CategoryDomainObject()
            : base("Category", DomainObjectKeys.Category, 4, false)
        {
            CategoryName = AddProperty(new DomainProperty<string, Category, CategoryDomainObject>("CategoryName", DomainObjectPropertyKeys.Category.CategoryName, this, false, false));
            Description = AddProperty(new DomainProperty<string, Category, CategoryDomainObject>("Description", DomainObjectPropertyKeys.Category.Description, this, false, false));
            Id = AddProperty(new DomainProperty<int, Category, CategoryDomainObject>("Id", DomainObjectPropertyKeys.Category.Id, this, false, false));
            Picture = AddProperty(new DomainProperty<byte[], Category, CategoryDomainObject>("Picture", DomainObjectPropertyKeys.Category.Picture, this, false, false));
        }

        
        public DomainProperty<string, Category, CategoryDomainObject> CategoryName { get; private set; }

        public DomainProperty<string, Category, CategoryDomainObject> Description { get; private set; }

        public DomainProperty<int, Category, CategoryDomainObject> Id { get; private set; }

        public DomainProperty<byte[], Category, CategoryDomainObject> Picture { get; private set; }
    }
    #endregion
    #region Customer

    public sealed class CustomerDomainObject : DomainObject<Customer, CustomerDomainObject>
    {
        public CustomerDomainObject()
            : base("Customer", DomainObjectKeys.Customer, 11, false)
        {
            Address = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("Address", DomainObjectPropertyKeys.Customer.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("City", DomainObjectPropertyKeys.Customer.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("CompanyName", DomainObjectPropertyKeys.Customer.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("ContactName", DomainObjectPropertyKeys.Customer.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("ContactTitle", DomainObjectPropertyKeys.Customer.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("Country", DomainObjectPropertyKeys.Customer.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("Fax", DomainObjectPropertyKeys.Customer.Fax, this, false, false));
            Id = AddProperty(new DomainProperty<int, Customer, CustomerDomainObject>("Id", DomainObjectPropertyKeys.Customer.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("Phone", DomainObjectPropertyKeys.Customer.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("PostalCode", DomainObjectPropertyKeys.Customer.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, Customer, CustomerDomainObject>("Region", DomainObjectPropertyKeys.Customer.Region, this, false, false));
        }

        
        public DomainProperty<string, Customer, CustomerDomainObject> Address { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> City { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> ContactName { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> Country { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> Fax { get; private set; }

        public DomainProperty<int, Customer, CustomerDomainObject> Id { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> Phone { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, Customer, CustomerDomainObject> Region { get; private set; }
    }
    #endregion
    #region Employee

    public sealed class EmployeeDomainObject : DomainObject<Employee, EmployeeDomainObject>
    {
        public EmployeeDomainObject()
            : base("Employee", DomainObjectKeys.Employee, 18, false)
        {
            Address = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("Address", DomainObjectPropertyKeys.Employee.Address, this, false, false));
            BirthDate = AddProperty(new DomainProperty<DateTime?, Employee, EmployeeDomainObject>("BirthDate", DomainObjectPropertyKeys.Employee.BirthDate, this, false, false));
            City = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("City", DomainObjectPropertyKeys.Employee.City, this, false, false));
            Country = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("Country", DomainObjectPropertyKeys.Employee.Country, this, false, false));
            Extension = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("Extension", DomainObjectPropertyKeys.Employee.Extension, this, false, false));
            FirstName = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("FirstName", DomainObjectPropertyKeys.Employee.FirstName, this, false, false));
            HireDate = AddProperty(new DomainProperty<DateTime?, Employee, EmployeeDomainObject>("HireDate", DomainObjectPropertyKeys.Employee.HireDate, this, false, false));
            HomePhone = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("HomePhone", DomainObjectPropertyKeys.Employee.HomePhone, this, false, false));
            Id = AddProperty(new DomainProperty<int, Employee, EmployeeDomainObject>("Id", DomainObjectPropertyKeys.Employee.Id, this, false, false));
            LastName = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("LastName", DomainObjectPropertyKeys.Employee.LastName, this, false, false));
            Notes = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("Notes", DomainObjectPropertyKeys.Employee.Notes, this, false, false));
            Photo = AddProperty(new DomainProperty<byte[], Employee, EmployeeDomainObject>("Photo", DomainObjectPropertyKeys.Employee.Photo, this, false, false));
            PhotoPath = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("PhotoPath", DomainObjectPropertyKeys.Employee.PhotoPath, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("PostalCode", DomainObjectPropertyKeys.Employee.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("Region", DomainObjectPropertyKeys.Employee.Region, this, false, false));
            ReportsTo = AddProperty(new DomainProperty<int?, Employee, EmployeeDomainObject>("ReportsTo", DomainObjectPropertyKeys.Employee.ReportsTo, this, false, false));
            Title = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("Title", DomainObjectPropertyKeys.Employee.Title, this, false, false));
            TitleOfCourtesy = AddProperty(new DomainProperty<string, Employee, EmployeeDomainObject>("TitleOfCourtesy", DomainObjectPropertyKeys.Employee.TitleOfCourtesy, this, false, false));
        }

        
        public DomainProperty<string, Employee, EmployeeDomainObject> Address { get; private set; }

        public DomainProperty<DateTime?, Employee, EmployeeDomainObject> BirthDate { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> City { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> Country { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> Extension { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> FirstName { get; private set; }

        public DomainProperty<DateTime?, Employee, EmployeeDomainObject> HireDate { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> HomePhone { get; private set; }

        public DomainProperty<int, Employee, EmployeeDomainObject> Id { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> LastName { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> Notes { get; private set; }

        public DomainProperty<byte[], Employee, EmployeeDomainObject> Photo { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> PhotoPath { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> Region { get; private set; }

        public DomainProperty<int?, Employee, EmployeeDomainObject> ReportsTo { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> Title { get; private set; }

        public DomainProperty<string, Employee, EmployeeDomainObject> TitleOfCourtesy { get; private set; }
    }
    #endregion
    #region Order

    public sealed class OrderDomainObject : DomainObject<Order, OrderDomainObject>
    {
        public OrderDomainObject()
            : base("Order", DomainObjectKeys.Order, 15, false)
        {
            CustomerID = AddProperty(new DomainProperty<int?, Order, OrderDomainObject>("CustomerID", DomainObjectPropertyKeys.Order.CustomerID, this, false, false));
            EmployeeID = AddProperty(new DomainProperty<int?, Order, OrderDomainObject>("EmployeeID", DomainObjectPropertyKeys.Order.EmployeeID, this, false, false));
            Freight = AddProperty(new DomainProperty<decimal?, Order, OrderDomainObject>("Freight", DomainObjectPropertyKeys.Order.Freight, this, false, false));
            Id = AddProperty(new DomainProperty<int, Order, OrderDomainObject>("Id", DomainObjectPropertyKeys.Order.Id, this, false, false));
            OrderDate = AddProperty(new DomainProperty<DateTime?, Order, OrderDomainObject>("OrderDate", DomainObjectPropertyKeys.Order.OrderDate, this, false, false));
            RequiredDate = AddProperty(new DomainProperty<DateTime?, Order, OrderDomainObject>("RequiredDate", DomainObjectPropertyKeys.Order.RequiredDate, this, false, false));
            ShipAddress = AddProperty(new DomainProperty<string, Order, OrderDomainObject>("ShipAddress", DomainObjectPropertyKeys.Order.ShipAddress, this, false, false));
            ShipCity = AddProperty(new DomainProperty<string, Order, OrderDomainObject>("ShipCity", DomainObjectPropertyKeys.Order.ShipCity, this, false, false));
            ShipCountry = AddProperty(new DomainProperty<string, Order, OrderDomainObject>("ShipCountry", DomainObjectPropertyKeys.Order.ShipCountry, this, false, false));
            ShipName = AddProperty(new DomainProperty<string, Order, OrderDomainObject>("ShipName", DomainObjectPropertyKeys.Order.ShipName, this, false, false));
            ShippedDate = AddProperty(new DomainProperty<DateTime?, Order, OrderDomainObject>("ShippedDate", DomainObjectPropertyKeys.Order.ShippedDate, this, false, false));
            ShipPostalCode = AddProperty(new DomainProperty<string, Order, OrderDomainObject>("ShipPostalCode", DomainObjectPropertyKeys.Order.ShipPostalCode, this, false, false));
            ShipRegion = AddProperty(new DomainProperty<string, Order, OrderDomainObject>("ShipRegion", DomainObjectPropertyKeys.Order.ShipRegion, this, false, false));
            ShipVia = AddProperty(new DomainProperty<int?, Order, OrderDomainObject>("ShipVia", DomainObjectPropertyKeys.Order.ShipVia, this, false, false));
            StatusID = AddProperty(new DomainProperty<short?, Order, OrderDomainObject>("StatusID", DomainObjectPropertyKeys.Order.StatusID, this, false, false));
        }

        
        public DomainProperty<int?, Order, OrderDomainObject> CustomerID { get; private set; }

        public DomainProperty<int?, Order, OrderDomainObject> EmployeeID { get; private set; }

        public DomainProperty<decimal?, Order, OrderDomainObject> Freight { get; private set; }

        public DomainProperty<int, Order, OrderDomainObject> Id { get; private set; }

        public DomainProperty<DateTime?, Order, OrderDomainObject> OrderDate { get; private set; }

        public DomainProperty<DateTime?, Order, OrderDomainObject> RequiredDate { get; private set; }

        public DomainProperty<string, Order, OrderDomainObject> ShipAddress { get; private set; }

        public DomainProperty<string, Order, OrderDomainObject> ShipCity { get; private set; }

        public DomainProperty<string, Order, OrderDomainObject> ShipCountry { get; private set; }

        public DomainProperty<string, Order, OrderDomainObject> ShipName { get; private set; }

        public DomainProperty<DateTime?, Order, OrderDomainObject> ShippedDate { get; private set; }

        public DomainProperty<string, Order, OrderDomainObject> ShipPostalCode { get; private set; }

        public DomainProperty<string, Order, OrderDomainObject> ShipRegion { get; private set; }

        public DomainProperty<int?, Order, OrderDomainObject> ShipVia { get; private set; }

        public DomainProperty<short?, Order, OrderDomainObject> StatusID { get; private set; }
    }
    #endregion
    #region OrderDetail

    public sealed class OrderDetailDomainObject : DomainObject<OrderDetail, OrderDetailDomainObject>
    {
        public OrderDetailDomainObject()
            : base("OrderDetail", DomainObjectKeys.OrderDetail, 6, false)
        {
            Discount = AddProperty(new DomainProperty<float, OrderDetail, OrderDetailDomainObject>("Discount", DomainObjectPropertyKeys.OrderDetail.Discount, this, false, false));
            Id = AddProperty(new DomainProperty<int, OrderDetail, OrderDetailDomainObject>("Id", DomainObjectPropertyKeys.OrderDetail.Id, this, false, false));
            OrderID = AddProperty(new DomainProperty<int, OrderDetail, OrderDetailDomainObject>("OrderID", DomainObjectPropertyKeys.OrderDetail.OrderID, this, false, false));
            ProductID = AddProperty(new DomainProperty<int, OrderDetail, OrderDetailDomainObject>("ProductID", DomainObjectPropertyKeys.OrderDetail.ProductID, this, false, false));
            Quantity = AddProperty(new DomainProperty<short, OrderDetail, OrderDetailDomainObject>("Quantity", DomainObjectPropertyKeys.OrderDetail.Quantity, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal, OrderDetail, OrderDetailDomainObject>("UnitPrice", DomainObjectPropertyKeys.OrderDetail.UnitPrice, this, false, false));
        }

        
        public DomainProperty<float, OrderDetail, OrderDetailDomainObject> Discount { get; private set; }

        public DomainProperty<int, OrderDetail, OrderDetailDomainObject> Id { get; private set; }

        public DomainProperty<int, OrderDetail, OrderDetailDomainObject> OrderID { get; private set; }

        public DomainProperty<int, OrderDetail, OrderDetailDomainObject> ProductID { get; private set; }

        public DomainProperty<short, OrderDetail, OrderDetailDomainObject> Quantity { get; private set; }

        public DomainProperty<decimal, OrderDetail, OrderDetailDomainObject> UnitPrice { get; private set; }
    }
    #endregion
    #region OrderStatus

    public sealed class OrderStatusDomainObject : DomainObject<OrderStatus, OrderStatusDomainObject>
    {
        public OrderStatusDomainObject()
            : base("OrderStatus", DomainObjectKeys.OrderStatus, 2, false)
        {
            Id = AddProperty(new DomainProperty<short, OrderStatus, OrderStatusDomainObject>("Id", DomainObjectPropertyKeys.OrderStatus.Id, this, false, false));
            Name = AddProperty(new DomainProperty<string, OrderStatus, OrderStatusDomainObject>("Name", DomainObjectPropertyKeys.OrderStatus.Name, this, false, false));
        }

        
        public DomainProperty<short, OrderStatus, OrderStatusDomainObject> Id { get; private set; }

        public DomainProperty<string, OrderStatus, OrderStatusDomainObject> Name { get; private set; }
    }
    #endregion
    #region Product

    public sealed class ProductDomainObject : DomainObject<Product, ProductDomainObject>
    {
        public ProductDomainObject()
            : base("Product", DomainObjectKeys.Product, 10, false)
        {
            CategoryID = AddProperty(new DomainProperty<int?, Product, ProductDomainObject>("CategoryID", DomainObjectPropertyKeys.Product.CategoryID, this, false, false));
            Discontinued = AddProperty(new DomainProperty<bool, Product, ProductDomainObject>("Discontinued", DomainObjectPropertyKeys.Product.Discontinued, this, false, false));
            Id = AddProperty(new DomainProperty<int, Product, ProductDomainObject>("Id", DomainObjectPropertyKeys.Product.Id, this, false, false));
            ProductName = AddProperty(new DomainProperty<string, Product, ProductDomainObject>("ProductName", DomainObjectPropertyKeys.Product.ProductName, this, false, false));
            QuantityPerUnit = AddProperty(new DomainProperty<string, Product, ProductDomainObject>("QuantityPerUnit", DomainObjectPropertyKeys.Product.QuantityPerUnit, this, false, false));
            ReorderLevel = AddProperty(new DomainProperty<short?, Product, ProductDomainObject>("ReorderLevel", DomainObjectPropertyKeys.Product.ReorderLevel, this, false, false));
            SupplierID = AddProperty(new DomainProperty<int?, Product, ProductDomainObject>("SupplierID", DomainObjectPropertyKeys.Product.SupplierID, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal?, Product, ProductDomainObject>("UnitPrice", DomainObjectPropertyKeys.Product.UnitPrice, this, false, false));
            UnitsInStock = AddProperty(new DomainProperty<short?, Product, ProductDomainObject>("UnitsInStock", DomainObjectPropertyKeys.Product.UnitsInStock, this, false, false));
            UnitsOnOrder = AddProperty(new DomainProperty<short?, Product, ProductDomainObject>("UnitsOnOrder", DomainObjectPropertyKeys.Product.UnitsOnOrder, this, false, false));
        }

        
        public DomainProperty<int?, Product, ProductDomainObject> CategoryID { get; private set; }

        public DomainProperty<bool, Product, ProductDomainObject> Discontinued { get; private set; }

        public DomainProperty<int, Product, ProductDomainObject> Id { get; private set; }

        public DomainProperty<string, Product, ProductDomainObject> ProductName { get; private set; }

        public DomainProperty<string, Product, ProductDomainObject> QuantityPerUnit { get; private set; }

        public DomainProperty<short?, Product, ProductDomainObject> ReorderLevel { get; private set; }

        public DomainProperty<int?, Product, ProductDomainObject> SupplierID { get; private set; }

        public DomainProperty<decimal?, Product, ProductDomainObject> UnitPrice { get; private set; }

        public DomainProperty<short?, Product, ProductDomainObject> UnitsInStock { get; private set; }

        public DomainProperty<short?, Product, ProductDomainObject> UnitsOnOrder { get; private set; }
    }
    #endregion
    #region QCategories

    public sealed class QCategoriesDomainObject : DomainObject<QCategories, QCategoriesDomainObject>
    {
        public QCategoriesDomainObject()
            : base("QCategories", DomainObjectKeys.QCategories, 4, false)
        {
            CategoryName = AddProperty(new DomainProperty<string, QCategories, QCategoriesDomainObject>("CategoryName", DomainObjectPropertyKeys.QCategories.CategoryName, this, false, false));
            Description = AddProperty(new DomainProperty<string, QCategories, QCategoriesDomainObject>("Description", DomainObjectPropertyKeys.QCategories.Description, this, false, false));
            Id = AddProperty(new DomainProperty<int, QCategories, QCategoriesDomainObject>("Id", DomainObjectPropertyKeys.QCategories.Id, this, false, false));
            Picture = AddProperty(new DomainProperty<byte[], QCategories, QCategoriesDomainObject>("Picture", DomainObjectPropertyKeys.QCategories.Picture, this, false, false));
        }

        
        public DomainProperty<string, QCategories, QCategoriesDomainObject> CategoryName { get; private set; }

        public DomainProperty<string, QCategories, QCategoriesDomainObject> Description { get; private set; }

        public DomainProperty<int, QCategories, QCategoriesDomainObject> Id { get; private set; }

        public DomainProperty<byte[], QCategories, QCategoriesDomainObject> Picture { get; private set; }
    }
    #endregion
    #region QCustomers

    public sealed class QCustomersDomainObject : DomainObject<QCustomers, QCustomersDomainObject>
    {
        public QCustomersDomainObject()
            : base("QCustomers", DomainObjectKeys.QCustomers, 11, false)
        {
            Address = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("Address", DomainObjectPropertyKeys.QCustomers.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("City", DomainObjectPropertyKeys.QCustomers.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("CompanyName", DomainObjectPropertyKeys.QCustomers.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("ContactName", DomainObjectPropertyKeys.QCustomers.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("ContactTitle", DomainObjectPropertyKeys.QCustomers.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("Country", DomainObjectPropertyKeys.QCustomers.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("Fax", DomainObjectPropertyKeys.QCustomers.Fax, this, false, false));
            Id = AddProperty(new DomainProperty<int, QCustomers, QCustomersDomainObject>("Id", DomainObjectPropertyKeys.QCustomers.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("Phone", DomainObjectPropertyKeys.QCustomers.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("PostalCode", DomainObjectPropertyKeys.QCustomers.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, QCustomers, QCustomersDomainObject>("Region", DomainObjectPropertyKeys.QCustomers.Region, this, false, false));
        }

        
        public DomainProperty<string, QCustomers, QCustomersDomainObject> Address { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> City { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> ContactName { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> Country { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> Fax { get; private set; }

        public DomainProperty<int, QCustomers, QCustomersDomainObject> Id { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> Phone { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, QCustomers, QCustomersDomainObject> Region { get; private set; }
    }
    #endregion
    #region QEmployees

    public sealed class QEmployeesDomainObject : DomainObject<QEmployees, QEmployeesDomainObject>
    {
        public QEmployeesDomainObject()
            : base("QEmployees", DomainObjectKeys.QEmployees, 17, false)
        {
            Address = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Address", DomainObjectPropertyKeys.QEmployees.Address, this, false, false));
            BirthDate = AddProperty(new DomainProperty<DateTime?, QEmployees, QEmployeesDomainObject>("BirthDate", DomainObjectPropertyKeys.QEmployees.BirthDate, this, false, false));
            City = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("City", DomainObjectPropertyKeys.QEmployees.City, this, false, false));
            Country = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Country", DomainObjectPropertyKeys.QEmployees.Country, this, false, false));
            Employee_FullName = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Employee_FullName", DomainObjectPropertyKeys.QEmployees.Employee_FullName, this, false, false));
            Extension = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Extension", DomainObjectPropertyKeys.QEmployees.Extension, this, false, false));
            FirstName = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("FirstName", DomainObjectPropertyKeys.QEmployees.FirstName, this, false, false));
            HireDate = AddProperty(new DomainProperty<DateTime?, QEmployees, QEmployeesDomainObject>("HireDate", DomainObjectPropertyKeys.QEmployees.HireDate, this, false, false));
            HomePhone = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("HomePhone", DomainObjectPropertyKeys.QEmployees.HomePhone, this, false, false));
            Id = AddProperty(new DomainProperty<int, QEmployees, QEmployeesDomainObject>("Id", DomainObjectPropertyKeys.QEmployees.Id, this, false, false));
            LastName = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("LastName", DomainObjectPropertyKeys.QEmployees.LastName, this, false, false));
            Notes = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Notes", DomainObjectPropertyKeys.QEmployees.Notes, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("PostalCode", DomainObjectPropertyKeys.QEmployees.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Region", DomainObjectPropertyKeys.QEmployees.Region, this, false, false));
            ReportsTo = AddProperty(new DomainProperty<int?, QEmployees, QEmployeesDomainObject>("ReportsTo", DomainObjectPropertyKeys.QEmployees.ReportsTo, this, false, false));
            Title = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("Title", DomainObjectPropertyKeys.QEmployees.Title, this, false, false));
            TitleOfCourtesy = AddProperty(new DomainProperty<string, QEmployees, QEmployeesDomainObject>("TitleOfCourtesy", DomainObjectPropertyKeys.QEmployees.TitleOfCourtesy, this, false, false));
        }

        
        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Address { get; private set; }

        public DomainProperty<DateTime?, QEmployees, QEmployeesDomainObject> BirthDate { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> City { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Country { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Employee_FullName { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Extension { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> FirstName { get; private set; }

        public DomainProperty<DateTime?, QEmployees, QEmployeesDomainObject> HireDate { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> HomePhone { get; private set; }

        public DomainProperty<int, QEmployees, QEmployeesDomainObject> Id { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> LastName { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Notes { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Region { get; private set; }

        public DomainProperty<int?, QEmployees, QEmployeesDomainObject> ReportsTo { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> Title { get; private set; }

        public DomainProperty<string, QEmployees, QEmployeesDomainObject> TitleOfCourtesy { get; private set; }
    }
    #endregion
    #region QOrderProducts

    public sealed class QOrderProductsDomainObject : DomainObject<QOrderProducts, QOrderProductsDomainObject>
    {
        public QOrderProductsDomainObject()
            : base("QOrderProducts", DomainObjectKeys.QOrderProducts, 30, false)
        {
            Discount = AddProperty(new DomainProperty<float, QOrderProducts, QOrderProductsDomainObject>("Discount", DomainObjectPropertyKeys.QOrderProducts.Discount, this, false, false));
            Id = AddProperty(new DomainProperty<int, QOrderProducts, QOrderProductsDomainObject>("Id", DomainObjectPropertyKeys.QOrderProducts.Id, this, false, false));
            OrderID = AddProperty(new DomainProperty<int, QOrderProducts, QOrderProductsDomainObject>("OrderID", DomainObjectPropertyKeys.QOrderProducts.OrderID, this, false, false));
            Orders_CustomerID = AddProperty(new DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject>("Orders_CustomerID", DomainObjectPropertyKeys.QOrderProducts.Orders_CustomerID, this, false, false));
            Orders_EmployeeID = AddProperty(new DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject>("Orders_EmployeeID", DomainObjectPropertyKeys.QOrderProducts.Orders_EmployeeID, this, false, false));
            Orders_Freight = AddProperty(new DomainProperty<decimal?, QOrderProducts, QOrderProductsDomainObject>("Orders_Freight", DomainObjectPropertyKeys.QOrderProducts.Orders_Freight, this, false, false));
            Orders_Id = AddProperty(new DomainProperty<int, QOrderProducts, QOrderProductsDomainObject>("Orders_Id", DomainObjectPropertyKeys.QOrderProducts.Orders_Id, this, false, false));
            Orders_OrderDate = AddProperty(new DomainProperty<DateTime?, QOrderProducts, QOrderProductsDomainObject>("Orders_OrderDate", DomainObjectPropertyKeys.QOrderProducts.Orders_OrderDate, this, false, false));
            Orders_RequiredDate = AddProperty(new DomainProperty<DateTime?, QOrderProducts, QOrderProductsDomainObject>("Orders_RequiredDate", DomainObjectPropertyKeys.QOrderProducts.Orders_RequiredDate, this, false, false));
            Orders_ShipAddress = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipAddress", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipAddress, this, false, false));
            Orders_ShipCity = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipCity", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipCity, this, false, false));
            Orders_ShipCountry = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipCountry", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipCountry, this, false, false));
            Orders_ShipName = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipName", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipName, this, false, false));
            Orders_ShippedDate = AddProperty(new DomainProperty<DateTime?, QOrderProducts, QOrderProductsDomainObject>("Orders_ShippedDate", DomainObjectPropertyKeys.QOrderProducts.Orders_ShippedDate, this, false, false));
            Orders_ShipPostalCode = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipPostalCode", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipPostalCode, this, false, false));
            Orders_ShipRegion = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipRegion", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipRegion, this, false, false));
            Orders_ShipVia = AddProperty(new DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject>("Orders_ShipVia", DomainObjectPropertyKeys.QOrderProducts.Orders_ShipVia, this, false, false));
            ProductID = AddProperty(new DomainProperty<int, QOrderProducts, QOrderProductsDomainObject>("ProductID", DomainObjectPropertyKeys.QOrderProducts.ProductID, this, false, false));
            Products_CategoryID = AddProperty(new DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject>("Products_CategoryID", DomainObjectPropertyKeys.QOrderProducts.Products_CategoryID, this, false, false));
            Products_Discontinued = AddProperty(new DomainProperty<bool, QOrderProducts, QOrderProductsDomainObject>("Products_Discontinued", DomainObjectPropertyKeys.QOrderProducts.Products_Discontinued, this, false, false));
            Products_Id = AddProperty(new DomainProperty<int, QOrderProducts, QOrderProductsDomainObject>("Products_Id", DomainObjectPropertyKeys.QOrderProducts.Products_Id, this, false, false));
            Products_ProductName = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Products_ProductName", DomainObjectPropertyKeys.QOrderProducts.Products_ProductName, this, false, false));
            Products_QuantityPerUnit = AddProperty(new DomainProperty<string, QOrderProducts, QOrderProductsDomainObject>("Products_QuantityPerUnit", DomainObjectPropertyKeys.QOrderProducts.Products_QuantityPerUnit, this, false, false));
            Products_ReorderLevel = AddProperty(new DomainProperty<short?, QOrderProducts, QOrderProductsDomainObject>("Products_ReorderLevel", DomainObjectPropertyKeys.QOrderProducts.Products_ReorderLevel, this, false, false));
            Products_SupplierID = AddProperty(new DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject>("Products_SupplierID", DomainObjectPropertyKeys.QOrderProducts.Products_SupplierID, this, false, false));
            Products_UnitPrice = AddProperty(new DomainProperty<decimal?, QOrderProducts, QOrderProductsDomainObject>("Products_UnitPrice", DomainObjectPropertyKeys.QOrderProducts.Products_UnitPrice, this, false, false));
            Products_UnitsInStock = AddProperty(new DomainProperty<short?, QOrderProducts, QOrderProductsDomainObject>("Products_UnitsInStock", DomainObjectPropertyKeys.QOrderProducts.Products_UnitsInStock, this, false, false));
            Products_UnitsOnOrder = AddProperty(new DomainProperty<short?, QOrderProducts, QOrderProductsDomainObject>("Products_UnitsOnOrder", DomainObjectPropertyKeys.QOrderProducts.Products_UnitsOnOrder, this, false, false));
            Quantity = AddProperty(new DomainProperty<short, QOrderProducts, QOrderProductsDomainObject>("Quantity", DomainObjectPropertyKeys.QOrderProducts.Quantity, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal, QOrderProducts, QOrderProductsDomainObject>("UnitPrice", DomainObjectPropertyKeys.QOrderProducts.UnitPrice, this, false, false));
        }

        
        public DomainProperty<float, QOrderProducts, QOrderProductsDomainObject> Discount { get; private set; }

        public DomainProperty<int, QOrderProducts, QOrderProductsDomainObject> Id { get; private set; }

        public DomainProperty<int, QOrderProducts, QOrderProductsDomainObject> OrderID { get; private set; }

        public DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject> Orders_CustomerID { get; private set; }

        public DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject> Orders_EmployeeID { get; private set; }

        public DomainProperty<decimal?, QOrderProducts, QOrderProductsDomainObject> Orders_Freight { get; private set; }

        public DomainProperty<int, QOrderProducts, QOrderProductsDomainObject> Orders_Id { get; private set; }

        public DomainProperty<DateTime?, QOrderProducts, QOrderProductsDomainObject> Orders_OrderDate { get; private set; }

        public DomainProperty<DateTime?, QOrderProducts, QOrderProductsDomainObject> Orders_RequiredDate { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Orders_ShipAddress { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Orders_ShipCity { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Orders_ShipCountry { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Orders_ShipName { get; private set; }

        public DomainProperty<DateTime?, QOrderProducts, QOrderProductsDomainObject> Orders_ShippedDate { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Orders_ShipPostalCode { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Orders_ShipRegion { get; private set; }

        public DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject> Orders_ShipVia { get; private set; }

        public DomainProperty<int, QOrderProducts, QOrderProductsDomainObject> ProductID { get; private set; }

        public DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject> Products_CategoryID { get; private set; }

        public DomainProperty<bool, QOrderProducts, QOrderProductsDomainObject> Products_Discontinued { get; private set; }

        public DomainProperty<int, QOrderProducts, QOrderProductsDomainObject> Products_Id { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Products_ProductName { get; private set; }

        public DomainProperty<string, QOrderProducts, QOrderProductsDomainObject> Products_QuantityPerUnit { get; private set; }

        public DomainProperty<short?, QOrderProducts, QOrderProductsDomainObject> Products_ReorderLevel { get; private set; }

        public DomainProperty<int?, QOrderProducts, QOrderProductsDomainObject> Products_SupplierID { get; private set; }

        public DomainProperty<decimal?, QOrderProducts, QOrderProductsDomainObject> Products_UnitPrice { get; private set; }

        public DomainProperty<short?, QOrderProducts, QOrderProductsDomainObject> Products_UnitsInStock { get; private set; }

        public DomainProperty<short?, QOrderProducts, QOrderProductsDomainObject> Products_UnitsOnOrder { get; private set; }

        public DomainProperty<short, QOrderProducts, QOrderProductsDomainObject> Quantity { get; private set; }

        public DomainProperty<decimal, QOrderProducts, QOrderProductsDomainObject> UnitPrice { get; private set; }
    }
    #endregion
    #region QOrders

    public sealed class QOrdersDomainObject : DomainObject<QOrders, QOrdersDomainObject>
    {
        public QOrdersDomainObject()
            : base("QOrders", DomainObjectKeys.QOrders, 46, false)
        {
            CustomerID = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("CustomerID", DomainObjectPropertyKeys.QOrders.CustomerID, this, false, false));
            Customers_Address = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_Address", DomainObjectPropertyKeys.QOrders.Customers_Address, this, false, false));
            Customers_City = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_City", DomainObjectPropertyKeys.QOrders.Customers_City, this, false, false));
            Customers_CompanyName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_CompanyName", DomainObjectPropertyKeys.QOrders.Customers_CompanyName, this, false, false));
            Customers_ContactName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_ContactName", DomainObjectPropertyKeys.QOrders.Customers_ContactName, this, false, false));
            Customers_ContactTitle = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_ContactTitle", DomainObjectPropertyKeys.QOrders.Customers_ContactTitle, this, false, false));
            Customers_Country = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_Country", DomainObjectPropertyKeys.QOrders.Customers_Country, this, false, false));
            Customers_Fax = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_Fax", DomainObjectPropertyKeys.QOrders.Customers_Fax, this, false, false));
            Customers_Id = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("Customers_Id", DomainObjectPropertyKeys.QOrders.Customers_Id, this, false, false));
            Customers_Phone = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_Phone", DomainObjectPropertyKeys.QOrders.Customers_Phone, this, false, false));
            Customers_PostalCode = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_PostalCode", DomainObjectPropertyKeys.QOrders.Customers_PostalCode, this, false, false));
            Customers_Region = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Customers_Region", DomainObjectPropertyKeys.QOrders.Customers_Region, this, false, false));
            EmployeeFullName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("EmployeeFullName", DomainObjectPropertyKeys.QOrders.EmployeeFullName, this, false, false));
            EmployeeID = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("EmployeeID", DomainObjectPropertyKeys.QOrders.EmployeeID, this, false, false));
            Employees_Address = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_Address", DomainObjectPropertyKeys.QOrders.Employees_Address, this, false, false));
            Employees_BirthDate = AddProperty(new DomainProperty<DateTime?, QOrders, QOrdersDomainObject>("Employees_BirthDate", DomainObjectPropertyKeys.QOrders.Employees_BirthDate, this, false, false));
            Employees_City = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_City", DomainObjectPropertyKeys.QOrders.Employees_City, this, false, false));
            Employees_Country = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_Country", DomainObjectPropertyKeys.QOrders.Employees_Country, this, false, false));
            Employees_Extension = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_Extension", DomainObjectPropertyKeys.QOrders.Employees_Extension, this, false, false));
            Employees_FirstName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_FirstName", DomainObjectPropertyKeys.QOrders.Employees_FirstName, this, false, false));
            Employees_HireDate = AddProperty(new DomainProperty<DateTime?, QOrders, QOrdersDomainObject>("Employees_HireDate", DomainObjectPropertyKeys.QOrders.Employees_HireDate, this, false, false));
            Employees_HomePhone = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_HomePhone", DomainObjectPropertyKeys.QOrders.Employees_HomePhone, this, false, false));
            Employees_Id = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("Employees_Id", DomainObjectPropertyKeys.QOrders.Employees_Id, this, false, false));
            Employees_LastName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_LastName", DomainObjectPropertyKeys.QOrders.Employees_LastName, this, false, false));
            Employees_Notes = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_Notes", DomainObjectPropertyKeys.QOrders.Employees_Notes, this, false, false));
            Employees_PhotoPath = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_PhotoPath", DomainObjectPropertyKeys.QOrders.Employees_PhotoPath, this, false, false));
            Employees_PostalCode = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_PostalCode", DomainObjectPropertyKeys.QOrders.Employees_PostalCode, this, false, false));
            Employees_Region = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_Region", DomainObjectPropertyKeys.QOrders.Employees_Region, this, false, false));
            Employees_ReportsTo = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("Employees_ReportsTo", DomainObjectPropertyKeys.QOrders.Employees_ReportsTo, this, false, false));
            Employees_Title = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_Title", DomainObjectPropertyKeys.QOrders.Employees_Title, this, false, false));
            Employees_TitleOfCourtesy = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Employees_TitleOfCourtesy", DomainObjectPropertyKeys.QOrders.Employees_TitleOfCourtesy, this, false, false));
            Freight = AddProperty(new DomainProperty<decimal?, QOrders, QOrdersDomainObject>("Freight", DomainObjectPropertyKeys.QOrders.Freight, this, false, false));
            Id = AddProperty(new DomainProperty<int, QOrders, QOrdersDomainObject>("Id", DomainObjectPropertyKeys.QOrders.Id, this, false, false));
            OrderDate = AddProperty(new DomainProperty<DateTime?, QOrders, QOrdersDomainObject>("OrderDate", DomainObjectPropertyKeys.QOrders.OrderDate, this, false, false));
            RequiredDate = AddProperty(new DomainProperty<DateTime?, QOrders, QOrdersDomainObject>("RequiredDate", DomainObjectPropertyKeys.QOrders.RequiredDate, this, false, false));
            ShipAddress = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("ShipAddress", DomainObjectPropertyKeys.QOrders.ShipAddress, this, false, false));
            ShipCity = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("ShipCity", DomainObjectPropertyKeys.QOrders.ShipCity, this, false, false));
            ShipCountry = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("ShipCountry", DomainObjectPropertyKeys.QOrders.ShipCountry, this, false, false));
            ShipName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("ShipName", DomainObjectPropertyKeys.QOrders.ShipName, this, false, false));
            ShippedDate = AddProperty(new DomainProperty<DateTime?, QOrders, QOrdersDomainObject>("ShippedDate", DomainObjectPropertyKeys.QOrders.ShippedDate, this, false, false));
            Shippers_CompanyName = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Shippers_CompanyName", DomainObjectPropertyKeys.QOrders.Shippers_CompanyName, this, false, false));
            Shippers_Id = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("Shippers_Id", DomainObjectPropertyKeys.QOrders.Shippers_Id, this, false, false));
            Shippers_Phone = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("Shippers_Phone", DomainObjectPropertyKeys.QOrders.Shippers_Phone, this, false, false));
            ShipPostalCode = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("ShipPostalCode", DomainObjectPropertyKeys.QOrders.ShipPostalCode, this, false, false));
            ShipRegion = AddProperty(new DomainProperty<string, QOrders, QOrdersDomainObject>("ShipRegion", DomainObjectPropertyKeys.QOrders.ShipRegion, this, false, false));
            ShipVia = AddProperty(new DomainProperty<int?, QOrders, QOrdersDomainObject>("ShipVia", DomainObjectPropertyKeys.QOrders.ShipVia, this, false, false));
        }

        
        public DomainProperty<int?, QOrders, QOrdersDomainObject> CustomerID { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_Address { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_City { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_CompanyName { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_ContactName { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_ContactTitle { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_Country { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_Fax { get; private set; }

        public DomainProperty<int?, QOrders, QOrdersDomainObject> Customers_Id { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_Phone { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_PostalCode { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Customers_Region { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> EmployeeFullName { get; private set; }

        public DomainProperty<int?, QOrders, QOrdersDomainObject> EmployeeID { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_Address { get; private set; }

        public DomainProperty<DateTime?, QOrders, QOrdersDomainObject> Employees_BirthDate { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_City { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_Country { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_Extension { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_FirstName { get; private set; }

        public DomainProperty<DateTime?, QOrders, QOrdersDomainObject> Employees_HireDate { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_HomePhone { get; private set; }

        public DomainProperty<int?, QOrders, QOrdersDomainObject> Employees_Id { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_LastName { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_Notes { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_PhotoPath { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_PostalCode { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_Region { get; private set; }

        public DomainProperty<int?, QOrders, QOrdersDomainObject> Employees_ReportsTo { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_Title { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Employees_TitleOfCourtesy { get; private set; }

        public DomainProperty<decimal?, QOrders, QOrdersDomainObject> Freight { get; private set; }

        public DomainProperty<int, QOrders, QOrdersDomainObject> Id { get; private set; }

        public DomainProperty<DateTime?, QOrders, QOrdersDomainObject> OrderDate { get; private set; }

        public DomainProperty<DateTime?, QOrders, QOrdersDomainObject> RequiredDate { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> ShipAddress { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> ShipCity { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> ShipCountry { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> ShipName { get; private set; }

        public DomainProperty<DateTime?, QOrders, QOrdersDomainObject> ShippedDate { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Shippers_CompanyName { get; private set; }

        public DomainProperty<int?, QOrders, QOrdersDomainObject> Shippers_Id { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> Shippers_Phone { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> ShipPostalCode { get; private set; }

        public DomainProperty<string, QOrders, QOrdersDomainObject> ShipRegion { get; private set; }

        public DomainProperty<int?, QOrders, QOrdersDomainObject> ShipVia { get; private set; }
    }
    #endregion
    #region QProducts

    public sealed class QProductsDomainObject : DomainObject<QProducts, QProductsDomainObject>
    {
        public QProductsDomainObject()
            : base("QProducts", DomainObjectKeys.QProducts, 25, false)
        {
            Categories_CategoryName = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Categories_CategoryName", DomainObjectPropertyKeys.QProducts.Categories_CategoryName, this, false, false));
            Categories_Description = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Categories_Description", DomainObjectPropertyKeys.QProducts.Categories_Description, this, false, false));
            Categories_Id = AddProperty(new DomainProperty<int?, QProducts, QProductsDomainObject>("Categories_Id", DomainObjectPropertyKeys.QProducts.Categories_Id, this, false, false));
            CategoryID = AddProperty(new DomainProperty<int?, QProducts, QProductsDomainObject>("CategoryID", DomainObjectPropertyKeys.QProducts.CategoryID, this, false, false));
            Discontinued = AddProperty(new DomainProperty<bool, QProducts, QProductsDomainObject>("Discontinued", DomainObjectPropertyKeys.QProducts.Discontinued, this, false, false));
            Id = AddProperty(new DomainProperty<int, QProducts, QProductsDomainObject>("Id", DomainObjectPropertyKeys.QProducts.Id, this, false, false));
            ProductName = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("ProductName", DomainObjectPropertyKeys.QProducts.ProductName, this, false, false));
            QuantityPerUnit = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("QuantityPerUnit", DomainObjectPropertyKeys.QProducts.QuantityPerUnit, this, false, false));
            ReorderLevel = AddProperty(new DomainProperty<short?, QProducts, QProductsDomainObject>("ReorderLevel", DomainObjectPropertyKeys.QProducts.ReorderLevel, this, false, false));
            SupplierID = AddProperty(new DomainProperty<int?, QProducts, QProductsDomainObject>("SupplierID", DomainObjectPropertyKeys.QProducts.SupplierID, this, false, false));
            Suppliers_Address = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_Address", DomainObjectPropertyKeys.QProducts.Suppliers_Address, this, false, false));
            Suppliers_City = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_City", DomainObjectPropertyKeys.QProducts.Suppliers_City, this, false, false));
            Suppliers_CompanyName = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_CompanyName", DomainObjectPropertyKeys.QProducts.Suppliers_CompanyName, this, false, false));
            Suppliers_ContactName = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_ContactName", DomainObjectPropertyKeys.QProducts.Suppliers_ContactName, this, false, false));
            Suppliers_ContactTitle = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_ContactTitle", DomainObjectPropertyKeys.QProducts.Suppliers_ContactTitle, this, false, false));
            Suppliers_Country = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_Country", DomainObjectPropertyKeys.QProducts.Suppliers_Country, this, false, false));
            Suppliers_Fax = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_Fax", DomainObjectPropertyKeys.QProducts.Suppliers_Fax, this, false, false));
            Suppliers_HomePage = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_HomePage", DomainObjectPropertyKeys.QProducts.Suppliers_HomePage, this, false, false));
            Suppliers_Id = AddProperty(new DomainProperty<int?, QProducts, QProductsDomainObject>("Suppliers_Id", DomainObjectPropertyKeys.QProducts.Suppliers_Id, this, false, false));
            Suppliers_Phone = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_Phone", DomainObjectPropertyKeys.QProducts.Suppliers_Phone, this, false, false));
            Suppliers_PostalCode = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_PostalCode", DomainObjectPropertyKeys.QProducts.Suppliers_PostalCode, this, false, false));
            Suppliers_Region = AddProperty(new DomainProperty<string, QProducts, QProductsDomainObject>("Suppliers_Region", DomainObjectPropertyKeys.QProducts.Suppliers_Region, this, false, false));
            UnitPrice = AddProperty(new DomainProperty<decimal?, QProducts, QProductsDomainObject>("UnitPrice", DomainObjectPropertyKeys.QProducts.UnitPrice, this, false, false));
            UnitsInStock = AddProperty(new DomainProperty<short?, QProducts, QProductsDomainObject>("UnitsInStock", DomainObjectPropertyKeys.QProducts.UnitsInStock, this, false, false));
            UnitsOnOrder = AddProperty(new DomainProperty<short?, QProducts, QProductsDomainObject>("UnitsOnOrder", DomainObjectPropertyKeys.QProducts.UnitsOnOrder, this, false, false));
        }

        
        public DomainProperty<string, QProducts, QProductsDomainObject> Categories_CategoryName { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Categories_Description { get; private set; }

        public DomainProperty<int?, QProducts, QProductsDomainObject> Categories_Id { get; private set; }

        public DomainProperty<int?, QProducts, QProductsDomainObject> CategoryID { get; private set; }

        public DomainProperty<bool, QProducts, QProductsDomainObject> Discontinued { get; private set; }

        public DomainProperty<int, QProducts, QProductsDomainObject> Id { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> ProductName { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> QuantityPerUnit { get; private set; }

        public DomainProperty<short?, QProducts, QProductsDomainObject> ReorderLevel { get; private set; }

        public DomainProperty<int?, QProducts, QProductsDomainObject> SupplierID { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_Address { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_City { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_CompanyName { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_ContactName { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_ContactTitle { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_Country { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_Fax { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_HomePage { get; private set; }

        public DomainProperty<int?, QProducts, QProductsDomainObject> Suppliers_Id { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_Phone { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_PostalCode { get; private set; }

        public DomainProperty<string, QProducts, QProductsDomainObject> Suppliers_Region { get; private set; }

        public DomainProperty<decimal?, QProducts, QProductsDomainObject> UnitPrice { get; private set; }

        public DomainProperty<short?, QProducts, QProductsDomainObject> UnitsInStock { get; private set; }

        public DomainProperty<short?, QProducts, QProductsDomainObject> UnitsOnOrder { get; private set; }
    }
    #endregion
    #region QShippers

    public sealed class QShippersDomainObject : DomainObject<QShippers, QShippersDomainObject>
    {
        public QShippersDomainObject()
            : base("QShippers", DomainObjectKeys.QShippers, 3, false)
        {
            CompanyName = AddProperty(new DomainProperty<string, QShippers, QShippersDomainObject>("CompanyName", DomainObjectPropertyKeys.QShippers.CompanyName, this, false, false));
            Id = AddProperty(new DomainProperty<int, QShippers, QShippersDomainObject>("Id", DomainObjectPropertyKeys.QShippers.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, QShippers, QShippersDomainObject>("Phone", DomainObjectPropertyKeys.QShippers.Phone, this, false, false));
        }

        
        public DomainProperty<string, QShippers, QShippersDomainObject> CompanyName { get; private set; }

        public DomainProperty<int, QShippers, QShippersDomainObject> Id { get; private set; }

        public DomainProperty<string, QShippers, QShippersDomainObject> Phone { get; private set; }
    }
    #endregion
    #region QSuppliers

    public sealed class QSuppliersDomainObject : DomainObject<QSuppliers, QSuppliersDomainObject>
    {
        public QSuppliersDomainObject()
            : base("QSuppliers", DomainObjectKeys.QSuppliers, 12, false)
        {
            Address = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("Address", DomainObjectPropertyKeys.QSuppliers.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("City", DomainObjectPropertyKeys.QSuppliers.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("CompanyName", DomainObjectPropertyKeys.QSuppliers.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("ContactName", DomainObjectPropertyKeys.QSuppliers.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("ContactTitle", DomainObjectPropertyKeys.QSuppliers.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("Country", DomainObjectPropertyKeys.QSuppliers.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("Fax", DomainObjectPropertyKeys.QSuppliers.Fax, this, false, false));
            HomePage = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("HomePage", DomainObjectPropertyKeys.QSuppliers.HomePage, this, false, false));
            Id = AddProperty(new DomainProperty<int, QSuppliers, QSuppliersDomainObject>("Id", DomainObjectPropertyKeys.QSuppliers.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("Phone", DomainObjectPropertyKeys.QSuppliers.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("PostalCode", DomainObjectPropertyKeys.QSuppliers.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, QSuppliers, QSuppliersDomainObject>("Region", DomainObjectPropertyKeys.QSuppliers.Region, this, false, false));
        }

        
        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> Address { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> City { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> ContactName { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> Country { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> Fax { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> HomePage { get; private set; }

        public DomainProperty<int, QSuppliers, QSuppliersDomainObject> Id { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> Phone { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, QSuppliers, QSuppliersDomainObject> Region { get; private set; }
    }
    #endregion
    #region Shipper

    public sealed class ShipperDomainObject : DomainObject<Shipper, ShipperDomainObject>
    {
        public ShipperDomainObject()
            : base("Shipper", DomainObjectKeys.Shipper, 3, false)
        {
            CompanyName = AddProperty(new DomainProperty<string, Shipper, ShipperDomainObject>("CompanyName", DomainObjectPropertyKeys.Shipper.CompanyName, this, false, false));
            Id = AddProperty(new DomainProperty<int, Shipper, ShipperDomainObject>("Id", DomainObjectPropertyKeys.Shipper.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, Shipper, ShipperDomainObject>("Phone", DomainObjectPropertyKeys.Shipper.Phone, this, false, false));
        }

        
        public DomainProperty<string, Shipper, ShipperDomainObject> CompanyName { get; private set; }

        public DomainProperty<int, Shipper, ShipperDomainObject> Id { get; private set; }

        public DomainProperty<string, Shipper, ShipperDomainObject> Phone { get; private set; }
    }
    #endregion
    #region Supplier

    public sealed class SupplierDomainObject : DomainObject<Supplier, SupplierDomainObject>
    {
        public SupplierDomainObject()
            : base("Supplier", DomainObjectKeys.Supplier, 12, false)
        {
            Address = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("Address", DomainObjectPropertyKeys.Supplier.Address, this, false, false));
            City = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("City", DomainObjectPropertyKeys.Supplier.City, this, false, false));
            CompanyName = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("CompanyName", DomainObjectPropertyKeys.Supplier.CompanyName, this, false, false));
            ContactName = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("ContactName", DomainObjectPropertyKeys.Supplier.ContactName, this, false, false));
            ContactTitle = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("ContactTitle", DomainObjectPropertyKeys.Supplier.ContactTitle, this, false, false));
            Country = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("Country", DomainObjectPropertyKeys.Supplier.Country, this, false, false));
            Fax = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("Fax", DomainObjectPropertyKeys.Supplier.Fax, this, false, false));
            HomePage = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("HomePage", DomainObjectPropertyKeys.Supplier.HomePage, this, false, false));
            Id = AddProperty(new DomainProperty<int, Supplier, SupplierDomainObject>("Id", DomainObjectPropertyKeys.Supplier.Id, this, false, false));
            Phone = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("Phone", DomainObjectPropertyKeys.Supplier.Phone, this, false, false));
            PostalCode = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("PostalCode", DomainObjectPropertyKeys.Supplier.PostalCode, this, false, false));
            Region = AddProperty(new DomainProperty<string, Supplier, SupplierDomainObject>("Region", DomainObjectPropertyKeys.Supplier.Region, this, false, false));
        }

        
        public DomainProperty<string, Supplier, SupplierDomainObject> Address { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> City { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> CompanyName { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> ContactName { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> ContactTitle { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> Country { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> Fax { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> HomePage { get; private set; }

        public DomainProperty<int, Supplier, SupplierDomainObject> Id { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> Phone { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> PostalCode { get; private set; }

        public DomainProperty<string, Supplier, SupplierDomainObject> Region { get; private set; }
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
    #region VSalesByCategory

    public sealed class VSalesByCategoryDomainObject : DomainObject<VSalesByCategory, VSalesByCategoryDomainObject>
    {
        public VSalesByCategoryDomainObject()
            : base("VSalesByCategory", DomainObjectKeys.VSalesByCategory, 4, false)
        {
            CategoryName = AddProperty(new DomainProperty<string, VSalesByCategory, VSalesByCategoryDomainObject>("CategoryName", DomainObjectPropertyKeys.VSalesByCategory.CategoryName, this, false, false));
            Id = AddProperty(new DomainProperty<int, VSalesByCategory, VSalesByCategoryDomainObject>("Id", DomainObjectPropertyKeys.VSalesByCategory.Id, this, false, false));
            ProductName = AddProperty(new DomainProperty<string, VSalesByCategory, VSalesByCategoryDomainObject>("ProductName", DomainObjectPropertyKeys.VSalesByCategory.ProductName, this, false, false));
            ProductSales = AddProperty(new DomainProperty<decimal?, VSalesByCategory, VSalesByCategoryDomainObject>("ProductSales", DomainObjectPropertyKeys.VSalesByCategory.ProductSales, this, false, false));
        }

        
        public DomainProperty<string, VSalesByCategory, VSalesByCategoryDomainObject> CategoryName { get; private set; }

        public DomainProperty<int, VSalesByCategory, VSalesByCategoryDomainObject> Id { get; private set; }

        public DomainProperty<string, VSalesByCategory, VSalesByCategoryDomainObject> ProductName { get; private set; }

        public DomainProperty<decimal?, VSalesByCategory, VSalesByCategoryDomainObject> ProductSales { get; private set; }
    }
    #endregion
}

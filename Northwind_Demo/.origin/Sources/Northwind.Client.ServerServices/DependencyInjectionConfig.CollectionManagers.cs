using System;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using FutureTechnologies.DI.Contracts;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.ServerServices.DomainModel;
using Northwind.Client.Services.Contracts.DomainModel;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Client.ServerServices
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureDomainCollectionManagers(IClientContainerRegistrator registrator)
        {
            registrator.PerSession<IObjectCollectionManager<OrderStatus, short>, IOrderStatusCollectionManager, OrderStatusCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Product, int>, IProductCollectionManager, ProductCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysResetPasswordToken, int>, ISysResetPasswordTokenCollectionManager, SysResetPasswordTokenCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysRole, int>, ISysRoleCollectionManager, SysRoleCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Customer, int>, ICustomerCollectionManager, CustomerCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Category, int>, ICategoryCollectionManager, CategoryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Supplier, int>, ISupplierCollectionManager, SupplierCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysOperationLock, SysOperationLockKey>, ISysOperationLockCollectionManager, SysOperationLockCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Order, int>, IOrderCollectionManager, OrderCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<OrderDetail, int>, IOrderDetailCollectionManager, OrderDetailCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysSetting, int>, ISysSettingCollectionManager, SysSettingCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Employee, int>, IEmployeeCollectionManager, EmployeeCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysSettingProperty, int>, ISysSettingPropertyCollectionManager, SysSettingPropertyCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<VSalesByCategory, int>, IVSalesByCategoryCollectionManager, VSalesByCategoryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Shipper, int>, IShipperCollectionManager, ShipperCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QSuppliers, int>, IQSuppliersCollectionManager, QSuppliersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QEmployees, int>, IQEmployeesCollectionManager, QEmployeesCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QShippers, int>, IQShippersCollectionManager, QShippersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QCategories, int>, IQCategoriesCollectionManager, QCategoriesCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QCustomers, int>, IQCustomersCollectionManager, QCustomersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QProducts, int>, IQProductsCollectionManager, QProductsCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QOrderProducts, int>, IQOrderProductsCollectionManager, QOrderProductsCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<QOrders, int>, IQOrdersCollectionManager, QOrdersCollectionManager>();
        }
    }
}
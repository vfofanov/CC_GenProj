using System;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using FutureTechnologies.DI.Contracts;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.ServerServices.DomainModel;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Contracts.DataObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Client.ServerServices
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureDomainCollectionManagers(IClientContainerRegistrator registrator)
        {
            registrator.PerSession<IObjectCollectionManager<Products, int>, IProductsCollectionManager, ProductsCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<CustomerCustomerDemo, CustomerCustomerDemoKey>, ICustomerCustomerDemoCollectionManager, CustomerCustomerDemoCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysResetPasswordToken, int>, ISysResetPasswordTokenCollectionManager, SysResetPasswordTokenCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysRole, int>, ISysRoleCollectionManager, SysRoleCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Territory, int>, ITerritoryCollectionManager, TerritoryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<EmployeeTerritory, EmployeeTerritoryKey>, IEmployeeTerritoryCollectionManager, EmployeeTerritoryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Customers, int>, ICustomersCollectionManager, CustomersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Categories, int>, ICategoriesCollectionManager, CategoriesCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Region, int>, IRegionCollectionManager, RegionCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Suppliers, int>, ISuppliersCollectionManager, SuppliersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysOperationLock, SysOperationLockKey>, ISysOperationLockCollectionManager, SysOperationLockCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Orders, int>, IOrdersCollectionManager, OrdersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<OrderDetails, OrderDetailsKey>, IOrderDetailsCollectionManager, OrderDetailsCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysSetting, int>, ISysSettingCollectionManager, SysSettingCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Employees, int>, IEmployeesCollectionManager, EmployeesCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<CustomerDemographic, int>, ICustomerDemographicCollectionManager, CustomerDemographicCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SysSettingProperty, int>, ISysSettingPropertyCollectionManager, SysSettingPropertyCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<Shippers, int>, IShippersCollectionManager, ShippersCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<SupplierQuery, int>, ISupplierQueryCollectionManager, SupplierQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<EmployeeQuery, int>, IEmployeeQueryCollectionManager, EmployeeQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<ShipperQuery, int>, IShipperQueryCollectionManager, ShipperQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<CategoryQuery, int>, ICategoryQueryCollectionManager, CategoryQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<ReportFormQuery, int>, IReportFormQueryCollectionManager, ReportFormQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<CustomerQuery, int>, ICustomerQueryCollectionManager, CustomerQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<ProductQuery, int>, IProductQueryCollectionManager, ProductQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<OrderProductQuery, OrderProductQueryKey>, IOrderProductQueryCollectionManager, OrderProductQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<OrdersQuery, int>, IOrdersQueryCollectionManager, OrdersQueryCollectionManager>();
            registrator.PerSession<IObjectCollectionManager<RegionQuery, int>, IRegionQueryCollectionManager, RegionQueryCollectionManager>();
        }
    }
}
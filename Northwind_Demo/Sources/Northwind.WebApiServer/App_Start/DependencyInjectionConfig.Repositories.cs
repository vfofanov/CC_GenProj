using System;
using BusinessFramework.WebAPI.Contracts.Data;
using FutureTechnologies.DI.Contracts;
using NorthWind.WebAPI.Contracts.Repositories;
using NorthWind.WebAPI.DataAccess;
using NorthWind.WebAPI.DataAccess.Repositories;


namespace NorthWind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureRepositories(IServerContainerRegistrator registrator)
        {
            registrator.PerRequest<IFileLinkRepository, FileLinkRepository>();
            
            registrator.PerRequest<ISysUserPermissionsDisplayViewRepository, SysUserPermissionsDisplayViewRepository>();
            registrator.PerRequest<ISysOperationRepository, SysOperationRepository>();
            registrator.PerRequest<ISysObjectRepository, SysObjectRepository>();
            registrator.PerRequest<ISysOperationResultRepository, SysOperationResultRepository>();
            registrator.PerRequest<IProductsRepository, ProductsRepository>();
            registrator.PerRequest<ICustomerCustomerDemoRepository, CustomerCustomerDemoRepository>();
            registrator.PerRequest<ISysResetPasswordTokenRepository, SysResetPasswordTokenRepository>();
            registrator.PerRequest<ISysRefreshTokenRepository, SysRefreshTokenRepository>();
            registrator.PerRequest<ISysRoleRepository, SysRoleRepository>();
            registrator.PerRequest<ITerritoryRepository, TerritoryRepository>();
            registrator.PerRequest<IEmployeeTerritoryRepository, EmployeeTerritoryRepository>();
            registrator.PerRequest<ISysUserRepository, SysUserRepository>();
            registrator.PerRequest<ISysRolePermissionRepository, SysRolePermissionRepository>();
            registrator.PerRequest<ICustomersRepository, CustomersRepository>();
            registrator.PerRequest<ICategoriesRepository, CategoriesRepository>();
            registrator.PerRequest<IRegionRepository, RegionRepository>();
            registrator.PerRequest<ISuppliersRepository, SuppliersRepository>();
            registrator.PerRequest<ISysOperationLockRepository, SysOperationLockRepository>();
            registrator.PerRequest<ISysUserRoleRepository, SysUserRoleRepository>();
            registrator.PerRequest<IOrdersRepository, OrdersRepository>();
            registrator.PerRequest<ISysPermissionRepository, SysPermissionRepository>();
            registrator.PerRequest<IOrderDetailsRepository, OrderDetailsRepository>();
            registrator.PerRequest<ISysSettingRepository, SysSettingRepository>();
            registrator.PerRequest<ISysInfoRepository, SysInfoRepository>();
            registrator.PerRequest<IEmployeesRepository, EmployeesRepository>();
            registrator.PerRequest<ISysObjectTypeRepository, SysObjectTypeRepository>();
            registrator.PerRequest<ISysObjectClassRepository, SysObjectClassRepository>();
            registrator.PerRequest<ICustomerDemographicRepository, CustomerDemographicRepository>();
            registrator.PerRequest<ISysPermissionTypeRepository, SysPermissionTypeRepository>();
            registrator.PerRequest<ISysSettingPropertyRepository, SysSettingPropertyRepository>();
            registrator.PerRequest<ISysUsersDisplayViewRepository, SysUsersDisplayViewRepository>();
            registrator.PerRequest<IShippersRepository, ShippersRepository>();
            registrator.PerRequest<ISupplierQueryRepository, SupplierQueryRepository>();
            registrator.PerRequest<IEmployeeQueryRepository, EmployeeQueryRepository>();
            registrator.PerRequest<IShipperQueryRepository, ShipperQueryRepository>();
            registrator.PerRequest<ICategoryQueryRepository, CategoryQueryRepository>();
            registrator.PerRequest<IReportFormQueryRepository, ReportFormQueryRepository>();
            registrator.PerRequest<ICustomerQueryRepository, CustomerQueryRepository>();
            registrator.PerRequest<IProductQueryRepository, ProductQueryRepository>();
            registrator.PerRequest<IOrderProductQueryRepository, OrderProductQueryRepository>();
            registrator.PerRequest<IOrdersQueryRepository, OrdersQueryRepository>();
            registrator.PerRequest<IRegionQueryRepository, RegionQueryRepository>();
        }
    }
}
using System;
using BusinessFramework.WebAPI.Contracts.Data;
using FutureTechnologies.DI.Contracts;
using Northwind.WebAPI.Contracts.Repositories;
using Northwind.WebAPI.DataAccess;
using Northwind.WebAPI.DataAccess.Repositories;


namespace Northwind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureRepositories(IServerContainerRegistrator registrator)
        {
            registrator.PerRequest<IFileLinkRepository, FileLinkRepository>();
            
            registrator.PerRequest<IOrderStatusRepository, OrderStatusRepository>();
            registrator.PerRequest<ISysUserPermissionsDisplayViewRepository, SysUserPermissionsDisplayViewRepository>();
            registrator.PerRequest<ISysOperationRepository, SysOperationRepository>();
            registrator.PerRequest<ISysObjectRepository, SysObjectRepository>();
            registrator.PerRequest<ISysOperationResultRepository, SysOperationResultRepository>();
            registrator.PerRequest<IProductRepository, ProductRepository>();
            registrator.PerRequest<ISysResetPasswordTokenRepository, SysResetPasswordTokenRepository>();
            registrator.PerRequest<ISysRefreshTokenRepository, SysRefreshTokenRepository>();
            registrator.PerRequest<ISysRoleRepository, SysRoleRepository>();
            registrator.PerRequest<ISysUserRepository, SysUserRepository>();
            registrator.PerRequest<ISysRolePermissionRepository, SysRolePermissionRepository>();
            registrator.PerRequest<ICustomerRepository, CustomerRepository>();
            registrator.PerRequest<ICategoryRepository, CategoryRepository>();
            registrator.PerRequest<ISupplierRepository, SupplierRepository>();
            registrator.PerRequest<ISysOperationLockRepository, SysOperationLockRepository>();
            registrator.PerRequest<ISysUserRoleRepository, SysUserRoleRepository>();
            registrator.PerRequest<IOrderRepository, OrderRepository>();
            registrator.PerRequest<ISysPermissionRepository, SysPermissionRepository>();
            registrator.PerRequest<IOrderDetailRepository, OrderDetailRepository>();
            registrator.PerRequest<ISysSettingRepository, SysSettingRepository>();
            registrator.PerRequest<ISysInfoRepository, SysInfoRepository>();
            registrator.PerRequest<IEmployeeRepository, EmployeeRepository>();
            registrator.PerRequest<ISysObjectTypeRepository, SysObjectTypeRepository>();
            registrator.PerRequest<ISysObjectClassRepository, SysObjectClassRepository>();
            registrator.PerRequest<ISysPermissionTypeRepository, SysPermissionTypeRepository>();
            registrator.PerRequest<ISysSettingPropertyRepository, SysSettingPropertyRepository>();
            registrator.PerRequest<ISysUsersDisplayViewRepository, SysUsersDisplayViewRepository>();
            registrator.PerRequest<IVSalesByCategoryRepository, VSalesByCategoryRepository>();
            registrator.PerRequest<IShipperRepository, ShipperRepository>();
            registrator.PerRequest<IQSuppliersRepository, QSuppliersRepository>();
            registrator.PerRequest<IQEmployeesRepository, QEmployeesRepository>();
            registrator.PerRequest<IQShippersRepository, QShippersRepository>();
            registrator.PerRequest<IQCategoriesRepository, QCategoriesRepository>();
            registrator.PerRequest<IQCustomersRepository, QCustomersRepository>();
            registrator.PerRequest<IQProductsRepository, QProductsRepository>();
            registrator.PerRequest<IQOrderProductsRepository, QOrderProductsRepository>();
            registrator.PerRequest<IQOrdersRepository, QOrdersRepository>();
        }
    }
}
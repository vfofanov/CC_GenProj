using System;
using System.Linq;
using BusinessFramework.WebAPI.Contracts.Data;
using Northwind.WebAPI.Contracts.DataObjects;



namespace Northwind.WebAPI.Contracts
{
    public interface IApiEntityManager : IEntityManager
    {
        IQueryable<OrderStatus> OrderStatuses { get; }
        IQueryable<SysUserPermissionsDisplayView> SysUserPermissionsDisplayViews { get; }
        IQueryable<SysOperation> SysOperations { get; }
        IQueryable<SysObject> SysObjects { get; }
        IQueryable<SysOperationResult> SysOperationResults { get; }
        IQueryable<Product> Products { get; }
        IQueryable<SysResetPasswordToken> SysResetPasswordTokens { get; }
        IQueryable<SysRefreshToken> SysRefreshTokens { get; }
        IQueryable<SysRole> SysRoles { get; }
        IQueryable<SysUser> SysUsers { get; }
        IQueryable<SysRolePermission> SysRolePermissions { get; }
        IQueryable<Customer> Customers { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Supplier> Suppliers { get; }
        IQueryable<SysOperationLock> SysOperationLocks { get; }
        IQueryable<SysUserRole> SysUserRoles { get; }
        IQueryable<Order> Orders { get; }
        IQueryable<SysPermission> SysPermissions { get; }
        IQueryable<OrderDetail> OrderDetails { get; }
        IQueryable<SysSetting> SysSettings { get; }
        IQueryable<SysInfo> SysInfos { get; }
        IQueryable<Employee> Employees { get; }
        IQueryable<SysObjectType> SysObjectTypes { get; }
        IQueryable<SysObjectClass> SysObjectClasses { get; }
        IQueryable<SysPermissionType> SysPermissionTypes { get; }
        IQueryable<SysSettingProperty> SysSettingProperties { get; }
        IQueryable<SysUsersDisplayView> SysUsersDisplayViews { get; }
        IQueryable<VSalesByCategory> VSalesByCategories { get; }
        IQueryable<Shipper> Shippers { get; }
    }
}
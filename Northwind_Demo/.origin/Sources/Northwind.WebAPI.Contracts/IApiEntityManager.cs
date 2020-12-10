using System;
using System.Linq;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;



namespace NorthWind.WebAPI.Contracts
{
    public interface IApiEntityManager : IEntityManager
    {
        IQueryable<SysUserPermissionsDisplayView> SysUserPermissionsDisplayViews { get; }
        IQueryable<SysOperation> SysOperations { get; }
        IQueryable<SysObject> SysObjects { get; }
        IQueryable<SysOperationResult> SysOperationResults { get; }
        IQueryable<Products> Products { get; }
        IQueryable<CustomerCustomerDemo> CustomerCustomerDemos { get; }
        IQueryable<SysResetPasswordToken> SysResetPasswordTokens { get; }
        IQueryable<SysRefreshToken> SysRefreshTokens { get; }
        IQueryable<SysRole> SysRoles { get; }
        IQueryable<Territory> Territories { get; }
        IQueryable<EmployeeTerritory> EmployeeTerritories { get; }
        IQueryable<SysUser> SysUsers { get; }
        IQueryable<SysRolePermission> SysRolePermissions { get; }
        IQueryable<Customers> Customers { get; }
        IQueryable<Categories> Categories { get; }
        IQueryable<Region> Regions { get; }
        IQueryable<Suppliers> Suppliers { get; }
        IQueryable<SysOperationLock> SysOperationLocks { get; }
        IQueryable<SysUserRole> SysUserRoles { get; }
        IQueryable<Orders> Orders { get; }
        IQueryable<SysPermission> SysPermissions { get; }
        IQueryable<OrderDetails> OrderDetails { get; }
        IQueryable<SysSetting> SysSettings { get; }
        IQueryable<SysInfo> SysInfos { get; }
        IQueryable<Employees> Employees { get; }
        IQueryable<SysObjectType> SysObjectTypes { get; }
        IQueryable<SysObjectClass> SysObjectClasses { get; }
        IQueryable<CustomerDemographic> CustomerDemographics { get; }
        IQueryable<SysPermissionType> SysPermissionTypes { get; }
        IQueryable<SysSettingProperty> SysSettingProperties { get; }
        IQueryable<SysUsersDisplayView> SysUsersDisplayViews { get; }
        IQueryable<Shippers> Shippers { get; }
    }
}
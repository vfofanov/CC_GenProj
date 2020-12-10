﻿using System.Linq;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.WebAPI.Contracts.DataObjects;



namespace NorthWind.WebAPI.DataAccess
{
    partial class ApiDbContext
    {

        /// <summary>
        /// Set of <see cref="FileLink"/> objects
        /// </summary>
        public IQueryable<FileLink> FileLinks
        {
            get { return GetSet<FileLink>(); }
        }
        /// <summary>
        /// Set of <see cref="SysUserPermissionsDisplayView"/> objects
        /// </summary>
        public IQueryable<SysUserPermissionsDisplayView> SysUserPermissionsDisplayViews
        {
            get { return GetSet<SysUserPermissionsDisplayView>(); }
        }
        /// <summary>
        /// Set of <see cref="SysOperation"/> objects
        /// </summary>
        public IQueryable<SysOperation> SysOperations
        {
            get { return GetSet<SysOperation>(); }
        }
        /// <summary>
        /// Set of <see cref="SysObject"/> objects
        /// </summary>
        public IQueryable<SysObject> SysObjects
        {
            get { return GetSet<SysObject>(); }
        }
        /// <summary>
        /// Set of <see cref="SysOperationResult"/> objects
        /// </summary>
        public IQueryable<SysOperationResult> SysOperationResults
        {
            get { return GetSet<SysOperationResult>(); }
        }
        /// <summary>
        /// Set of <see cref="Products"/> objects
        /// </summary>
        public IQueryable<Products> Products
        {
            get { return GetSet<Products>(); }
        }
        /// <summary>
        /// Set of <see cref="CustomerCustomerDemo"/> objects
        /// </summary>
        public IQueryable<CustomerCustomerDemo> CustomerCustomerDemos
        {
            get { return GetSet<CustomerCustomerDemo>(); }
        }
        /// <summary>
        /// Set of <see cref="SysResetPasswordToken"/> objects
        /// </summary>
        public IQueryable<SysResetPasswordToken> SysResetPasswordTokens
        {
            get { return GetSet<SysResetPasswordToken>(); }
        }
        /// <summary>
        /// Set of <see cref="SysRefreshToken"/> objects
        /// </summary>
        public IQueryable<SysRefreshToken> SysRefreshTokens
        {
            get { return GetSet<SysRefreshToken>(); }
        }
        /// <summary>
        /// Set of <see cref="SysRole"/> objects
        /// </summary>
        public IQueryable<SysRole> SysRoles
        {
            get { return GetSet<SysRole>(); }
        }
        /// <summary>
        /// Set of <see cref="Territory"/> objects
        /// </summary>
        public IQueryable<Territory> Territories
        {
            get { return GetSet<Territory>(); }
        }
        /// <summary>
        /// Set of <see cref="EmployeeTerritory"/> objects
        /// </summary>
        public IQueryable<EmployeeTerritory> EmployeeTerritories
        {
            get { return GetSet<EmployeeTerritory>(); }
        }
        /// <summary>
        /// Set of <see cref="SysUser"/> objects
        /// </summary>
        public IQueryable<SysUser> SysUsers
        {
            get { return GetSet<SysUser>(); }
        }
        /// <summary>
        /// Set of <see cref="SysRolePermission"/> objects
        /// </summary>
        public IQueryable<SysRolePermission> SysRolePermissions
        {
            get { return GetSet<SysRolePermission>(); }
        }
        /// <summary>
        /// Set of <see cref="Customers"/> objects
        /// </summary>
        public IQueryable<Customers> Customers
        {
            get { return GetSet<Customers>(); }
        }
        /// <summary>
        /// Set of <see cref="Categories"/> objects
        /// </summary>
        public IQueryable<Categories> Categories
        {
            get { return GetSet<Categories>(); }
        }
        /// <summary>
        /// Set of <see cref="Region"/> objects
        /// </summary>
        public IQueryable<Region> Regions
        {
            get { return GetSet<Region>(); }
        }
        /// <summary>
        /// Set of <see cref="Suppliers"/> objects
        /// </summary>
        public IQueryable<Suppliers> Suppliers
        {
            get { return GetSet<Suppliers>(); }
        }
        /// <summary>
        /// Set of <see cref="SysOperationLock"/> objects
        /// </summary>
        public IQueryable<SysOperationLock> SysOperationLocks
        {
            get { return GetSet<SysOperationLock>(); }
        }
        /// <summary>
        /// Set of <see cref="SysUserRole"/> objects
        /// </summary>
        public IQueryable<SysUserRole> SysUserRoles
        {
            get { return GetSet<SysUserRole>(); }
        }
        /// <summary>
        /// Set of <see cref="Orders"/> objects
        /// </summary>
        public IQueryable<Orders> Orders
        {
            get { return GetSet<Orders>(); }
        }
        /// <summary>
        /// Set of <see cref="SysPermission"/> objects
        /// </summary>
        public IQueryable<SysPermission> SysPermissions
        {
            get { return GetSet<SysPermission>(); }
        }
        /// <summary>
        /// Set of <see cref="OrderDetails"/> objects
        /// </summary>
        public IQueryable<OrderDetails> OrderDetails
        {
            get { return GetSet<OrderDetails>(); }
        }
        /// <summary>
        /// Set of <see cref="SysSetting"/> objects
        /// </summary>
        public IQueryable<SysSetting> SysSettings
        {
            get { return GetSet<SysSetting>(); }
        }
        /// <summary>
        /// Set of <see cref="SysInfo"/> objects
        /// </summary>
        public IQueryable<SysInfo> SysInfos
        {
            get { return GetSet<SysInfo>(); }
        }
        /// <summary>
        /// Set of <see cref="Employees"/> objects
        /// </summary>
        public IQueryable<Employees> Employees
        {
            get { return GetSet<Employees>(); }
        }
        /// <summary>
        /// Set of <see cref="SysObjectType"/> objects
        /// </summary>
        public IQueryable<SysObjectType> SysObjectTypes
        {
            get { return GetSet<SysObjectType>(); }
        }
        /// <summary>
        /// Set of <see cref="SysObjectClass"/> objects
        /// </summary>
        public IQueryable<SysObjectClass> SysObjectClasses
        {
            get { return GetSet<SysObjectClass>(); }
        }
        /// <summary>
        /// Set of <see cref="CustomerDemographic"/> objects
        /// </summary>
        public IQueryable<CustomerDemographic> CustomerDemographics
        {
            get { return GetSet<CustomerDemographic>(); }
        }
        /// <summary>
        /// Set of <see cref="SysPermissionType"/> objects
        /// </summary>
        public IQueryable<SysPermissionType> SysPermissionTypes
        {
            get { return GetSet<SysPermissionType>(); }
        }
        /// <summary>
        /// Set of <see cref="SysSettingProperty"/> objects
        /// </summary>
        public IQueryable<SysSettingProperty> SysSettingProperties
        {
            get { return GetSet<SysSettingProperty>(); }
        }
        /// <summary>
        /// Set of <see cref="SysUsersDisplayView"/> objects
        /// </summary>
        public IQueryable<SysUsersDisplayView> SysUsersDisplayViews
        {
            get { return GetSet<SysUsersDisplayView>(); }
        }
        /// <summary>
        /// Set of <see cref="Shippers"/> objects
        /// </summary>
        public IQueryable<Shippers> Shippers
        {
            get { return GetSet<Shippers>(); }
        }
    }
}
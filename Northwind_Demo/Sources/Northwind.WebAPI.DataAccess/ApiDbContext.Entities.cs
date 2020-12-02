﻿using System.Linq;
using BusinessFramework.WebAPI.Contracts.Files;
using Northwind.WebAPI.Contracts.DataObjects;



namespace Northwind.WebAPI.DataAccess
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
        /// Set of <see cref="OrderStatus"/> objects
        /// </summary>
        public IQueryable<OrderStatus> OrderStatuses
        {
            get { return GetSet<OrderStatus>(); }
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
        /// Set of <see cref="Product"/> objects
        /// </summary>
        public IQueryable<Product> Products
        {
            get { return GetSet<Product>(); }
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
        /// Set of <see cref="Customer"/> objects
        /// </summary>
        public IQueryable<Customer> Customers
        {
            get { return GetSet<Customer>(); }
        }
        /// <summary>
        /// Set of <see cref="Category"/> objects
        /// </summary>
        public IQueryable<Category> Categories
        {
            get { return GetSet<Category>(); }
        }
        /// <summary>
        /// Set of <see cref="Supplier"/> objects
        /// </summary>
        public IQueryable<Supplier> Suppliers
        {
            get { return GetSet<Supplier>(); }
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
        /// Set of <see cref="Order"/> objects
        /// </summary>
        public IQueryable<Order> Orders
        {
            get { return GetSet<Order>(); }
        }
        /// <summary>
        /// Set of <see cref="SysPermission"/> objects
        /// </summary>
        public IQueryable<SysPermission> SysPermissions
        {
            get { return GetSet<SysPermission>(); }
        }
        /// <summary>
        /// Set of <see cref="OrderDetail"/> objects
        /// </summary>
        public IQueryable<OrderDetail> OrderDetails
        {
            get { return GetSet<OrderDetail>(); }
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
        /// Set of <see cref="Employee"/> objects
        /// </summary>
        public IQueryable<Employee> Employees
        {
            get { return GetSet<Employee>(); }
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
        /// Set of <see cref="VSalesByCategory"/> objects
        /// </summary>
        public IQueryable<VSalesByCategory> VSalesByCategories
        {
            get { return GetSet<VSalesByCategory>(); }
        }
        /// <summary>
        /// Set of <see cref="Shipper"/> objects
        /// </summary>
        public IQueryable<Shipper> Shippers
        {
            get { return GetSet<Shipper>(); }
        }
    }
}
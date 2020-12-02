using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Northwind.WebAPI.DataAccess.Mapping
{
    internal static class ApiDbContextMapping
    {
        public static void OnModelCreating(DbModelBuilder modelBuilder)
        {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Configurations.Add(new FileLinkDatabaseMapping());

            modelBuilder.Configurations.Add(new OrderStatusDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUserPermissionsDisplayViewDatabaseMapping());
            modelBuilder.Configurations.Add(new SysOperationDatabaseMapping());
            modelBuilder.Configurations.Add(new SysObjectDatabaseMapping());
            modelBuilder.Configurations.Add(new SysOperationResultDatabaseMapping());
            modelBuilder.Configurations.Add(new ProductDatabaseMapping());
            modelBuilder.Configurations.Add(new SysResetPasswordTokenDatabaseMapping());
            modelBuilder.Configurations.Add(new SysRefreshTokenDatabaseMapping());
            modelBuilder.Configurations.Add(new SysRoleDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUserDatabaseMapping());
            modelBuilder.Configurations.Add(new SysRolePermissionDatabaseMapping());
            modelBuilder.Configurations.Add(new CustomerDatabaseMapping());
            modelBuilder.Configurations.Add(new CategoryDatabaseMapping());
            modelBuilder.Configurations.Add(new SupplierDatabaseMapping());
            modelBuilder.Configurations.Add(new SysOperationLockDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUserRoleDatabaseMapping());
            modelBuilder.Configurations.Add(new OrderDatabaseMapping());
            modelBuilder.Configurations.Add(new SysPermissionDatabaseMapping());
            modelBuilder.Configurations.Add(new OrderDetailDatabaseMapping());
            modelBuilder.Configurations.Add(new SysSettingDatabaseMapping());
            modelBuilder.Configurations.Add(new SysInfoDatabaseMapping());
            modelBuilder.Configurations.Add(new EmployeeDatabaseMapping());
            modelBuilder.Configurations.Add(new SysObjectTypeDatabaseMapping());
            modelBuilder.Configurations.Add(new SysObjectClassDatabaseMapping());
            modelBuilder.Configurations.Add(new SysPermissionTypeDatabaseMapping());
            modelBuilder.Configurations.Add(new SysSettingPropertyDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUsersDisplayViewDatabaseMapping());
            modelBuilder.Configurations.Add(new VSalesByCategoryDatabaseMapping());
            modelBuilder.Configurations.Add(new ShipperDatabaseMapping());
	
        }
    }
}
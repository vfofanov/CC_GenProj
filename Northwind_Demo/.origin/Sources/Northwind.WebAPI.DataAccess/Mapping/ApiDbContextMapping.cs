using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace NorthWind.WebAPI.DataAccess.Mapping
{
    internal static class ApiDbContextMapping
    {
        public static void OnModelCreating(DbModelBuilder modelBuilder)
        {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Configurations.Add(new FileLinkDatabaseMapping());

            modelBuilder.Configurations.Add(new SysUserPermissionsDisplayViewDatabaseMapping());
            modelBuilder.Configurations.Add(new SysOperationDatabaseMapping());
            modelBuilder.Configurations.Add(new SysObjectDatabaseMapping());
            modelBuilder.Configurations.Add(new SysOperationResultDatabaseMapping());
            modelBuilder.Configurations.Add(new ProductsDatabaseMapping());
            modelBuilder.Configurations.Add(new CustomerCustomerDemoDatabaseMapping());
            modelBuilder.Configurations.Add(new SysResetPasswordTokenDatabaseMapping());
            modelBuilder.Configurations.Add(new SysRefreshTokenDatabaseMapping());
            modelBuilder.Configurations.Add(new SysRoleDatabaseMapping());
            modelBuilder.Configurations.Add(new TerritoryDatabaseMapping());
            modelBuilder.Configurations.Add(new EmployeeTerritoryDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUserDatabaseMapping());
            modelBuilder.Configurations.Add(new SysRolePermissionDatabaseMapping());
            modelBuilder.Configurations.Add(new CustomersDatabaseMapping());
            modelBuilder.Configurations.Add(new CategoriesDatabaseMapping());
            modelBuilder.Configurations.Add(new RegionDatabaseMapping());
            modelBuilder.Configurations.Add(new SuppliersDatabaseMapping());
            modelBuilder.Configurations.Add(new SysOperationLockDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUserRoleDatabaseMapping());
            modelBuilder.Configurations.Add(new OrdersDatabaseMapping());
            modelBuilder.Configurations.Add(new SysPermissionDatabaseMapping());
            modelBuilder.Configurations.Add(new OrderDetailsDatabaseMapping());
            modelBuilder.Configurations.Add(new SysSettingDatabaseMapping());
            modelBuilder.Configurations.Add(new SysInfoDatabaseMapping());
            modelBuilder.Configurations.Add(new EmployeesDatabaseMapping());
            modelBuilder.Configurations.Add(new SysObjectTypeDatabaseMapping());
            modelBuilder.Configurations.Add(new SysObjectClassDatabaseMapping());
            modelBuilder.Configurations.Add(new CustomerDemographicDatabaseMapping());
            modelBuilder.Configurations.Add(new SysPermissionTypeDatabaseMapping());
            modelBuilder.Configurations.Add(new SysSettingPropertyDatabaseMapping());
            modelBuilder.Configurations.Add(new SysUsersDisplayViewDatabaseMapping());
            modelBuilder.Configurations.Add(new ShippersDatabaseMapping());
	
        }
    }
}
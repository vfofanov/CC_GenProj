namespace Northwind.Common
{
    /// <summary>
    ///     Domain objects' keys
    /// </summary>
    public abstract class DomainObjectKeys
    {
         public const int SysUserPermission = 1;
         public const int SysPermissionView = 5;
         public const int SysResetPasswordToken = 11;
         public const int SysRole = 15;
         public const int SysUser = 19;
         public const int SysRolePermission = 23;
         public const int SysOperationLock = 27;
         public const int SysUserRole = 31;
         public const int SysPermission = 35;
         public const int SysSetting = 39;
         public const int SysPermissionType = 46;
         public const int SysSettingProperty = 50;
    }

    /// <summary>
    ///     Domain objects' property keys
    /// </summary>
    public abstract class DomainObjectPropertyKeys
    {
        /// <summary>
        ///     Property keys for SysUserPermission
        /// </summary>
        public abstract class SysUserPermission
        {
             public const int UserId = 1;
             public const int PermissionId = 2;
             public const int AccountName = 3;
             public const int PermissionCodeName = 4;
        }
        /// <summary>
        ///     Property keys for SysPermissionView
        /// </summary>
        public abstract class SysPermissionView
        {
             public const int Id = 5;
             public const int Description = 6;
             public const int DisplayName = 7;
             public const int FieldName = 8;
             public const int Name = 9;
             public const int ObjectName = 10;
             public const int PermissionTypeDisplayName = 11;
             public const int Type = 12;
        }
        /// <summary>
        ///     Property keys for SysResetPasswordToken
        /// </summary>
        public abstract class SysResetPasswordToken
        {
             public const int Id = 33;
             public const int IsExecuted = 34;
             public const int Token = 36;
             public const int UserId = 37;
             public const int ValidFrom = 38;
        }
        /// <summary>
        ///     Property keys for SysRole
        /// </summary>
        public abstract class SysRole
        {
             public const int Id = 39;
             public const int Description = 40;
             public const int IsOwnByUser = 41;
             public const int Name = 42;
             public const int OwnerUserID = 43;
        }
        /// <summary>
        ///     Property keys for SysUser
        /// </summary>
        public abstract class SysUser
        {
             public const int Id = 45;
             public const int AccountName = 46;
             public const int Description = 47;
             public const int DisplayName = 48;
             public const int EMail = 49;
             public const int FullAccess = 51;
             public const int IsDeleted = 52;
             public const int IsEmailConfirmed = 53;
             public const int IsSystemUser = 54;
             public const int TerminationDate = 56;
        }
        /// <summary>
        ///     Property keys for SysRolePermission
        /// </summary>
        public abstract class SysRolePermission
        {
             public const int Id = 57;
             public const int PermissionId = 58;
             public const int RoleId = 59;
        }
        /// <summary>
        ///     Property keys for SysOperationLock
        /// </summary>
        public abstract class SysOperationLock
        {
             public const int OperationName = 62;
             public const int OperationContext = 63;
             public const int AquiredTime = 64;
             public const int ExpirationTime = 65;
             public const int MachineName = 66;
             public const int ProcessId = 67;
             public const int UserId = 69;
        }
        /// <summary>
        ///     Property keys for SysUserRole
        /// </summary>
        public abstract class SysUserRole
        {
             public const int Id = 70;
             public const int RoleId = 71;
             public const int UserId = 74;
        }
        /// <summary>
        ///     Property keys for SysPermission
        /// </summary>
        public abstract class SysPermission
        {
             public const int Id = 75;
             public const int CodeName = 76;
             public const int Description = 77;
             public const int DisplayName = 78;
             public const int FieldId = 79;
             public const int Guid = 80;
             public const int ObjectId = 81;
             public const int Type = 84;
        }
        /// <summary>
        ///     Property keys for SysSetting
        /// </summary>
        public abstract class SysSetting
        {
             public const int Id = 85;
             public const int SettingPropertyId = 86;
             public const int StringValue = 87;
             public const int UserId = 90;
        }
        /// <summary>
        ///     Property keys for SysPermissionType
        /// </summary>
        public abstract class SysPermissionType
        {
             public const int Id = 100;
             public const int CodeName = 101;
             public const int Description = 102;
             public const int DisplayName = 103;
        }
        /// <summary>
        ///     Property keys for SysSettingProperty
        /// </summary>
        public abstract class SysSettingProperty
        {
             public const int Id = 104;
             public const int DefaultType = 105;
             public const int Description = 106;
             public const int GroupName = 107;
             public const int IsManaged = 108;
             public const int IsOverridable = 109;
             public const int Name = 110;
             public const int UIEditorType = 111;
        }
    }
}
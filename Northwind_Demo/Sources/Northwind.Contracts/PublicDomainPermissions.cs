﻿using BusinessFramework;


namespace Northwind.Contracts
{
    /// <summary>
    /// Domain permissions
    /// </summary>
    public enum PublicDomainPermissions
    {
        /// <summary>
        /// System SettingManagement. Allows editing of global settings or other users settings
        /// </summary>
        SettingManagement = 1,

        /// <summary>
        /// System ReportManagement. Allows editing reports
        /// </summary>
        ReportManagement = 2,

        /// <summary>
        /// Global Operation lock management. Allows to set lock for operation
        /// </summary>
        OperationLock = 3,

        /// <summary>
        /// Global Settings. Allow read and edit user settings
        /// </summary>
        Settings = 4,

        
    }
}
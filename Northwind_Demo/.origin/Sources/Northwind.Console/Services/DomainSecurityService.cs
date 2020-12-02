using System;
using BusinessFramework;
using BusinessFramework.Client.Common.Services.Security;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Security;
using Northwind.Common;
using Northwind.Contracts;

namespace Northwind.Console.Services
{
    internal sealed class DomainSecurityService : SecurityService<PublicDomainPermissions>, IDomainSecurityService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public DomainSecurityService(IControllerClientFactory controllerClientFactory, IPasswordService passwordService)
            : base(controllerClientFactory, passwordService)
        {
        }

        protected override PublicDomainPermissions GetPublicDomainPermission(int systemPermissionId)
        {
            switch (systemPermissionId)
            {
                case Constants.Permissions.SettingManagement:
                    return PublicDomainPermissions.SettingManagement;
                case Constants.Permissions.ReportManagement:
                    return PublicDomainPermissions.ReportManagement;
                default:
                    throw new ArgumentOutOfRangeException(nameof(systemPermissionId));
            }
        }
    }
}
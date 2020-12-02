using System.Collections.Generic;
using Northwind.Contracts;
using Northwind.WebAPI.Contracts;


namespace Northwind.WebAPI
{
    partial class SecurityService
    {
        private PublicDomainPermissions[] GetPublicPermissions()
        {
            var permissions = new List<PublicDomainPermissions>(4);

            if (Authorize(DomainPermissions.SettingManagement))
            {
                permissions.Add(PublicDomainPermissions.SettingManagement);
            }
            if (Authorize(DomainPermissions.ReportManagement))
            {
                permissions.Add(PublicDomainPermissions.ReportManagement);
            }
            if (Authorize(DomainPermissions.OperationLock))
            {
                permissions.Add(PublicDomainPermissions.OperationLock);
            }
            if (Authorize(DomainPermissions.Settings))
            {
                permissions.Add(PublicDomainPermissions.Settings);
            }

            return permissions.ToArray();
        }
    }
}
using BusinessFramework.Client.Contracts.Services.Security;
using Northwind.Contracts;

namespace Northwind.Common
{
    /// <summary>
    /// Domain security service
    /// </summary>
    public interface IDomainSecurityService: ISecurityService<PublicDomainPermissions>
    {
    }
}
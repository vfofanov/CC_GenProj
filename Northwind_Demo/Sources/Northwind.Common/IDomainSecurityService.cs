using BusinessFramework.Client.Contracts.Services.Security;
using Northwind.Contracts;

namespace Northwind.Client.Services.Contracts
{
    /// <summary>
    /// Domain security service
    /// </summary>
    public interface IDomainSecurityService: ISecurityService<PublicDomainPermissions>
    {
    }
}
using BusinessFramework.Contracts.Security;
using BusinessFramework.WebAPI.Contracts.Security;
using NorthWind.Contracts;

namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    /// Security service interface
    /// </summary>
    public interface ISecurityService : ISecurityService<DomainPermissions>
    {
        /// <summary>
        /// Get public security service
        /// </summary>
        /// <returns></returns>
        PublicSecurityContext<PublicDomainPermissions> GetPublicContext();
    }
}
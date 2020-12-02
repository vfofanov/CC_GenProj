using Microsoft.Owin.Security.OAuth;
using Northwind.WebAPI.Contracts.Security;

namespace Northwind.WebApiServer.Security
{
    /// <inheritdoc />
    public class BearerAuthenticationOptionProvider : IBearerAuthenticationOptionProvider
    {
        private readonly OAuthBearerAuthenticationOptions _defaultOptions = new OAuthBearerAuthenticationOptions();

        /// <inheritdoc />
        public OAuthBearerAuthenticationOptions GetDefaultOptions()
        {
            return _defaultOptions;
        }
    }
}
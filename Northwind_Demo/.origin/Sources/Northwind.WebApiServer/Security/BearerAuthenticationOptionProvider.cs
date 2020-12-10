using Microsoft.Owin.Security.OAuth;
using NorthWind.WebAPI.Contracts.Security;

namespace NorthWind.WebApiServer.Security
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
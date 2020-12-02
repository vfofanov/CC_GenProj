using System;
using System.Configuration;
using System.Linq;
using Northwind.WebAPI.Contracts.Security;

namespace Northwind.WebApiServer.Security
{
    class TokenConfigurationService : ITokenConfigurationService
    {
        const String AccessTokenExpirationKey = "AccessTokenTTL";
        const Int32 AccessTokenDefaultExpiration = 24;

        const String RefreshTokenExpirationKey = "RefreshTokenTTL";
        const Int32 RefreshTokenDefaultExpiration = 720;

        public TimeSpan AccessTokenExpiration => GetTokenExpiration(AccessTokenExpirationKey, AccessTokenDefaultExpiration);
        public TimeSpan RefreshTokenExpiration => GetTokenExpiration(RefreshTokenExpirationKey, RefreshTokenDefaultExpiration);
 
        public String GetClientId(String clientId)
        {
            if (String.IsNullOrWhiteSpace(clientId))
            {
                clientId = "Incorrectly configured client";
            }

            return clientId;
        }

        static TimeSpan GetTokenExpiration(String key, Int32 defaultExpiration)
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains(key) ||
                !Int32.TryParse(ConfigurationManager.AppSettings[key], out Int32 tokenExpirationHours))
            {
                tokenExpirationHours = defaultExpiration;
            }

            TimeSpan tokenExpiration = TimeSpan.FromHours(tokenExpirationHours);

            return tokenExpiration;
        }
    }
}
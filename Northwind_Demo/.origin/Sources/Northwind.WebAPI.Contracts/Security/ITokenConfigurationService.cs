using System;

namespace NorthWind.WebAPI.Contracts.Security
{
    public interface ITokenConfigurationService
    {
        TimeSpan AccessTokenExpiration { get; }
        TimeSpan RefreshTokenExpiration { get; }
        String GetClientId(String clientId);
    }
}
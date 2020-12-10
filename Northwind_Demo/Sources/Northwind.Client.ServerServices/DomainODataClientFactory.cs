using System;
using BusinessFramework.Client.Contracts.Connection;

namespace NorthWind.Client.ServerServices
{
    public sealed class DomainODataClientFactory : IODataClientFactory
    {
        public IODataClient Create(Uri uri)
        {
            return new DomainODataClient(uri);
        }
    }
}
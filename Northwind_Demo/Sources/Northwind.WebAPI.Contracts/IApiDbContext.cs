using BusinessFramework.WebAPI.Contracts.Data;

namespace NorthWind.WebAPI.Contracts
{
    public interface IApiDbContext : IDbContext, IApiEntityManager
    {
    }
}
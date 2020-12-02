using BusinessFramework.WebAPI.Contracts.Data;

namespace Northwind.WebAPI.Contracts
{
    public interface IApiDbContext : IDbContext, IApiEntityManager
    {
    }
}
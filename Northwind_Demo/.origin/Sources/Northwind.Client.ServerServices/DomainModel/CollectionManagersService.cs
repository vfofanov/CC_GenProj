using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Contracts;
using FutureTechnologies.DI.Contracts;

namespace NorthWind.Client.ServerServices.DomainModel
{
    internal sealed class CollectionManagersService : ICollectionManagersService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public CollectionManagersService(IScope scope)
        {
            Scope = scope;
        }

        private IScope Scope { get; }

        public IObjectCollectionManager<TEntity, TKey> Get<TEntity, TKey>()
            where TEntity : IHasKey<TKey>
        {
            return Scope.Resolve<IObjectCollectionManager<TEntity, TKey>>();
        }
    }
}
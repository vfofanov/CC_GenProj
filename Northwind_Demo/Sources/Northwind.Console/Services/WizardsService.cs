using BusinessFramework.Client.Contracts.Wizards;
using FutureTechnologies.DI.Contracts;

namespace NorthWind.Console.Services
{
    internal sealed class WizardsService : IWizardsService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public WizardsService(IScope scope)
        {
            Scope = scope;
        }

        private IScope Scope { get; set; }

        public IEntityWizard<TEntity> CreateWizard<TEntity>(string name)
        {
            return Scope.Resolve<IEntityWizard<TEntity>>(name);
        }

        public IEntityWizard<TEntity, TParameters> CreateWizard<TEntity, TParameters>(string name)
        {
            return Scope.Resolve<IEntityWizard<TEntity, TParameters>>(name);
        }
    }
}
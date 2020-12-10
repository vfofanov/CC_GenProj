using BusinessFramework.Client.Contracts.Screens;
using FutureTechnologies.DI.Contracts;

namespace NorthWind.Console
{
    public sealed class ScreenViewModelFactory : IScreenViewModelFactory
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public ScreenViewModelFactory(IScope scope)
        {
            Scope = scope;
        }

        private IScope Scope { get; set; }

        public IScreenViewModel Create(string screenName)
        {
            return Scope.Resolve<IScreenViewModel>(screenName);
        }
    }
}
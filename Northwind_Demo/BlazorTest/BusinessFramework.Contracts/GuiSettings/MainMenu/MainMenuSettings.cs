using BusinessFramework.Contracts.GuiSettings.Actions;

namespace BusinessFramework.Contracts.GuiSettings.MainMenu
{
    public sealed class MainMenuSettings
    {
        public WorkActionItem[] Actions { get; set; }

        public MainMenuScreenGroupSettings[] Groups { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return $"Groups: {Groups.Length}";
        }
    }
}
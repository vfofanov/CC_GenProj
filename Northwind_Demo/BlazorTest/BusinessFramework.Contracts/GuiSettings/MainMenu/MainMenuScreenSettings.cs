using BusinessFramework.Contracts.GuiSettings.Screens;

namespace BusinessFramework.Contracts.GuiSettings.MainMenu
{
    /// <summary>
    ///     Screen menu settings
    /// </summary>
    public sealed class MainMenuScreenSettings : MainMenuBaseSettings
    {
        public string Image { get; set; }

        /// <summary>
        ///     Screen settings controller name
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Screen's parameters
        /// </summary>
        public ScreenParameter[] Parameters { get; set; }

        /// <summary>
        /// Screen is hidden and will be used only by specific action
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Name: {2}, Title:'{0}', Controller: {1}", Title, Controller, Name);
        }
    }
}
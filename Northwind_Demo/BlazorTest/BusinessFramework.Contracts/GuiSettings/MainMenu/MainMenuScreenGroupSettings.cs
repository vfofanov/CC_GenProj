namespace BusinessFramework.Contracts.GuiSettings.MainMenu
{
    /// <summary>
    ///     Main menu group settings
    /// </summary>
    public class MainMenuScreenGroupSettings : MainMenuBaseSettings
    {
        /// <summary>
        ///     RGB Color. 3 byte array
        /// </summary>
        public byte[] Color { get; set; }

        public string HexColor
        {
            get { return Color == null ? null : string.Format("#{0}{1}{2}", Color[0].ToString("x2"), Color[1].ToString("x2"), Color[2].ToString("x2")); }
        }

        public MainMenuScreenSettings[] Screens { get; set; }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Title:'{0}', Color: {1}, Screens: {2}", Title, HexColor, Screens.Length);
        }
    }
}
namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public sealed class Screen : ContentScreenItem
    {
        public string Title { get; set; }
        
        /// <summary>
        ///     Typ of screen item
        /// </summary>
        public override ScreenItemType Type
        {
            get { return ScreenItemType.Screen; }
        }

        /// <summary>
        /// Screen's parameters
        /// </summary>
        public ScreenParameter[] Parameters { get; set; }
    }
}
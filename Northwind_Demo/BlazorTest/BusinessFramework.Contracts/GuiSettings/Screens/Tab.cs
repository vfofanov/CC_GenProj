namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public sealed class Tab : ContentScreenItem
    {
        public string Title { get; set; }

        /// <summary>
        ///     Type of screen item
        /// </summary>
        public override ScreenItemType Type
        {
            get { return ScreenItemType.Tab; }
        }
    }
}
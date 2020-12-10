namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public abstract class LayoutScreenItem : ScreenItem
    {
        /// <summary>
        ///     Sub items
        /// </summary>
        public ScreenItem[] Children { get; set; }
    }
}
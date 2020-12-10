namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public sealed class TabLayout : LayoutScreenItem
    {
        /// <summary>
        ///     Active tab
        /// </summary>
        public byte ActiveTab { get; set; }

        /// <summary>
        ///     Typ of screen item
        /// </summary>
        public override ScreenItemType Type
        {
            get { return ScreenItemType.TabLayout; }
        }
    }
}
namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public sealed class GridLayout : LayoutScreenItem
    {
        public Dimension[] Columns { get; set; }
        public Dimension[] Rows { get; set; }

        /// <summary>
        ///     Typ of screen item
        /// </summary>
        public override ScreenItemType Type
        {
            get { return ScreenItemType.GridLayout; }
        }
    }
}
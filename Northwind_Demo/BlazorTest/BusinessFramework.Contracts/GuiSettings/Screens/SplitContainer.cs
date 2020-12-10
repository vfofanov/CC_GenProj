namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public sealed class SplitContainer : ScreenItem
    {
        public ScreenItem Panel1 { get; set; }
        public ScreenItem Panel2 { get; set; }

        public SplitContainerOrientation Orientation { get; set; }

        public SplitContainerPanel CollapsingPanel { get; set; }

        public SplitContainerPanel FixedPanel { get; set; }

        /// <summary>
        ///     Ratio size Panel1/(Panel1 + Panel2)
        /// </summary>
        public double PanelsRatio { get; set; }

        public bool IsCollapsed { get; set; }

        /// <summary>
        ///     Type of screen item
        /// </summary>
        public override ScreenItemType Type
        {
            get { return ScreenItemType.SplitContainer; }
        }
    }
}
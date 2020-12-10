namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public sealed class ChartDataBlockContent : DataBlockContent
    {
        public string Title { get; set; }

        public ChartDataBlockContentType ChartType { get; set; }

        public ChartDataBlockContentSeries Category { get; set; }

        public ChartDataBlockContentSeries[] Series { get; set; }

        public override DataBlockContentType Type
        {
            get { return DataBlockContentType.Chart; }
        }
    }
}
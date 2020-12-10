using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks.FieldViewers;

namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public sealed class DetailsDataBlockContentField : DataBlockContentField
    {
        public string Title { get; set; }

        public bool LabelOnTop { get; set; }

        public bool IsEndLine { get; set; }

        public int LineCount { get; set; }

        public FieldViewer Viewer { get; set; }
    }
}
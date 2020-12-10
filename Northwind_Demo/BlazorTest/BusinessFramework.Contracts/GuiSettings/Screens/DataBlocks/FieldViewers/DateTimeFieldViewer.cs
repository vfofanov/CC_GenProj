namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks.FieldViewers
{
    public sealed class DateTimeFieldViewer : FieldViewer
    {
        public override FieldViewerType Type
        {
            get { return FieldViewerType.DateTimeViewer; }
        }

        public string Format { get; set; }
    }
}
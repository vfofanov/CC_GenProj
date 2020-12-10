namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks.FieldViewers
{
    public sealed class NumberFieldViewer : FieldViewer
    {
        public string Format { get; set; }

        public override FieldViewerType Type
        {
            get { return FieldViewerType.NumberViewer; }
        }
    }
}
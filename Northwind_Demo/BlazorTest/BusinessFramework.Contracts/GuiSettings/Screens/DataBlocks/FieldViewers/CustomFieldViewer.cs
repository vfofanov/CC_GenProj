namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks.FieldViewers
{
    public sealed class CustomFieldViewer : FieldViewer
    {
        /// <summary>
        ///     Custom render unique key
        /// </summary>
        public string Key { get; set; }

        public CustomViewerOption[] Options { get; set; }

        public override FieldViewerType Type
        {
            get { return FieldViewerType.CustomViewer; }
        }
    }
}
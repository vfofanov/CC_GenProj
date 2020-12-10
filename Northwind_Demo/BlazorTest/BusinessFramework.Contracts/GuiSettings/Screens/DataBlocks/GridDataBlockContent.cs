namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public sealed class GridDataBlockContent : FieldsDataBlockContent<GridDataBlockContentField>
    {
        public override DataBlockContentType Type
        {
            get { return DataBlockContentType.Grid; }
        }
        public override bool HasQuickFilter { get; set; }

        public bool WrapDataInGridCell { get; set; }
    }
}
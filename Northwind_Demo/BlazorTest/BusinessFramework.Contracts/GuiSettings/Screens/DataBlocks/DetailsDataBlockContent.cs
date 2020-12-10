namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public sealed class DetailsDataBlockContent : FieldsDataBlockContent<DetailsDataBlockContentField>
    {
        public override DataBlockContentType Type
        {
            get { return DataBlockContentType.Details; }
        }

        /// <summary>
        /// Key for get custom view for this details block
        /// </summary>
        public string CustomKey { get; set; }
    }
}
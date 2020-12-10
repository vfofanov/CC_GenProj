namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public abstract class FieldsDataBlockContent<T> : DataBlockContent
        where T : IDataBlockContentField
    {
        public T[] Fields { get; set; }
    }
}
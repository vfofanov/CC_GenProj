namespace BusinessFramework.Contracts.GuiSettings.Fields
{
    public sealed class Field
    {
        public string Name { get; set; }

        /// <summary>
        /// Metadata property key
        /// </summary>
        public int Key { get; set; }

        public FieldDataType DataType { get; set; }
    }
}
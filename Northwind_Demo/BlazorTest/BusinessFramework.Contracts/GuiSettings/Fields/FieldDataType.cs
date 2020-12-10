namespace BusinessFramework.Contracts.GuiSettings.Fields
{
    public enum FieldDataType
    {
        Unknown = -1,
        None = 0,
        Bool = 1,
        String = 2,
        Integer = 3,
        Float = 4,
        Decimal = 5,
        DateTime = 6,
        DateTimeOffset = 7,
        Guid = 8,
        /// <summary>
        ///     Byte array
        /// </summary>
        Image = 10
    }
}
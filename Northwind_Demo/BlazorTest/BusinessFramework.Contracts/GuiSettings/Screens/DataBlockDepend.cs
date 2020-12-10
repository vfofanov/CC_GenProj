namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    /// <summary>
    /// Data block dependence
    /// </summary>
    public sealed class DataBlockDepend
    {
        /// <summary>
        /// Name of parent DataBlock
        /// </summary>
        public string Parent { get; set; }

        /// <summary>
        /// Parent field names
        /// </summary>
        public string[] ParentFields { get; set; }

        /// <summary>
        /// Parent field names
        /// </summary>
        public string[] Fields { get; set; }
    }
}
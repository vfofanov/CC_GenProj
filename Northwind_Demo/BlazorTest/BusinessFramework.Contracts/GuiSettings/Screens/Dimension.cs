namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public sealed class Dimension
    {
        public double? Value { get; set; }
        public DimensionUnit Unit { get; set; }
        public bool AutoSize
        {
            get { return !Value.HasValue; }
        }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            if (AutoSize)
            {
                return "AutoSize";
            }
            switch (Unit)
            {
                case DimensionUnit.Percent:
                    return string.Format("{0}%", Value);
                case DimensionUnit.Absolute:
                    return string.Format("{0}px", Value);
                default:
                    return "Unknown";
            }
        }
    }
}
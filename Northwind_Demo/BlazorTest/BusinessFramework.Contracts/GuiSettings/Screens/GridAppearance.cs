namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public class GridAppearance
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public GridAppearance()
        {
            ColumnSpan = 1;
            RowSpan = 1;
        }

        /// <summary>
        /// Start column in grid layout
        /// </summary>
        public int Column { get; set; }
        /// <summary>
        /// Start row in grid layout
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// Column span
        /// </summary>
        public int ColumnSpan { get; set; }
        /// <summary>
        /// Row span
        /// </summary>
        public int RowSpan { get; set; }

        /// <summary>
        /// Is panel with item collapsable
        /// </summary>
        public bool Collapsable { get; set; }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return string.Format("C{0}R{1}{2}{3}",
                Column,
                Row,
                ColumnSpan > 1 ? ", ColSpan:" + ColumnSpan : string.Empty,
                RowSpan > 1 ? ", RowSpan:" + RowSpan : string.Empty);
        }
    }
}
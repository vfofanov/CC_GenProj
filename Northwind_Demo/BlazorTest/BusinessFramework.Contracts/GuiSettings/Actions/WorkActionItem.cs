namespace BusinessFramework.Contracts.GuiSettings.Actions
{
    public abstract class WorkActionItem
    {
        /// <summary>
        ///     Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Name of image stored on client
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        ///     Name of class
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        ///     Action item position
        /// </summary>
        public WorkActionPosition Position { get; set; }

        /// <summary>
        ///     Alligement on toolbar
        /// </summary>
        public WorkActionToolbarAlligement ToolbarAlligement { get; set; }

        /// <summary>
        ///     Action item type
        /// </summary>
        public abstract WorkActionItemType Type { get; }
    }
}
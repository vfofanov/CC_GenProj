namespace BusinessFramework.Contracts.GuiSettings.Actions
{
    public sealed class WorkAction : WorkActionItem
    {
        /// <summary>
        ///     Action name. Binding to Screen service method
        /// </summary>
        public string ActionName { get; set; }

        public ShortcutKey? Shortcut { get; set; }
        /// <summary>
        ///     Action item type
        /// </summary>
        public override WorkActionItemType Type
        {
            get { return WorkActionItemType.Action; }
        }
    }
}
namespace BusinessFramework.Contracts.GuiSettings.Actions
{
    public sealed class WorkActionGroup : WorkActionItem
    {
        /// <summary>
        ///     Action item type
        /// </summary>
        public override WorkActionItemType Type
        {
            get { return WorkActionItemType.Group; }
        }

        public WorkActionItem[] Items { get; set; }
    }
}
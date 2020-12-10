namespace BusinessFramework.Contracts.GuiSettings.Actions
{
    public sealed class WorkActionSeparator : WorkActionItem
    {
        /// <summary>
        ///     Action item type
        /// </summary>
        public override WorkActionItemType Type
        {
            get { return WorkActionItemType.Separator; }
        }
    }
}
namespace BusinessFramework.Contracts.GuiSettings.Wizards
{
    public sealed class WizardPageGroup : WizardItem
    {
        public string Description { get; set; }
        public WizardItem[] Items { get; set; }
        public override WizardItemType Type
        {
            get { return WizardItemType.PageGroup; }
        }
    }
}
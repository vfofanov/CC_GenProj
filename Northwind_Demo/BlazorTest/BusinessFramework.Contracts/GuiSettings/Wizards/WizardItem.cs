namespace BusinessFramework.Contracts.GuiSettings.Wizards
{
    public abstract class WizardItem
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public abstract WizardItemType Type { get; }
    }
}
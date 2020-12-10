using BusinessFramework.Contracts.GuiSettings.Wizards.Editors;

namespace BusinessFramework.Contracts.GuiSettings.Wizards
{
    public sealed class WizardPage : WizardItem
    {
        public string BannerTitle { get; set; }

        public string BannerDescription { get; set; }

        public WizardPageEditor[] Editors { get; set; }

        public override WizardItemType Type
        {
            get { return WizardItemType.Page; }
        }
    }
}
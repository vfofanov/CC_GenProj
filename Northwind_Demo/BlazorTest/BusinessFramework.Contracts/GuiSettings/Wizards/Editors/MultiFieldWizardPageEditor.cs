using BusinessFramework.Contracts.GuiSettings.Fields;

namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public abstract class MultiFieldWizardPageEditor : WizardPageEditor
    {
        public Field[] Fields { get; set; }
    }
}
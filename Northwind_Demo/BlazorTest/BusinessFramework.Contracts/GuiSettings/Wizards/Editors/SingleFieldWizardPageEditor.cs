using BusinessFramework.Contracts.GuiSettings.Fields;

namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public abstract class SingleFieldWizardPageEditor : WizardPageEditor
    {
        public Field Field { get; set; }
    }
}
using BusinessFramework.Contracts.GuiSettings.Fields;

namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class SubEntityWizardPageEditor : WizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.SubEntity; }
        }

        public Field Field { get; set; }
    }
}
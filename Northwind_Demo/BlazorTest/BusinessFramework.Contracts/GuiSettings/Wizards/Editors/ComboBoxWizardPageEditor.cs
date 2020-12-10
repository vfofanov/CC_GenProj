using BusinessFramework.Contracts.GuiSettings.Fields;

namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public class ComboBoxWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.ComboBox; }
        }

        public string ValueField { get; set; }
        public string DisplayField { get; set; }
    }
}
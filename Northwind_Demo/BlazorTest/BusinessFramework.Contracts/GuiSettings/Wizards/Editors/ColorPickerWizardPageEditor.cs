namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    //NOTE: For future
    public sealed class ColorPickerWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.ColorPicker; }
        }
    }
}
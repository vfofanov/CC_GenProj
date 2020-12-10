namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public class PictureWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.Picture; }
        }
    }
}
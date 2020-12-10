namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class DateTimeWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.DateTime; }
        }

        public DateTimeWizardPageEditorType EditType { get; set; }
    }
}
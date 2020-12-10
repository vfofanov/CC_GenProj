namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class CustomMultiFieldWizardPageEditor : MultiFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.CustomMultiField; }
        }

        /// <summary>
        /// Custom editor render name
        /// </summary>
        public string Render { get; set; }

        public CustomWizardPageEditorOption[] Options { get; set; }
    }
}
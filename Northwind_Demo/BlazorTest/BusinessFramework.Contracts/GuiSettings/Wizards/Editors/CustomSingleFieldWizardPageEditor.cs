namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class CustomSingleFieldWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.CustomSingleField; }
        }

        /// <summary>
        ///     Custom editor render name
        /// </summary>
        public string Render { get; set; }

        public CustomWizardPageEditorOption[] Options { get; set; }
    }
}
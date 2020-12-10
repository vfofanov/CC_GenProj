namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class TextWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.Text; }
        }

        public int? MaxLength { get; set; }

        public bool IsMultiline { get; set; }

        /// <summary>
        ///     Input mask
        /// </summary>
        public string Mask { get; set; }

        public int LineCount { get; set; }
    }
}
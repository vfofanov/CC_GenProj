namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class AutocompleteWizardPageEditor : ComboBoxWizardPageEditor
    {
        public AutocompleteWizardPageEditor()
        {
            StartSearchAfterTypedSymbols = 3;
        }

        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.Autocomplete; }
        }

        /// <summary>
        ///     How many symbols must be typed for start search
        /// </summary>
        public int StartSearchAfterTypedSymbols { get; set; }
    }
}
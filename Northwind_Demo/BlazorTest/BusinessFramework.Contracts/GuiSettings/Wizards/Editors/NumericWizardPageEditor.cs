namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public sealed class NumericWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.Numeric; }
        }

        public double Step { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        public string Currency { get; set; }
    }
}
namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public class CheckWizardPageEditor : SingleFieldWizardPageEditor
    {
        public override WizardPageEditorType Type
        {
            get { return WizardPageEditorType.Check; }
        }
        /// <summary>
        /// Is check editor has three state or not. Use null as undefined value
        /// </summary>
        public bool IsThreeState { get; set; }
    }
}
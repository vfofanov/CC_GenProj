namespace BusinessFramework.Contracts.GuiSettings.Wizards
{
    public sealed class Wizard
    {
        public WizardItem[] Items { get; set; }

        /// <summary>
        ///     Submit validators
        /// </summary>
        public Validator[] Validators { get; set; }
    }
}
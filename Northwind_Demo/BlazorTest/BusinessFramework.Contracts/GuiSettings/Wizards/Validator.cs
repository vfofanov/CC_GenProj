namespace BusinessFramework.Contracts.GuiSettings.Wizards
{
    public sealed class Validator
    {
        public string Message { get; set; }

        public ValidatorType Type { get; set; }

        /// <summary>
        ///     Code behind method for validation
        /// </summary>
        public string Handler { get; set; }
    }
}
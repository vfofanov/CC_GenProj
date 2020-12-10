namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public enum WizardPageEditorType
    {
        None = 0,
        Text = 1,
        ComboBox = 2,
        Autocomplete = 3,
        DateTime = 4,
        Numeric = 5,
        ColorPicker = 6,
        Check = 7,
        Picture = 8,

        SubEntity = 99,
        CustomSingleField = 100,
        CustomMultiField = 101
    }
}
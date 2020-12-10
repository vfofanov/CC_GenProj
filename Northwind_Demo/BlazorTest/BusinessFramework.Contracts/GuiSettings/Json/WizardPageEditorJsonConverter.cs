using System;
using BusinessFramework.Contracts.GuiSettings.Wizards.Editors;
using Newtonsoft.Json.Linq;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    public sealed class WizardPageEditorJsonConverter : JsonCreationConverter<WizardPageEditor>
    {
        /// <summary>
        ///     Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">
        ///     contents of JSON object that will be deserialized
        /// </param>
        /// <returns></returns>
        protected override WizardPageEditor Create(Type objectType, JObject jObject)
        {
            var typeVal = (JValue) (jObject["type"] ?? jObject["Type"]);
            if (typeVal == null)
            {
                throw new Exception("Unknown Wizard item type");
            }
            var type = (WizardPageEditorType) Enum.ToObject(typeof (WizardPageEditorType), typeVal.Value);

            switch (type)
            {
                case WizardPageEditorType.Check:
                    return new CheckWizardPageEditor();
                case WizardPageEditorType.Text:
                    return new TextWizardPageEditor();
                case WizardPageEditorType.ComboBox:
                    return new ComboBoxWizardPageEditor();
                case WizardPageEditorType.Autocomplete:
                    return new AutocompleteWizardPageEditor();
                case WizardPageEditorType.DateTime:
                    return new DateTimeWizardPageEditor();
                case WizardPageEditorType.Numeric:
                    return new NumericWizardPageEditor();
                case WizardPageEditorType.ColorPicker:
                    return new ColorPickerWizardPageEditor();
                case WizardPageEditorType.CustomSingleField:
                    return new CustomSingleFieldWizardPageEditor();
                case WizardPageEditorType.CustomMultiField:
                    return new CustomMultiFieldWizardPageEditor();
                case WizardPageEditorType.SubEntity:
                    return new SubEntityWizardPageEditor();
                case WizardPageEditorType.Picture:
                    return new PictureWizardPageEditor();
                case WizardPageEditorType.None:
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown Wizard item type {0}", typeVal.Value));
            }
        }
    }

    
}
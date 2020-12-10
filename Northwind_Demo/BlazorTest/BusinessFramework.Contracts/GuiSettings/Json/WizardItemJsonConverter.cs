using System;
using BusinessFramework.Contracts.GuiSettings.Wizards;
using Newtonsoft.Json.Linq;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    public sealed class WizardItemJsonConverter : JsonCreationConverter<WizardItem>
    {
        /// <summary>
        ///     Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">
        ///     contents of JSON object that will be deserialized
        /// </param>
        /// <returns></returns>
        protected override WizardItem Create(Type objectType, JObject jObject)
        {
            var typeVal = (JValue) (jObject["type"] ?? jObject["Type"]);
            if (typeVal == null)
            {
                throw new Exception("Unknown Wizard item type");
            }
            var type = (WizardItemType) Enum.ToObject(typeof (WizardItemType), typeVal.Value);

            switch (type)
            {
                case WizardItemType.PageGroup:
                    return new WizardPageGroup();
                case WizardItemType.Page:
                    return new WizardPage();
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown Wizard item type {0}", typeVal.Value));
            }
        }
    }
}
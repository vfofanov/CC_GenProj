using System;
using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks.FieldViewers;
using Newtonsoft.Json.Linq;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    public sealed class FieldViewerJsonConverter : JsonCreationConverter<FieldViewer>
    {
        /// <summary>
        ///     Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">
        ///     contents of JSON object that will be deserialized
        /// </param>
        /// <returns></returns>
        protected override FieldViewer Create(Type objectType, JObject jObject)
        {
            var typeVal = (JValue) (jObject["type"] ?? jObject["Type"]);
            if (typeVal == null)
            {
                throw new Exception("Unknown screen item type");
            }
            var type = (FieldViewerType) Enum.ToObject(typeof (FieldViewerType), typeVal.Value);

            switch (type)
            {
                case FieldViewerType.DateTimeViewer:
                    return new DateTimeFieldViewer();
                case FieldViewerType.NumberViewer:
                    return new NumberFieldViewer();
                case FieldViewerType.CustomViewer:
                    return new CustomFieldViewer();
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown screen item type {0}", typeVal.Value));
            }
        }
    }
}
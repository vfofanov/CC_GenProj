using System;
using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks;
using Newtonsoft.Json.Linq;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    internal sealed class DataBlockContentJsonConverter : JsonCreationConverter<DataBlockContent>
    {
        protected override DataBlockContent Create(Type objectType, JObject jObject)
        {
            var typeVal = (JValue) (jObject["type"] ?? jObject["Type"]);
            if (typeVal == null)
            {
                throw new Exception("Unknown data block content type");
            }
            var type = (DataBlockContentType) Enum.ToObject(typeof (DataBlockContentType), typeVal.Value);

            switch (type)
            {
                case DataBlockContentType.Grid:
                    return new GridDataBlockContent();
                case DataBlockContentType.Details:
                    return new DetailsDataBlockContent();
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown data block content type {0}", typeVal.Value));
            }
        }
    }
}
using System;
using BusinessFramework.Contracts.GuiSettings.Screens;
using Newtonsoft.Json.Linq;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    public sealed class ScreenItemJsonConverter : JsonCreationConverter<ScreenItem>
    {
        /// <summary>
        ///     Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">
        ///     contents of JSON object that will be deserialized
        /// </param>
        /// <returns></returns>
        protected override ScreenItem Create(Type objectType, JObject jObject)
        {
            var typeVal = (JValue) (jObject["type"] ?? jObject["Type"]);
            if (typeVal == null)
            {
                throw new Exception("Unknown screen item type");
            }
            var type = (ScreenItemType) Enum.ToObject(typeof (ScreenItemType), typeVal.Value);

            switch (type)
            {
                case ScreenItemType.Screen:
                    return new Screen();
                case ScreenItemType.GridLayout:
                    return new GridLayout();
                case ScreenItemType.TabLayout:
                    return new TabLayout();
                case ScreenItemType.Tab:
                    return new Tab();
                case ScreenItemType.DataBlock:
                    return new DataBlock();
                case ScreenItemType.SplitContainer:
                    return new SplitContainer();
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown screen item type {0}", typeVal.Value));
            }
        }
    }
}
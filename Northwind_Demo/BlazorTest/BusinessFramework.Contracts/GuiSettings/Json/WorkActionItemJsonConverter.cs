using System;
using BusinessFramework.Contracts.GuiSettings.Actions;
using Newtonsoft.Json.Linq;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    public sealed class WorkActionItemJsonConverter : JsonCreationConverter<WorkActionItem>
    {
        /// <summary>
        ///     Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">
        ///     contents of JSON object that will be deserialized
        /// </param>
        /// <returns></returns>
        protected override WorkActionItem Create(Type objectType, JObject jObject)
        {
            var typeVal = (JValue) (jObject["type"] ?? jObject["Type"]);
            if (typeVal == null)
            {
                throw new Exception("Unknown Wizard item type");
            }
            var type = (WorkActionItemType) Enum.ToObject(typeof (WorkActionItemType), typeVal.Value);

            switch (type)
            {
                case WorkActionItemType.Group:
                    return new WorkActionGroup();
                case WorkActionItemType.Action:
                    return new WorkAction();
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown Work action item type {0}", typeVal.Value));
            }
        }
    }
}
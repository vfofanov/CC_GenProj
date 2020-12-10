using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BusinessFramework.Contracts.GuiSettings.Json
{
    public static class GuiSettingsJsonSettings
    {
        public static readonly JsonSerializerSettings ReadMainMenuSettings = GetReadMainMenuSettings();

        public static readonly JsonSerializerSettings WriteSettings = GetWriteSettings();

        public static readonly JsonSerializerSettings ReadScreenSettings = GetReadScreenSettings();

        public static readonly JsonSerializerSettings ReadWizardSettings = GetReadWizardSettings();


        private static JsonSerializerSettings GetWriteSettings()
        {
            var settings = JsonSettings.CreateSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            return settings;
        }
        private static JsonSerializerSettings GetReadScreenSettings()
        {
            var settings = GetWriteSettings();
            settings.Converters = new JsonConverter[]
            {
                new ScreenItemJsonConverter(),
                new DataBlockContentJsonConverter(),
                new FieldViewerJsonConverter(),
                new WorkActionItemJsonConverter()
            };
            return settings;
        }
        private static JsonSerializerSettings GetReadWizardSettings()
        {
            var settings = GetWriteSettings();
            settings.Converters = new JsonConverter[]
            {
                new WizardItemJsonConverter(),
                new WizardPageEditorJsonConverter()
            };

            return settings;
        }
        private static JsonSerializerSettings GetReadMainMenuSettings()
        {
            var settings = GetWriteSettings();
            settings.Converters = new JsonConverter[]
            {
                new WorkActionItemJsonConverter()
            };
            return settings;
        }
    }
}
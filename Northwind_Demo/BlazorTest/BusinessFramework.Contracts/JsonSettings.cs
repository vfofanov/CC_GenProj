using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BusinessFramework.Contracts
{

    /// <summary>
    /// Gets default json settings used by system
    /// </summary>
    public static class JsonSettings
    {
        public static readonly JsonSerializerSettings Default = CreateSettings();
        public static JsonSerializerSettings CreateSettings()
        {
            var settings = new JsonSerializerSettings
                {
                    //Remove nulls from payload and save bytes
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

            //Remove unix epoch date handling, in favor of ISO
            settings.Converters.Add(new IsoDateTimeConverter {DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fff"});

            return settings;
        }
    }
}
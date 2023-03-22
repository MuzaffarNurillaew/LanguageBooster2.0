using Newtonsoft.Json;

namespace LanguageBooster20.Service.Helpers.Dtos
{
    public class DefinitionDto
    {
        [JsonProperty("definition")]
        public string Definition { get; set; }
        [JsonProperty("example")]
        public string Example { get; set; }
    }
}

using Newtonsoft.Json;

namespace LanguageBooster20.Service.Helpers.Dtos
{
    public class MeaningDto
    {
        [JsonProperty("partOfSpeech")]
        public string PartOfSpeech { get; set; }
        [JsonProperty("definitions")]
        public List<DefinitionDto> Definitions { get; set; }
    }
}

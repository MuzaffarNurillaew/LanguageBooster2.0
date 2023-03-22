using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LanguageBooster20.Service.Helpers.Dtos
{
    public class WordWebDTO
    {
        [JsonProperty("word")]
        public string Word { get; set; }
        [JsonProperty("meanings")]
        public List<MeaningDto> meaningDtos { get; set; }
    }
}

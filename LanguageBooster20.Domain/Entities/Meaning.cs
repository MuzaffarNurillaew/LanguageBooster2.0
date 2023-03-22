using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class Meaning : Auditable
    {
        public string PartOfSpeech { get; set; }
        public string Definition { get; set; }
        public string Example { get; set; }
        public long WordId { get; set; }
        public Word Word { get; set; }
        public long LanguageId { get; set; }
        public Language Language { get; set; }
    }
}

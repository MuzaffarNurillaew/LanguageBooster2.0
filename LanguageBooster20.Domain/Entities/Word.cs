using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class Word : Auditable
    {
        public long ChosenLanguageId { get; set; }
        public Language Language { get; set; }
        public string WrittenForm { get; set; }
        public ICollection<Meaning> Meanings { get; set; }
    }
}
using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class Language : Auditable
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}

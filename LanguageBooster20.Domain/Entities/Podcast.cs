using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class Podcast : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileLocation { get; set; }
        public long OwnerId { get; set; }
        public User Owner { get; set; }
        public long LanguageId { get; set; }
        public Language Language { get; set; }
    }
}

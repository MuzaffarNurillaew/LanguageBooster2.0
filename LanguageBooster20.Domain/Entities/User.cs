using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long NativeLanguageId { get; set; }
        public Language NativeLanguage { get; set; }

        public long NewLanguageId { get; set; }
        public Language NewLanguage { get; set; }
    }
}

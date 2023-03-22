using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class FavouriteWord : Auditable
    {
        public long WordId { get; set; }
        public Word Word { set; get; }
        public long UserId { get; set; } 
        public User User { get; set; } 
    }
}

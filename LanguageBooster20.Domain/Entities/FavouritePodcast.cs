using LanguageBooster20.Domain.Commons;

namespace LanguageBooster20.Domain.Entities
{
    public class FavouritePodcast : Auditable
    {
        public long PodcastId { get; set; }
        public Podcast Podcast { set; get; }
        public long UserId { set; get; }
        public User User { set; get; }
    }
}

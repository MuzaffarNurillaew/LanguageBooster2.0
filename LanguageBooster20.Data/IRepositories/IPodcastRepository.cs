using LanguageBooster20.Domain.Entities;

namespace LanguageBooster20.Data.IRepositories
{
    public interface IPodcastRepository
    {
        Task<Podcast> InsertAsync(Podcast entity);
        Task<Podcast> UpdateAsync(long id, Podcast entity);
        Task<bool> DeleteAsync(Predicate<Podcast> predicate);
        Podcast SelectAsync(Predicate<Podcast> predicate = null);
        List<Podcast> SelectAllAsync(Predicate<Podcast> predicate = null);
    }
}

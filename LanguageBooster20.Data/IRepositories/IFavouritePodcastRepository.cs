using LanguageBooster20.Domain.Entities;

namespace LanguageBooster20.Data.IRepositories
{
    public interface IFavouritePodcastRepository
    {
        Task<FavouritePodcast> InsertAsync(FavouritePodcast entity);
        Task<FavouritePodcast> UpdateAsync(long Id, FavouritePodcast entity);
        Task<bool> DeleteAsync(Predicate<FavouritePodcast> predicate);
        FavouritePodcast SelectAsync(Predicate<FavouritePodcast> predicate = null);
        List<FavouritePodcast> SelectAllAsync(Predicate<FavouritePodcast> predicate = null);
    }
}

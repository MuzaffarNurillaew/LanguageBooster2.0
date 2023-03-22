using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IFavouritePodcastService
    {
        Task<Response<FavouritePodcast>> AddFavouritePodcast(long userId, long podcastId);
        Task<Response<bool>> RemoveFavouritePodcast(long userId, long podcastId);
        Response<List<FavouritePodcast>> GetAllFavouritePodcasts(long userId);
        Response<FavouritePodcast> GetFavouritePodcast(long userId, long podcastId);
    }
}

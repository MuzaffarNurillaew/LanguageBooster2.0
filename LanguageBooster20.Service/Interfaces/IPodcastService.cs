using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IPodcastService
    {
        Task<Response<Podcast>> AddAsync(Podcast entity);
        Task<Response<bool>> DeleteAsync(Predicate<Podcast> predicate);
        Task<Response<Podcast>> UpdateAsync(long id, Podcast entity);
        Response<Podcast> GetAsync(Predicate<Podcast> predicate = null);
        Response<List<Podcast>> GetAllAsync(Predicate<Podcast> predicate = null);
        void Play(Podcast entity);
    }
}

using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IFavouriteWordService
    {
        Task<Response<FavouriteWord>> AddFavouriteVocab(long userId, long wordId);
        Task<Response<bool>> RemoveFavouriteVocab(long userId, long wordId);
        Response<List<FavouriteWord>> GetAllFavouriteWordsAsync(long userId);
        Response<FavouriteWord> GetFavouriteWordAsync(long userId, long wordId);

    }
}

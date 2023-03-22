using LanguageBooster20.Domain.Entities;

namespace LanguageBooster20.Data.IRepositories
{
    public interface IFavouriteWordRepository
    {
        Task<FavouriteWord> InsertAsync(FavouriteWord entity);
        Task<FavouriteWord> UpdateAsync(long id, FavouriteWord entity);
        Task<bool> DeleteAsync(Predicate<FavouriteWord> predicate);
        FavouriteWord SelectAsync(Predicate<FavouriteWord> predicate = null);
        List<FavouriteWord> SelectAllAsync(Predicate<FavouriteWord> predicate = null);
    }
}

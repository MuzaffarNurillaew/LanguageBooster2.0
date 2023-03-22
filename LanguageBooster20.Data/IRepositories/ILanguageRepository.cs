using LanguageBooster20.Domain.Entities;

namespace LanguageBooster20.Data.IRepositories
{
    public interface ILanguageRepository
    {
        Task<Language> InsertAsync(Language entity);
        Task<Language> UpdateAsync(long id, Language entity);
        Task<bool> DeleteAsync(Predicate<Language> predicate);
        Language SelectAsync(Predicate<Language> predicate = null);
        List<Language> SelectAllAsync(Predicate<Language> predicate = null);
    }
}

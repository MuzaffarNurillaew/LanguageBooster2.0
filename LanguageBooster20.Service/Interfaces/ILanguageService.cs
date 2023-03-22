using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface ILanguageService
    {
        Task<Response<Language>> AddAsync(Language language);
        Task<Response<bool>> DeleteAsync(Predicate<Language> predicate);
        Task<Response<Language>> UpdateAsync(long id, Language entity);
        Response<Language> GetAsync(Predicate<Language> predicate = null);
        Response<List<Language>> GetAllAsync(Predicate<Language> predicate = null);
    }
}

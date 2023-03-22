using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IWordService
    {
        Task<Response<Word>> AddAsync(Word entity);
        Task<Response<bool>> DeleteAsync(Predicate<Word> predicate);
        Task<Response<Word>> UpdateAsync(long id, Word entity);
        Response<Word> GetAsync(Predicate<Word> predicate = null);
        Response<List<Word>> GetAllAsync(Predicate<Word> predicate = null);
        Task PronunceAsync(Word word);
    }
}

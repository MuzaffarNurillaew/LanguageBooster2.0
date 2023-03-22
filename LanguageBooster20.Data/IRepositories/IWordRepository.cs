using LanguageBooster20.Domain.Entities;

namespace LanguageBooster20.Data.IRepositories
{
    public interface IWordRepository
    {
        Task<Word> InsertAsync(Word entity);
        Task<Word> UpdateAsync(long id, Word entity);
        Task<bool> DeleteAsync(Predicate<Word> predicate);
        Word SelectAsync(Predicate<Word> predicate = null);
        List<Word> SelectAllAsync(Predicate<Word> predicate = null);
    }
}

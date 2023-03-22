using LanguageBooster20.Domain.Entities;

namespace LanguageBooster20.Data.IRepositories
{
    public interface IMeaningRepository
    {
        Task<Meaning> InsertAsync(Meaning entity);
        Task<Meaning> UpdateAsync(long id, Meaning entity);
        Task<bool> DeleteAsync(Predicate<Meaning> predicate);
        Meaning SelectAsync(Predicate<Meaning> predicate = null);
        List<Meaning> SelectAllAsync(Predicate<Meaning> predicate = null);
    }
}

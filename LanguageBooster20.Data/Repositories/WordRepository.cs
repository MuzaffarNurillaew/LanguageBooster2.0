using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly LanguageDbContext context = new LanguageDbContext();
        public async Task<bool> DeleteAsync(Predicate<Word> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            var entityToDelete = this.context.Words.ToList().Where(x => predicate(x)).ToList();

            if (entityToDelete is null)
            {
                return false;
            }

            context.Words.RemoveRange(entityToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Word> InsertAsync(Word entity)
        {
            var insertedEntity = await context.Words.AddAsync(entity);
            await context.SaveChangesAsync();

            return insertedEntity.Entity;
        }

        public List<Word> SelectAllAsync(Predicate<Word> predicate = null)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }
            return this.context.Words.ToList().Where(x => predicate(x)).ToList();
        }

        public Word SelectAsync(Predicate<Word> predicate = null)
        {
            if (predicate is null)
            {
                predicate = x => true;
            }
            return context.Words.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<Word> UpdateAsync(long id, Word entity)
        {
            var updatedEntity = context.Words.Update(entity);
            await context.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}

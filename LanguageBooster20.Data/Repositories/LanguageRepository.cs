using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly LanguageDbContext context = new LanguageDbContext();
        public async Task<Language> InsertAsync(Language entity)
        {
            var insertedEntity = await context.Languages.AddAsync(entity);
            await context.SaveChangesAsync();

            return insertedEntity.Entity;
        }

        public async Task<bool> DeleteAsync(Predicate<Language> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            var entityToDelete = this.context.Languages.ToList().Where(x => predicate(x)).ToList();

            if (entityToDelete is null)
            {
                return false;
            }

            context.Languages.RemoveRange(entityToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public List<Language> SelectAllAsync(Predicate<Language> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }
            return this.context.Languages.ToList().Where(x => predicate(x)).ToList();
        }

        public Language SelectAsync(Predicate<Language> predicate)
        {
            if (predicate is null)
            {
                predicate = x => true;
            }
            return context.Languages.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<Language> UpdateAsync(long id, Language entity)
        {
            var updatedEntity = context.Languages.Update(entity);
            await context.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}

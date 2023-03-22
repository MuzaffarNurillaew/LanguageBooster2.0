using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.Repositories
{
    public class MeaningRepository : IMeaningRepository
    {
        private readonly LanguageDbContext context = new LanguageDbContext();
        public async Task<bool> DeleteAsync(Predicate<Meaning> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            var entityToDelete = this.context.Meanings.ToList().Where(x => predicate(x)).ToList();

            if (entityToDelete is null)
            {
                return false;
            }

            context.Meanings.RemoveRange(entityToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Meaning> InsertAsync(Meaning entity)
        {
            var insertedEntity = await context.Meanings.AddAsync(entity);
            await context.SaveChangesAsync();

            return insertedEntity.Entity;
        }

        public List<Meaning> SelectAllAsync(Predicate<Meaning> predicate = null)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }
            return this.context.Meanings.ToList().Where(x => predicate(x)).ToList();
        }

        public Meaning SelectAsync(Predicate<Meaning> predicate = null)
        {
            if (predicate is null)
            {
                predicate = x => true;
            }
            return context.Meanings.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<Meaning> UpdateAsync(long id, Meaning entity)
        {
            var updatedEntity = context.Meanings.Update(entity);
            await context.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}

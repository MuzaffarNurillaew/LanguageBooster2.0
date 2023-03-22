using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.Repositories
{
    public class PodcastRepository : IPodcastRepository
    {
        private readonly LanguageDbContext context = new LanguageDbContext();
        public async Task<bool> DeleteAsync(Predicate<Podcast> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            var entityToDelete = this.context.Podcasts.ToList().Where(x => predicate(x)).ToList();

            if (entityToDelete is null)
            {
                return false;
            }

            context.Podcasts.RemoveRange(entityToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Podcast> InsertAsync(Podcast entity)
        {
            var insertedEntity = await context.Podcasts.AddAsync(entity);
            await context.SaveChangesAsync();

            return insertedEntity.Entity;
        }

        public List<Podcast> SelectAllAsync(Predicate<Podcast> predicate = null)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }
            return this.context.Podcasts.ToList().Where(x => predicate(x)).ToList();
        }

        public Podcast SelectAsync(Predicate<Podcast> predicate = null)
        {
            if (predicate is null)
            {
                predicate = x => true;
            }
            return context.Podcasts.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<Podcast> UpdateAsync(long id, Podcast entity)
        {
            var updatedEntity = context.Podcasts.Update(entity);
            await context.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}

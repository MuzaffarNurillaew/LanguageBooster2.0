using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.Repositories
{
    public class FavouritePodcastRepository : IFavouritePodcastRepository
    {
        private readonly LanguageDbContext context = new LanguageDbContext();
        public async Task<FavouritePodcast> InsertAsync(FavouritePodcast entity)
        {
            var insertedEntity = await context.FavouritePodcasts.AddAsync(entity);
            await context.SaveChangesAsync();

            return insertedEntity.Entity;
        }

        public async Task<bool> DeleteAsync(Predicate<FavouritePodcast> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            var entityToDelete = this.context.FavouritePodcasts.ToList().Where(x => predicate(x)).ToList();

            if (entityToDelete is null)
            {
                return false;
            }

            context.FavouritePodcasts.RemoveRange(entityToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public List<FavouritePodcast> SelectAllAsync(Predicate<FavouritePodcast> predicate = null)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }
            return this.context.FavouritePodcasts.ToList().Where(x => predicate(x)).ToList();
        }

        public FavouritePodcast SelectAsync(Predicate<FavouritePodcast> predicate)
        {
            if (predicate is null)
            {
                predicate = x => true;
            }
            return context.FavouritePodcasts.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<FavouritePodcast> UpdateAsync(long Id, FavouritePodcast entity)
        {
            var updatedEntity = context.FavouritePodcasts.Update(entity);
            await context.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}

using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.Repositories
{
    public class FavouriteWordRepository : IFavouriteWordRepository
    {
        private readonly LanguageDbContext context = new LanguageDbContext();
        public async Task<bool> DeleteAsync(Predicate<FavouriteWord> predicate)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            var entityToDelete = this.context.FavouriteWords.ToList().Where(x => predicate(x)).ToList();

            if (entityToDelete is null)
            {
                return false;
            }

            context.FavouriteWords.RemoveRange(entityToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<FavouriteWord> InsertAsync(FavouriteWord entity)
        {
            var insertedEntity = await context.FavouriteWords.AddAsync(entity);
            await context.SaveChangesAsync();

            return insertedEntity.Entity;
        }

        public List<FavouriteWord> SelectAllAsync(Predicate<FavouriteWord> predicate = null)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }
            return this.context.FavouriteWords.ToList().Where(x => predicate(x)).ToList();
        }

        public FavouriteWord SelectAsync(Predicate<FavouriteWord> predicate = null)
        {
            if (predicate is null)
            {
                predicate = x => true;
            }
            return context.FavouriteWords.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<FavouriteWord> UpdateAsync(long id, FavouriteWord entity)
        {
            var updatedEntity = context.FavouriteWords.Update(entity);
            await context.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}

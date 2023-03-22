using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;

namespace LanguageBooster20.Service.Services
{
    public class FavouriteWordService : IFavouriteWordService
    {
        private readonly IFavouriteWordRepository favWordRepo = new FavouriteWordRepository();

        public async Task<Response<FavouriteWord>> AddFavouriteVocab(long userId, long wordId)
        {
            var entity = favWordRepo.SelectAsync(fw => fw.UserId == userId 
                && fw.WordId == wordId);

            if (entity is not null)
            {
                return new Response<FavouriteWord>();
            }

            var insertedEntity = await favWordRepo.InsertAsync(entity);

            return new Response<FavouriteWord>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = insertedEntity
            };
        }

        public Response<List<FavouriteWord>> GetAllFavouriteWordsAsync(long userId)
        {
            var entities = favWordRepo.SelectAllAsync(fw => fw.UserId == userId);

            if (entities is null || !entities.Any())
            {
                return new Response<List<FavouriteWord>>();
            }
            return new Response<List<FavouriteWord>>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entities
            };
        }

        public Response<FavouriteWord> GetFavouriteWordAsync(long userId, long wordId)
        {
            var entity = favWordRepo.SelectAsync(fw => fw.UserId == userId
                && fw.WordId == wordId);

            if (entity is null)
            {
                return new Response<FavouriteWord>();
            }


            return new Response<FavouriteWord>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entity
            };
        }

        public async Task<Response<bool>> RemoveFavouriteVocab(long userId, long wordId)
        {
            var entity = favWordRepo.SelectAsync(fw => fw.UserId == userId
                && fw.WordId == wordId);

            if (entity is null)
            {
                return new Response<bool>();
            }

            await favWordRepo.DeleteAsync(fw => fw.Id == entity.Id);
            return new Response<bool>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = true
            };
        }
    }
}

using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;

namespace LanguageBooster20.Service.Services
{
    public class FavouritePodcastService : IFavouritePodcastService
    {
        private readonly IFavouritePodcastRepository favPodRepo = new FavouritePodcastRepository();

        public async Task<Response<FavouritePodcast>> AddFavouritePodcast(long userId, long podcastId)
        {
            var entity = favPodRepo.SelectAsync(fw => fw.UserId == userId
                && fw.PodcastId == podcastId);

            if (entity is not null)
            {
                return new Response<FavouritePodcast>();
            }

            var insertedEntity = await favPodRepo.InsertAsync(entity);

            return new Response<FavouritePodcast>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = insertedEntity
            };
        }

        public Response<List<FavouritePodcast>> GetAllFavouritePodcasts(long userId)
        {
            var entities = favPodRepo.SelectAllAsync(fw => fw.UserId == userId);

            if (entities is null || !entities.Any())
            {
                return new Response<List<FavouritePodcast>>();
            }
            return new Response<List<FavouritePodcast>>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entities
            };
        }

        public Response<FavouritePodcast> GetFavouritePodcast(long userId, long podcastId)
        {
            var entity = favPodRepo.SelectAsync(fw => fw.UserId == userId
                && fw.PodcastId == podcastId);

            if (entity is null)
            {
                return new Response<FavouritePodcast>();
            }


            return new Response<FavouritePodcast>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entity
            };
        }

        public async Task<Response<bool>> RemoveFavouritePodcast(long userId, long podcastId)
        {
            var entity = favPodRepo.SelectAsync(fw => fw.UserId == userId
                && fw.PodcastId == podcastId);

            if (entity is null)
            {
                return new Response<bool>();
            }

            await favPodRepo.DeleteAsync(fw => fw.Id == entity.Id);
            return new Response<bool>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = true
            };
        }
    }
}

using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;

namespace LanguageBooster20.Service.Services
{
    public class MeaningService : IMeaningService
    {
        private readonly IMeaningRepository meaningRepo = new MeaningRepository();
        public async Task<Response<Meaning>> AddMeaningAsync(long wordId, Meaning meaning)
        {
            var entity = meaningRepo.SelectAsync(m => m.WordId == wordId
                && m.PartOfSpeech == meaning.PartOfSpeech
                && m.Definition == meaning.Definition);
        
            if (entity is not null)
            {
                return new Response<Meaning>()
                {
                    Message = "Already exists"
                };
            }

            var insertedEntity = await meaningRepo.InsertAsync(meaning);

            return new Response<Meaning>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = meaning
            };
        }

        public Response<List<Meaning>> GetAllMeaningsAsync(long wordId)
        {
            var entities = meaningRepo.SelectAllAsync(m => m.WordId == wordId);

            if (entities is not null && entities.Any())
            {
                return new Response<List<Meaning>>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = entities
                };
            }

            return new Response<List<Meaning>>();
        }

        public Response<Meaning> GetMeaningAsync(long meaningId)
        {
            var entity = meaningRepo.SelectAsync(m => m.Id == meaningId);

            if (entity is null)
            {
                return new Response<Meaning>();
            }

            return new Response<Meaning>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entity
            };
        }

        public async Task<Response<bool>> RemoveMeaningAsync(long meaningId)
        {
            var entity = meaningRepo.SelectAsync(m => m.Id == meaningId);

            if (entity is null)
            {
                return new Response<bool>();
            }
            
            await meaningRepo.DeleteAsync(m => m.Id == meaningId);
            return new Response<bool>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = true
            };
        }

        public async Task<Response<Meaning>> UpdateMeaningAsync(long meaningId, Meaning entity)
        {
            var entityToUpdate = meaningRepo.SelectAsync(m => m.Id == meaningId);

            if (entityToUpdate is null)
            {
                return new Response<Meaning>();
            }

            entityToUpdate.UpdatedAt = DateTime.UtcNow;
            entityToUpdate.Definition = entity.Definition;
            entityToUpdate.PartOfSpeech = entity.PartOfSpeech;
            entityToUpdate.Example = entity.Example;
            entityToUpdate.WordId = entity.WordId;

            var updatedEntity = await meaningRepo.UpdateAsync(meaningId, entityToUpdate);

            return new Response<Meaning>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = updatedEntity
            };
        }
    }
}

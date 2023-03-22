using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;

namespace LanguageBooster20.Service.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository langRepo = new LanguageRepository();
        public async Task<Response<Language>> AddAsync(Language language)
        {
            var entity = langRepo.SelectAsync(lang => lang.Name.ToLower() == language.Name.ToLower()
                || lang.Abbreviation.ToLower() == language.Abbreviation.ToLower());

            if (entity is null)
            {
                Language insertedEntity = await langRepo.InsertAsync(language);

                return new Response<Language>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = insertedEntity
                };
            }

            return new Response<Language>
            {
                Message = "Already exists"
            };
        }

        public async Task<Response<bool>> DeleteAsync(Predicate<Language> predicate)
        {
            var entity = langRepo.SelectAsync(x => predicate(x));

            if (entity is null)
            {
                return new Response<bool>();
            }

            await langRepo.DeleteAsync(x => predicate(x));
            return new Response<bool>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = true
            };
        }

        public Response<List<Language>> GetAllAsync(Predicate<Language> predicate = null)
        {
            var entities = langRepo.SelectAllAsync(x => predicate(x));

            if (entities is null)
            {
                return new Response<List<Language>>();
            }

            return new Response<List<Language>>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entities
            };
        }

        public Response<Language> GetAsync(Predicate<Language> predicate = null)
        {
            var entity = langRepo.SelectAsync(x => predicate(x));
            if (entity is null)
            {
                return new Response<Language>();
            }

            return new Response<Language>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entity
            };
        }

        public async Task<Response<Language>> UpdateAsync(long id, Language entity)
        {
            var model = langRepo.SelectAsync(x => x.Id == id);

            if (entity is null)
            {
                return new Response<Language>();
            }

            model.Name = entity.Name;
            model.Abbreviation = entity.Abbreviation;

            var updatedEntity = await langRepo.UpdateAsync(id, model);
            
            return new Response<Language>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entity
            };
        }
    }
}

using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;
using System.Diagnostics;

namespace LanguageBooster20.Service.Services
{
    public class WordService : IWordService
    {
        private readonly IWordRepository wordRepo = new WordRepository();
        public async Task<Response<Word>> AddAsync(Word entity)
        {
            var model = wordRepo.SelectAsync(w => w.WrittenForm.ToLower() == entity.WrittenForm.ToLower()
                && w.ChosenLanguageId == entity.ChosenLanguageId);

            if (model is not null)
            {
                return new Response<Word>
                {
                    Message = "Already exists. Add meaning instead!"
                };
            }

            var insertedEntity = await wordRepo.InsertAsync(entity);

            return new Response<Word>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = insertedEntity
            };
        }

        public async Task<Response<bool>> DeleteAsync(Predicate<Word> predicate)
        {
            var models = wordRepo.SelectAllAsync(u => predicate(u));

            if (models is not null || models.Any())
            {
                await wordRepo.DeleteAsync(u => predicate(u));
                return new Response<bool>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = true
                };
            }

            return new Response<bool>();
        }

        public Response<List<Word>> GetAllAsync(Predicate<Word> predicate = null)
        {
            var entities = wordRepo.SelectAllAsync(u => predicate(u));

            if (entities is not null || entities.Any())
            {
                return new Response<List<Word>>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = entities
                };
            }

            return new Response<List<Word>>();
        }

        public Response<Word> GetAsync(Predicate<Word> predicate = null)
        {
            var model = wordRepo.SelectAsync(u => predicate(u));

            if (model is null)
            {
                return new Response<Word>();
            }

            return new Response<Word>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = model
            };
        }

        public async Task PronunceAsync(Word word)
        {
            await File.WriteAllTextAsync("..\\..\\..\\..\\LanguageBooster20.Service\\Helpers\\pronunciation.vbs",
                $"Createobject(\"SAPI.SpVoice\").Speak\"{word.WrittenForm}\"");

            var p = new ProcessStartInfo("..\\..\\..\\..\\LanguageBooster20.Service\\Helpers\\pronunciation.vbs");
            p.UseShellExecute = false;
            p.CreateNoWindow = true;
            Process.Start(p);
        }

        public async Task<Response<Word>> UpdateAsync(long id, Word entity)
        {
            var entityToUpdate = wordRepo.SelectAsync(u => u.Id == id);

            if (entityToUpdate is null)
            {
                return new Response<Word>();
            }
            else if (wordRepo.SelectAsync(w => w.WrittenForm.ToLower() == entity.WrittenForm.ToLower()
                && w.ChosenLanguageId == entity.ChosenLanguageId) is not null)
            {
                return new Response<Word>
                {
                    Message = "The updated entity already exists."
                };
            }

            entityToUpdate.UpdatedAt = DateTime.UtcNow;
            entityToUpdate.ChosenLanguageId = entity.ChosenLanguageId;
            entityToUpdate.WrittenForm = entity.WrittenForm;

            var updatedEntity = await wordRepo.UpdateAsync(id, entityToUpdate);

            return new Response<Word>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = updatedEntity
            };
        }

    }
}

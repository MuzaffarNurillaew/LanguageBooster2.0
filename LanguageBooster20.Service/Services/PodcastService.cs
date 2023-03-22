using LanguageBooster20.Data.AppSettings;
using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;
using System.Diagnostics;

namespace LanguageBooster20.Service.Services
{
    public class PodcastService : IPodcastService
    {
        private readonly IPodcastRepository podcastRepo = new PodcastRepository();
        public async Task<Response<Podcast>> AddAsync(Podcast entity)
        {
            try
            {
                string filePath = entity.FileLocation;
                var fileName = filePath.Split("\\")[filePath.Split("\\").Length - 1];
                File.Open(filePath, FileMode.Open);
                await File.WriteAllTextAsync("..\\..\\..\\..\\LanguageBooster20.Service\\Helpers\\FileCopier.bat",
                    $"copy \"{filePath}\" \"{Constants.PODCASTS_PATH + fileName}\"");
                
                entity.FileLocation = Constants.PODCASTS_PATH + fileName;

                ProcessStartInfo p = new ProcessStartInfo("..\\..\\..\\..\\LanguageBooster20.Service\\Helpers\\FileCopier.bat");

                p.UseShellExecute = false;
                p.CreateNoWindow = true;

                Process.Start(p);

                var insertedEntity = await podcastRepo.InsertAsync(entity);
                return new Response<Podcast>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = insertedEntity
                };
            }
            catch
            {
                return new Response<Podcast>();
            }

        }

        public async Task<Response<bool>> DeleteAsync(Predicate<Podcast> predicate)
        {
            var entities = podcastRepo.SelectAllAsync(p => predicate(p));
            if (entities.Count == 0 || entities is null)
            {
                return new Response<bool>()
                {
                    Message = "No rows affected!"
                };
            }

            foreach ( var entity in entities )
            {
                await File.WriteAllTextAsync("..\\..\\..\\..\\LanguageBooster20.Service\\Helpers\\FileCopier.bat",
                    $"rm \"{entity.FileLocation}\"");
                
                ProcessStartInfo p = new ProcessStartInfo("..\\..\\..\\..\\LanguageBooster20.Service\\Helpers\\FileDeleter.bat");

                p.UseShellExecute = false;
                p.CreateNoWindow = true;

                Process.Start(p);

                await podcastRepo.DeleteAsync(p => p.Id == entity.Id);
            }
            return new Response<bool>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = true
            };
        }

        public Response<List<Podcast>> GetAllAsync(Predicate<Podcast> predicate = null)
        {
            var entities = podcastRepo.SelectAllAsync(x => predicate(x));
            if (entities.Count == 0 || entities is null)
                {
                    return new Response<List<Podcast>>()
                    {
                        Message = "No info yet!"
                    };
                }
            return new Response<List<Podcast>>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entities
            };
        }

        public Response<Podcast> GetAsync(Predicate<Podcast> predicate = null)
        {
            var entity = podcastRepo.SelectAsync(p => predicate(p));

            if (entity is null)
            {
                return new Response<Podcast>();
            }

            return new Response<Podcast>()
            {
                StatusCode = 200,
                Message = "Ok",
                Value = entity
            };
        }

        public void Play(Podcast entity)
        {
            string mediaPlayerPath = "C:\\Program Files (x86)\\Windows Media Player\\wmplayer.exe";
            string podcastPath = entity.FileLocation;

            var p = new ProcessStartInfo(mediaPlayerPath, podcastPath);

            Process.Start(p);
        }

        public async Task<Response<Podcast>> UpdateAsync(long id, Podcast entity)
        {
            var entityToUpdate = podcastRepo.SelectAsync(x => x.Id == id);

            if (entityToUpdate is null)
            {
                return new Response<Podcast>();
            }

            entityToUpdate.Name = entity.Name;
            entityToUpdate.Description = entity.Description;
            entityToUpdate.UpdatedAt = DateTime.UtcNow;
            entityToUpdate.LanguageId = entity.LanguageId;
            entityToUpdate.OwnerId = entity.OwnerId;

            var updatedEntity = await podcastRepo.UpdateAsync(id, entityToUpdate);
            return new Response<Podcast>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = updatedEntity
            };
        }
    }
}

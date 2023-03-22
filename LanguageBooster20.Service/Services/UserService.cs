using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Interfaces;

namespace LanguageBooster20.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepo = new UserRepository();

        public async Task<Response<User>> AddAsync(User entity)
        {
            var model = userRepo.SelectAsync(u => u.Username == entity.Username);

            if (model is not null)
            {
                return new Response<User>();
            }

            var insertedEntity = await userRepo.InsertAsync(entity);
            return new Response<User>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = insertedEntity
            };
        }

        public async Task<Response<bool>> DeleteAsync(Predicate<User> predicate)
        {
            var models = userRepo.SelectAllAsync(u => predicate(u));

            if (models is not null || models.Any())
            {
                await userRepo.DeleteAsync(u => predicate(u));
                return new Response<bool>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = true
                };
            }

            return new Response<bool>();

        }

        public Response<List<User>> GetAllAsync(Predicate<User> predicate = null)
        {
            var entities = userRepo.SelectAllAsync(u => predicate(u));

            if (entities is not null || entities.Any())
            {
                return new Response<List<User>>
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = entities
                };
            }

            return new Response<List<User>>();
        }

        public Response<User> GetAsync(Predicate<User> predicate = null)
        {
            var model = userRepo.SelectAsync(u => predicate(u));

            if (model is null)
            {
                return new Response<User>();
            }

            return new Response<User>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = model
            };
        }

        public async Task<Response<User>> UpdateAsync(long id, User entity)
        {
            var entityToUpdate = userRepo.SelectAsync(u => u.Id == id);

            if (entityToUpdate is null)
            {
                return new Response<User>();
            }
            else if (userRepo.SelectAsync(u => u.Username == entity.Username) is not null)
            {
                return new Response<User>
                {
                    Message = "Username has to be unique"
                };
            }

            entityToUpdate.UpdatedAt = DateTime.UtcNow;
            entityToUpdate.Username = entity.Username;
            entityToUpdate.Password = entity.Password;
            entityToUpdate.FirstName = entity.FirstName;
            entityToUpdate.LastName = entity.LastName;
            entityToUpdate.NativeLanguageId = entity.NativeLanguageId;
            entityToUpdate.NewLanguageId = entity.NewLanguageId;

            var updatedEntity = await userRepo.UpdateAsync(id, entityToUpdate);

            return new Response<User>
            {
                StatusCode = 200,
                Message = "Ok",
                Value = updatedEntity
            };
        }
    }
}

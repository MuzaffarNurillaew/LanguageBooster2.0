using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IUserService
    {
        Task<Response<User>> AddAsync(User entity);
        Task<Response<bool>> DeleteAsync(Predicate<User> predicate);
        Task<Response<User>> UpdateAsync(long id, User entity);
        Response<User> GetAsync(Predicate<User> predicate = null);
        Response<List<User>> GetAllAsync(Predicate<User> predicate = null);
    }
}

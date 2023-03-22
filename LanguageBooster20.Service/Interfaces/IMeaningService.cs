using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IMeaningService
    {
        Task<Response<Meaning>> AddMeaningAsync(long wordId, Meaning meaning);
        Task<Response<bool>> RemoveMeaningAsync(long meaningId);
        Response<List<Meaning>> GetAllMeaningsAsync(long wordId);
        Response<Meaning> GetMeaningAsync(long meaningId);
        Task<Response<Meaning>> UpdateMeaningAsync(long meaningId, Meaning entity);
    }
}

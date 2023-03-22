using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Helpers.Dtos;

namespace LanguageBooster20.Service.Interfaces
{
    public interface IWordWebService
    {
        Task<Response<WordWebDTO>> SearchEnglishWordOnlineAsync(string word);
        Task<Response<Word>> AddOnlineWordToWordlistAsync(string word);
        Task OpenEngLishSpanishDictionary(string word, int browserNumber);
        Task OpenEngLishArabicDictionary(string word, int browserNumber);
    }
}

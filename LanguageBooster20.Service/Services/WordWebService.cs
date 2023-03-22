using LanguageBooster20.Data.AppSettings;
using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Helpers;
using LanguageBooster20.Service.Helpers.Dtos;
using LanguageBooster20.Service.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;

namespace LanguageBooster20.Service.Services
{
    public class WordWebService : IWordWebService
    {
        private readonly IWordRepository wordRepo = new WordRepository();
        private readonly IMeaningRepository meaningRepo = new MeaningRepository();
        public async Task<Response<Word>> AddOnlineWordToWordlistAsync(string word)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage m = await client.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{word}");
            string jsonString = await m.Content.ReadAsStringAsync();

            try
            {
                var entity = JsonConvert.DeserializeObject<List<WordWebDTO>>(jsonString).FirstOrDefault();

                var wordToInsert = new Word()
                {
                    WrittenForm = entity.Word,
                    ChosenLanguageId = 2
                };

                var insertedEntity = await wordRepo.InsertAsync(wordToInsert);

                foreach (var item in entity.meaningDtos)
                {
                    foreach (var item2 in item.Definitions)
                    {
                        await meaningRepo.InsertAsync(new Meaning()
                        {
                            Definition = item2.Definition,
                            Example = item2?.Example,
                            PartOfSpeech = item.PartOfSpeech,
                            LanguageId = 2,
                            WordId = insertedEntity.Id
                        });
                    }
                }

                return new Response<Word>()
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = insertedEntity
                };
            }
            catch
            {
                return new Response<Word>();
            }
        }
        // 0 - edge, 1 - chrome
        public async Task OpenEngLishArabicDictionary(string word, int browserNumber)
        {
            string browser = browserNumber == 0 ? "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe" : 
                "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            
            HttpClient client = new HttpClient();
            HttpResponseMessage m = await client.GetAsync($"https://dictionary.cambridge.org/dictionary/english-arabic/{word}");
            string htmlString = await m.Content.ReadAsStringAsync();
            string filePath = $"{Constants.TRANSLATEPAGES_PATH}{word}.html";
            File.WriteAllText(filePath, htmlString);

            ProcessStartInfo p = new ProcessStartInfo(browser, Path.GetFullPath(filePath));

            p.UseShellExecute = false;
            p.CreateNoWindow = true;

            Process.Start(p);
        }
        public async Task OpenEngLishSpanishDictionary(string word, int browserNumber)
        {
            string browser = browserNumber == 0 ? "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe" :
                "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";

            HttpClient client = new HttpClient();
            HttpResponseMessage m = await client.GetAsync($"https://dictionary.cambridge.org/dictionary/english-arabic/{word}");
            string htmlString = await m.Content.ReadAsStringAsync();
            string filePath = $"{Constants.TRANSLATEPAGES_PATH}{word}.html";
            File.WriteAllText(filePath, htmlString);

            ProcessStartInfo p = new ProcessStartInfo(browser, Path.GetFullPath(filePath));

            p.UseShellExecute = false;
            p.CreateNoWindow = true;

            Process.Start(p);
        }

        public async Task<Response<WordWebDTO>> SearchEnglishWordOnlineAsync(string word)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage m = await client.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{word}");
            string jsonString = await m.Content.ReadAsStringAsync();

            try
            {
                var entity = JsonConvert.DeserializeObject<List<WordWebDTO>>(jsonString).FirstOrDefault();
                return new Response<WordWebDTO>()
                {
                    StatusCode = 200,
                    Message = "Ok",
                    Value = entity
                };
            }
            catch
            {
                return new Response<WordWebDTO>();
            }

        }
    }
}

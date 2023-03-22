using LanguageBooster20.Data.IRepositories;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using LanguageBooster20.Data.Repositories;
using LanguageBooster20.Domain.Entities;
using LanguageBooster20.Service.Interfaces;
using LanguageBooster20.Service.Services;
using Microsoft.EntityFrameworkCore;

//ILanguageRepository lr = new LanguageRepository();

//var inserted = await lr.InsertAsync(new Language()
//{
//    Name = "Uzbek",
//    Abbreviation = "uz"
//});
//var selected = await lr.DeleteAsync(x => x.Id > 4);


//IPodcastService ps = new PodcastService();
//IUserRepository ur = new UserRepository();
//await ur.InsertAsync(new User()
//{
//    FirstName = "Test",
//    NativeLanguageId = 1,
//    NewLanguageId = 2,
//    LastName = "dsf",
//    Password = "ewrqewr"
//});

//var response = await ps.AddAsync(new Podcast()
//{
//    LanguageId = 2,
//    Name = "Fitgirl2",
//    OwnerId = 2,
//    Description = "Best podcast",
//    FileLocation = "D:\\Musics\\fitgirl.mp3"
//});

//Console.WriteLine(response.Message);


//IFavouriteWordRepository favWordRepo = new FavouriteWordRepository();

//await favWordRepo.InsertAsync(new FavouriteWord()
//{
//    LanguageId = 1,

//})

//IWordWebService ww = new WordWebService();
//var res = await ww.AddOnlineWordToWordlistAsync("hello");

//Console.WriteLine(res.Message);

IWordService ws = new WordService();
await ws.UpdateAsync(1, new Word()
{
    WrittenForm = "AFRAID"
});
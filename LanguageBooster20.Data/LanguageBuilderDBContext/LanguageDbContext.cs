using LanguageBooster20.Data.AppSettings;
using LanguageBooster20.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageBooster20.Data.LanguageBuilderDBContext
{
    public class LanguageDbContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<FavouritePodcast> FavouritePodcasts { get; set; }
        public DbSet<FavouriteWord> FavouriteWords { get; set; }
        public DbSet<Meaning> Meanings { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Word> Words { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.MSS_CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region SEED DATA
            #region languages table
            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    Id = 1,
                    Name = "Uzbek",
                    Abbreviation = "UZ",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Language()
                {
                    Id = 2,
                    Name = "English",
                    Abbreviation = "EN",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Language()
                {
                    Id = 3,
                    Name = "German",
                    Abbreviation = "GR",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Language()
                {
                    Id = 4,
                    Name = "Arabic",
                    Abbreviation = "AR",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Language()
                {
                    Id = 5,
                    Name = "Spanish",
                    Abbreviation = "SP",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                }
            );
            #endregion

            #region Users table
            modelBuilder.Entity<User>().HasData
            (
                new User()
                {
                    Id = 1,
                    FirstName = "Muzaffar",
                    LastName = "Nurillayev",
                    Username = "muzaffar",
                    NativeLanguageId = 1,
                    NewLanguageId = 2,
                    Password = "0110",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Azimjon",
                    LastName = "Ochilov",
                    Username = "azimochilov",
                    NativeLanguageId = 2,
                    NewLanguageId = 2,
                    Password = "azim",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Kamron",
                    LastName = "Sayfullayev",
                    Username = "kamron",
                    NativeLanguageId = 2,
                    NewLanguageId = 1,
                    Password = "kamron",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Safarmurod",
                    LastName = "Ashurov",
                    Username = "safar",
                    NativeLanguageId = 1,
                    NewLanguageId = 2,
                    Password = "safarmurod",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new User()
                {
                    Id = 5,
                    FirstName = "Bekmurod",
                    LastName = "Boqiyev",
                    Username = "bekmurod",
                    NativeLanguageId = 2,
                    NewLanguageId = 4,
                    Password = "bekmurod",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                }
            );
            #endregion

            #region Words table
            modelBuilder.Entity<Word>().HasData
            (new List<Word>()
            {
                new Word()
                {
                    Id = 1,
                    ChosenLanguageId = 2,
                    WrittenForm = "afraid",
                    CreatedAt= DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 2,
                    ChosenLanguageId = 2,
                    WrittenForm = "agree",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 3,
                    ChosenLanguageId = 2,
                    WrittenForm = "angry",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 4,
                    ChosenLanguageId = 2,
                    WrittenForm = "arrive",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 5,
                    ChosenLanguageId = 2,
                    WrittenForm = "attack",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 6,
                    ChosenLanguageId = 2,
                    WrittenForm = "bottom",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 7,
                    ChosenLanguageId = 2,
                    WrittenForm = "clever",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 8,
                    ChosenLanguageId = 2,
                    WrittenForm = "cruel",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 9,
                    ChosenLanguageId = 2,
                    WrittenForm = "finally",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 10,
                    ChosenLanguageId = 2,
                    WrittenForm = "hide",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 11,
                    ChosenLanguageId = 2,
                    WrittenForm = "hunt",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 12,
                    ChosenLanguageId = 2,
                    WrittenForm = "lot",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 13,
                    ChosenLanguageId = 2,
                    WrittenForm = "Afraid",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 14,
                    ChosenLanguageId = 2,
                    WrittenForm = "middle",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 15,
                    ChosenLanguageId = 2,
                    WrittenForm = "moment",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 16,
                    ChosenLanguageId = 2,
                    WrittenForm = "pleased",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 17,
                    ChosenLanguageId = 2,
                    WrittenForm = "promise",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 18,
                    ChosenLanguageId = 2,
                    WrittenForm = "reply",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 19,
                    ChosenLanguageId = 2,
                    WrittenForm = "safe",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Word()
                {
                    Id = 20,
                    ChosenLanguageId = 2,
                    WrittenForm = "trick",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                }
            }
            );
            #endregion

            #region Meanings table
            modelBuilder.Entity<Meaning>().HasData
            (
                new List<Meaning>()
                {

                new Meaning()
                {
                    Id = 1,
                    WordId = 1,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "qo'rqqan",
                    Example = "He is afraid",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 2,
                    WordId = 2,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "rozi bo'lmoq",
                    Example = "He agrees",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 3,
                    WordId = 3,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "jahli chiqqan",
                    Example = "He is angry",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 4,
                    WordId = 4,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "yetib kelmoq",
                    Example = "He arrived.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 5,
                    WordId = 5,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "hujum qilmoq",
                    Example = "He attacked pet.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 6,
                    WordId = 6,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "bottom",
                    Example = "He is at the bottom",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 7,
                    WordId = 7,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "aqlli",
                    Example = "He is very clever.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 8,
                    WordId = 8,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "yovuz",
                    Example = "He is cruel person.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 9,
                    WordId = 9,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "va nihoyat",
                    Example = "Finally, I am finishing the project.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 10,
                    WordId = 10,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "yashirmoq",
                    Example = "He is hiding his money.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 11,
                    WordId = 11,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "ov qilmoq",
                    Example = "He is hunting.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 12,
                    WordId = 12,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "ko'p",
                    Example = "I have a lot of lines of code here!",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 13,
                    WordId = 13,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "o'rtasi",
                    Example = "He is in the middle.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 14,
                    WordId = 14,
                    LanguageId = 1,
                    PartOfSpeech = "noun",
                    Definition = "lahza",
                    Example = "He came a moment ago.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 15,
                    WordId = 15,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "xursand",
                    Example = "He is pleased",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 16,
                    WordId = 16,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "va'da bermoq",
                    Example = "He promised me!",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 17,
                    WordId = 17,
                    LanguageId = 1,
                    PartOfSpeech = "verb",
                    Definition = "javob bermoq",
                    Example = "He is not answering the phone.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 18,
                    WordId = 18,
                    LanguageId = 1,
                    PartOfSpeech = "adjective",
                    Definition = "xavfsiz",
                    Example = "He is safe in Na'jot Ta'lim.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 19,
                    WordId = 19,
                    LanguageId = 1,
                    PartOfSpeech = "noun",
                    Definition = "hiyla",
                    Example = "It was a trick",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Meaning()
                {
                    Id = 20,
                    WordId = 20,
                    LanguageId = 1,
                    PartOfSpeech = "noun",
                    Definition = "Hiyla",
                    Example = "It was a trick.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                }
            }
            );
            #endregion

            #endregion
        }
    }
}

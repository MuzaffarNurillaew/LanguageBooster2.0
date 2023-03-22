﻿// <auto-generated />
using System;
using LanguageBooster20.Data.LanguageBuilderDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    [DbContext(typeof(LanguageDbContext))]
    [Migration("20230322070355_changeInMeaningMorePropsAdded")]
    partial class changeInMeaningMorePropsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.FavouritePodcast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("PodcastId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PodcastId");

                    b.HasIndex("UserId");

                    b.ToTable("FavouritePodcasts");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.FavouriteWord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("WordId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WordId");

                    b.ToTable("FavouriteWords");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Abbreviation = "UZ",
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6650),
                            Name = "Uzbek"
                        },
                        new
                        {
                            Id = 2L,
                            Abbreviation = "EN",
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6651),
                            Name = "English"
                        },
                        new
                        {
                            Id = 3L,
                            Abbreviation = "GR",
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6652),
                            Name = "German"
                        },
                        new
                        {
                            Id = 4L,
                            Abbreviation = "AR",
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6653),
                            Name = "Arabic"
                        },
                        new
                        {
                            Id = 5L,
                            Abbreviation = "SP",
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6654),
                            Name = "Spanish"
                        });
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Meaning", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Example")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<string>("PartOfSpeech")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("WordId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("WordId");

                    b.ToTable("Meanings");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Podcast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Podcasts");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NativeLanguageId")
                        .HasColumnType("bigint");

                    b.Property<long>("NewLanguageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NativeLanguageId");

                    b.HasIndex("NewLanguageId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6746),
                            FirstName = "Muzaffar",
                            LastName = "Nurillayev",
                            NativeLanguageId = 1L,
                            NewLanguageId = 2L,
                            Password = "0110",
                            Username = "muzaffar"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6748),
                            FirstName = "Azimjon",
                            LastName = "Ochilov",
                            NativeLanguageId = 2L,
                            NewLanguageId = 2L,
                            Password = "azim",
                            Username = "azimochilov"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6749),
                            FirstName = "Kamron",
                            LastName = "Sayfullayev",
                            NativeLanguageId = 2L,
                            NewLanguageId = 1L,
                            Password = "kamron",
                            Username = "kamron"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6751),
                            FirstName = "Safarmurod",
                            LastName = "Ashurov",
                            NativeLanguageId = 1L,
                            NewLanguageId = 2L,
                            Password = "safarmurod",
                            Username = "safar"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6752),
                            FirstName = "Bekmurod",
                            LastName = "Boqiyev",
                            NativeLanguageId = 2L,
                            NewLanguageId = 4L,
                            Password = "bekmurod",
                            Username = "bekmurod"
                        });
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Word", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ChosenLanguageId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("WrittenForm")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.FavouritePodcast", b =>
                {
                    b.HasOne("LanguageBooster20.Domain.Entities.Podcast", "Podcast")
                        .WithMany()
                        .HasForeignKey("PodcastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanguageBooster20.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Podcast");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.FavouriteWord", b =>
                {
                    b.HasOne("LanguageBooster20.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanguageBooster20.Domain.Entities.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Meaning", b =>
                {
                    b.HasOne("LanguageBooster20.Domain.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanguageBooster20.Domain.Entities.Word", "Word")
                        .WithMany("Meanings")
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Podcast", b =>
                {
                    b.HasOne("LanguageBooster20.Domain.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanguageBooster20.Domain.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.User", b =>
                {
                    b.HasOne("LanguageBooster20.Domain.Entities.Language", "NativeLanguage")
                        .WithMany()
                        .HasForeignKey("NativeLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanguageBooster20.Domain.Entities.Language", "NewLanguage")
                        .WithMany()
                        .HasForeignKey("NewLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NativeLanguage");

                    b.Navigation("NewLanguage");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Word", b =>
                {
                    b.HasOne("LanguageBooster20.Domain.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("LanguageBooster20.Domain.Entities.Word", b =>
                {
                    b.Navigation("Meanings");
                });
#pragma warning restore 612, 618
        }
    }
}
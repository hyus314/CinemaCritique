﻿// <auto-generated />
using System;
using CinemaCritique.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    [DbContext(typeof(CritiqueDbContext))]
    partial class CritiqueDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CinemaCritique.Data.Models.CritiqueUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 15,
                            Name = "War"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Biography"
                        });
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CoverPhotoURL")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrailerURL")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("YearPublished")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverPhotoURL = "https://pics.filmaffinity.com/The_Shawshank_Redemption-576140557-mmed.jpg",
                            Description = "A tale of hope and friendship, the film follows Andy Dufresne, a banker falsely convicted of murder, as he befriends fellow inmate Red and seeks solace and eventual freedom through acts of common decency.",
                            Director = "Frank Darabont",
                            GenreId = 1,
                            Title = "The Shawshank Redemption",
                            TrailerURL = "https://youtu.be/PLl99DlL6b4",
                            YearPublished = 1994
                        },
                        new
                        {
                            Id = 2,
                            CoverPhotoURL = "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg",
                            Description = "The story chronicles the life of Forrest Gump, a man with a low IQ, as he inadvertently influences some of the most pivotal events in U.S. history through simple acts of kindness and love.",
                            Director = "Robert Zemeckis",
                            GenreId = 2,
                            Title = "Forrest Gump",
                            TrailerURL = "https://youtu.be/bLvqoHBptjg",
                            YearPublished = 1994
                        },
                        new
                        {
                            Id = 3,
                            CoverPhotoURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781608879731/die-hard-the-ultimate-visual-history-9781608879731_hr.jpg",
                            Description = "NYPD officer John McClane arrives in Los Angeles to spend Christmas with his family but finds himself fighting off terrorists who have taken hostages in the Nakatomi Plaza building.",
                            Director = "John McTiernan",
                            GenreId = 3,
                            Title = "Die Hard",
                            TrailerURL = "https://youtu.be/gYWvwkXreaI",
                            YearPublished = 1988
                        },
                        new
                        {
                            Id = 4,
                            CoverPhotoURL = "https://upload.wikimedia.org/wikipedia/en/1/18/Titanic_%281997_film%29_poster.png",
                            Description = "This romantic tragedy follows the ill-fated voyage of the RMS Titanic, focusing on the love story between Jack, a lower-class artist, and Rose, a first-class passenger.",
                            Director = "James Cameron",
                            GenreId = 4,
                            Title = "Titanic",
                            TrailerURL = "https://youtu.be/I7c1etV7D7g",
                            YearPublished = 1997
                        },
                        new
                        {
                            Id = 5,
                            CoverPhotoURL = "https://i.etsystatic.com/27725708/r/il/7e5d08/2884298390/il_570xN.2884298390_acu6.jpg",
                            Description = "This chilling tale centers around the demonic possession of a young girl and the subsequent exorcism conducted by two priests to save her soul.",
                            Director = "William Friedkin",
                            GenreId = 5,
                            Title = "The Exorcist",
                            TrailerURL = "https://youtu.be/YDGw1MTEe9k",
                            YearPublished = 1973
                        },
                        new
                        {
                            Id = 6,
                            CoverPhotoURL = "https://m.media-amazon.com/images/I/81aA7hEEykL._AC_UF1000,1000_QL80_.jpg",
                            Description = "Young farm boy Luke Skywalker is thrust into an epic battle against the evil Galactic Empire when he meets Princess Leia and learns of his Jedi heritage.",
                            Director = "George Lucas",
                            GenreId = 6,
                            Title = "Star Wars: A New Hope",
                            TrailerURL = "https://www.youtube.com/watch?v=vZ734NWnAHA",
                            YearPublished = 1977
                        },
                        new
                        {
                            Id = 7,
                            CoverPhotoURL = "https://m.media-amazon.com/images/M/MV5BOTg3NjYxMjM5OF5BMl5BanBnXkFtZTcwMzQzMDA0MQ@@._V1_FMjpg_UX1000_.jpg",
                            Description = " Former Vice President Al Gore presents an eye-opening lecture about the realities and dangers of climate change in a documentary that aims to educate and inspire action.",
                            Director = "Davis Guggenheim",
                            GenreId = 7,
                            Title = "An Inconvenient Truth",
                            TrailerURL = "https://youtu.be/CH-qO9RRchc",
                            YearPublished = 2006
                        },
                        new
                        {
                            Id = 8,
                            CoverPhotoURL = "https://upload.wikimedia.org/wikipedia/en/7/7a/The-Sound-of-Music-CD.jpg",
                            Description = "A joyful musical that follows Maria, a young woman who leaves an Austrian convent to become the governess to the Von Trapp family, eventually falling in love with the widowed naval officer Captain Von Trapp.",
                            Director = "Robert Wise",
                            GenreId = 8,
                            Title = "The Sound of Music",
                            TrailerURL = "https://youtu.be/UY6uw3WpPzY",
                            YearPublished = 1965
                        },
                        new
                        {
                            Id = 9,
                            CoverPhotoURL = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_FMjpg_UX1000_.jpg",
                            Description = "The first installment in the epic trilogy, the movie follows a young hobbit named Frodo Baggins as he embarks on a dangerous quest to destroy a powerful ring that could bring doom to Middle-earth.",
                            Director = "Peter Jackson",
                            GenreId = 9,
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            TrailerURL = "https://youtu.be/V75dMMIW2B4",
                            YearPublished = 2001
                        },
                        new
                        {
                            Id = 10,
                            CoverPhotoURL = "https://m.media-amazon.com/images/I/61H2YD-bubL._AC_UF894,1000_QL80_.jpg",
                            Description = "Adventurous archeologist Indiana Jones races against time and enemies to find the biblical Ark of the Covenant before it falls into the wrong hands.",
                            Director = "Steven Spielberg",
                            GenreId = 10,
                            Title = "Indiana Jones: Raiders of the Lost Ark",
                            TrailerURL = "https://youtu.be/0xQSIdSRlAk",
                            YearPublished = 1981
                        },
                        new
                        {
                            Id = 11,
                            CoverPhotoURL = "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                            Description = "Oskar Schindler, a German industrialist, saves more than a thousand Polish Jews during the Holocaust by employing them in his factory.",
                            Director = "Steven Spielberg",
                            GenreId = 1,
                            Title = "Schindler's List",
                            TrailerURL = "https://youtu.be/gG22XNhtnoY",
                            YearPublished = 1993
                        },
                        new
                        {
                            Id = 12,
                            CoverPhotoURL = "https://m.media-amazon.com/images/I/A1T+lZ6iUZL._AC_UF894,1000_QL80_.jpg",
                            Description = "A young boy named Kevin McCallister is accidentally left behind by his family during Christmas and has to defend his home from burglars.",
                            Director = "Chris Columbus",
                            GenreId = 2,
                            Title = "Home Alone",
                            TrailerURL = "https://youtu.be/jEDaVHmw7r4",
                            YearPublished = 1990
                        },
                        new
                        {
                            Id = 13,
                            CoverPhotoURL = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg",
                            Description = "Batman takes on the Joker, a criminal mastermind who wants to plunge Gotham City into anarchy.",
                            Director = "Christopher Nolan",
                            GenreId = 3,
                            Title = "The Dark Knight",
                            TrailerURL = "https://youtu.be/EXeTwQWrcwY",
                            YearPublished = 2008
                        },
                        new
                        {
                            Id = 14,
                            CoverPhotoURL = "https://janeausten.co.uk/cdn/shop/articles/84811a9faeb4e60fcbb44aef004d7c26_7b3cf359-896a-47a3-ad23-7b121e914d2d.jpg?v=1648220320",
                            Description = "Elizabeth Bennet navigates issues of manners, upbringing, and marriage in the society of early 19th-century England.",
                            Director = "Joe Wright",
                            GenreId = 4,
                            Title = "Pride and Prejudice",
                            TrailerURL = "https://youtu.be/Ur_DIHs92NM",
                            YearPublished = 2005
                        },
                        new
                        {
                            Id = 15,
                            CoverPhotoURL = "https://www.tallengestore.com/cdn/shop/products/Psycho-AlfredHitchcock1960ClassicHorrorMovie-HollywoodMoviePoster_db1728d8-ce3a-4173-87c9-0c561994ff02.jpg?v=1619431709",
                            Description = "Marion Crane meets a grisly end at the Bates Motel, run by the mysterious Norman Bates.",
                            Director = "Alfred Hitchcock",
                            GenreId = 5,
                            Title = "Psycho",
                            TrailerURL = "https://youtu.be/BwVKSGu8wEA",
                            YearPublished = 1960
                        },
                        new
                        {
                            Id = 16,
                            CoverPhotoURL = "https://deepfocusreview.com/wp-content/uploads/2016/12/blade_runner.jpg",
                            Description = "In a dystopian future, a blade runner named Deckard is tasked with hunting down rogue replicants.",
                            Director = "Ridley Scott",
                            GenreId = 6,
                            Title = "Blade Runner",
                            TrailerURL = "https://youtu.be/eogpIG53Cis",
                            YearPublished = 1982
                        },
                        new
                        {
                            Id = 17,
                            CoverPhotoURL = "https://m.media-amazon.com/images/I/810Fw8dOh4L._AC_UF894,1000_QL80_.jpg",
                            Description = "This documentary provides an intimate look at Jiro Ono, an 85-year-old sushi master in Tokyo.",
                            Director = "David Gelb",
                            GenreId = 7,
                            Title = "Jiro Dreams of Sushi",
                            TrailerURL = "https://youtu.be/0VB_DrsHDQ0",
                            YearPublished = 2011
                        },
                        new
                        {
                            Id = 18,
                            CoverPhotoURL = "https://static01.nyt.com/images/2017/02/26/arts/26OSCARSPOSTER4/26OSCARSPOSTER4-articleLarge.jpg?quality=75&auto=webp&disable=upscale",
                            Description = "Two aspiring artists, a jazz musician and an actress, fall in love while pursuing their dreams in Los Angeles.",
                            Director = "Damien Chazelle",
                            GenreId = 8,
                            Title = "La La Land",
                            TrailerURL = "https://youtu.be/0pdqf4P9MB8",
                            YearPublished = 2016
                        },
                        new
                        {
                            Id = 19,
                            CoverPhotoURL = "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/1280x1280/products/84605/93507/Harry-Potter-and-the-philosophers-stone-original-movie-poster-buy-now-at-starstills__45891.1577476239.jpg?c=2",
                            Description = "Harry Potter discovers his magical heritage and attends Hogwarts School of Witchcraft and Wizardry, where he makes friends and enemies.",
                            Director = "Chris Columbus",
                            GenreId = 9,
                            Title = "Harry Potter and the Sorcerer's Stone",
                            TrailerURL = "https://youtu.be/VyHV0BRtdxo",
                            YearPublished = 2001
                        },
                        new
                        {
                            Id = 20,
                            CoverPhotoURL = "https://upload.wikimedia.org/wikipedia/en/2/21/Jurassic_Park_%28book_cover%29.jpg",
                            Description = "A group of people tries to survive when a theme park featuring genetically engineered dinosaurs descends into chaos.",
                            Director = "Steven Spielberg",
                            GenreId = 10,
                            Title = "Jurassic Park",
                            TrailerURL = "https://youtu.be/QWBKEmWWL38",
                            YearPublished = 1993
                        });
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Movie", b =>
                {
                    b.HasOne("CinemaCritique.Data.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Review", b =>
                {
                    b.HasOne("CinemaCritique.Data.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaCritique.Data.Models.CritiqueUser", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CinemaCritique.Data.Models.CritiqueUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CinemaCritique.Data.Models.CritiqueUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaCritique.Data.Models.CritiqueUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CinemaCritique.Data.Models.CritiqueUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.CritiqueUser", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CinemaCritique.Data.Models.Movie", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

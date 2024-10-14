namespace CinemaCritique.Data.Seeding
{
    using CinemaCritique.Data.Models;

    public static class MovieSeeder
    {
        public static ICollection<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>();
            Movie current;
            current = new Movie
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                GenreId = 1,
                YearPublished = 1994,
                Description = "A tale of hope and friendship, the film follows Andy Dufresne, a banker falsely convicted of murder, as he befriends fellow inmate Red and seeks solace and eventual freedom through acts of common decency.",
                CoverPhotoURL = "img/movie_images/movie_covers/the_shawshank_redemption.jpg",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "img/movie_images/movie_scenes/the_shawshank_redemption.jpg",
                TrailerURL = "https://www.youtube.com/embed/PLl99DlL6b4",
                MainRoles = "Tim Robbins, Morgan Freeman"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 2,
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                GenreId = 2,
                YearPublished = 1994,
                Description = "The story chronicles the life of Forrest Gump, a man with a low IQ, as he inadvertently influences some of the most pivotal events in U.S. history through simple acts of kindness and love.",
                CoverPhotoURL = "img/movie_images/movie_covers/forrest_gump.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://media.cnn.com/api/v1/images/stellar/prod/140702154952-02-forrest-gump-restricted.jpg?q=w_2434,h_1631,x_0,y_0,c_fill",
                TrailerURL = "https://www.youtube.com/embed/bLvqoHBptjg",
                MainRoles = "Tom Hanks, Robin Wright, Gary Sinise"
            };
            movies.Add(current);
            current = new Movie
            {
                Id = 3,
                Title = "Die Hard",
                Director = "John McTiernan",
                GenreId = 3,
                YearPublished = 1988,
                Description = "NYPD officer John McClane arrives in Los Angeles to spend Christmas with his family but finds himself fighting off terrorists who have taken hostages in the Nakatomi Plaza building.",
                CoverPhotoURL = "img/movie_images/movie_covers/die_hard.jpg",
                DateAdded = DateTime.Now.AddDays(-1),
                ScenePhotoUrl = "https://i.ytimg.com/vi/2UWD2uxIOis/maxresdefault.jpg",
                TrailerURL = "https://www.youtube.com/embed/gYWvwkXreaI",
                MainRoles = "Bruce Willis, Alan Rickman, Bonnie Bedelia"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 4,
                Title = "Titanic",
                Director = "James Cameron",
                GenreId = 4,
                YearPublished = 1997,
                Description = "This romantic tragedy follows the ill-fated voyage of the RMS Titanic, focusing on the love story between Jack, a lower-class artist, and Rose, a first-class passenger.",
                CoverPhotoURL = "img/movie_images/movie_covers/titanic.png",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "https://media.cnn.com/api/v1/images/stellar/prod/230213144330-02-titanic-25th-anniversary-restricted.jpg?c=original",
                TrailerURL = "https://www.youtube.com/embed/I7c1etV7D7g",
                MainRoles = "Leonardo DiCaprio, Kate Winslet, Billy Zane"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 5,
                Title = "The Exorcist",
                Director = "William Friedkin",
                GenreId = 5,
                YearPublished = 1973,
                Description = "This chilling tale centers around the demonic possession of a young girl and the subsequent exorcism conducted by two priests to save her soul.",
                CoverPhotoURL = "img/movie_images/movie_covers/the_exorcist.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://miro.medium.com/v2/resize:fit:1200/1*4-1LWn65DlUF0uBLdIzo2A.jpeg",
                TrailerURL = "https://www.youtube.com/embed/YDGw1MTEe9k",
                MainRoles = "Ellen Burstyn, Max von Sydow, Linda Blair"
            };
            movies.Add(current);

        
            current = new Movie
            {
                Id = 6,
                Title = "Star Wars: A New Hope",
                Director = "George Lucas",
                GenreId = 6,
                YearPublished = 1977,
                Description = "Young farm boy Luke Skywalker is thrust into an epic battle against the evil Galactic Empire when he meets Princess Leia and learns of his Jedi heritage.",
                CoverPhotoURL = "img/movie_images/movie_covers/star_wars_a_new_hope.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://hop.dartmouth.edu/sites/hop.prod/files/styles/width_960/public/hop/content/gallery-item/image/star-wars-a-new-hope-gallery1.jpg?itok=3IPzJms_",
                TrailerURL = "https://www.youtube.com/embed/vZ734NWnAHA",
                MainRoles = "Mark Hamill, Harrison Ford, Carrie Fisher"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 7,
                Title = "An Inconvenient Truth",
                Director = "Davis Guggenheim",
                GenreId = 7,
                YearPublished = 2006,
                Description = "Former Vice President Al Gore presents an eye-opening lecture about the realities and dangers of climate change in a documentary that aims to educate and inspire action.",
                CoverPhotoURL = "img/movie_images/movie_covers/an_inconvenient_truth.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://grist.org/wp-content/uploads/2016/05/gore-on-scissor-lift.jpg",
                TrailerURL = "https://www.youtube.com/embed/CH-qO9RRchc",
                MainRoles = "Al Gore, Billy West"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 8,
                Title = "The Sound of Music",
                Director = "Robert Wise",
                GenreId = 8,
                YearPublished = 1965,
                Description = "A joyful musical that follows Maria, a young woman who leaves an Austrian convent to become the governess to the Von Trapp family, eventually falling in love with the widowed naval officer Captain Von Trapp.",
                CoverPhotoURL = "img/movie_images/movie_covers/the_sound_of_music.jpg",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "https://s.abcnews.com/images/Entertainment/GTY_the_sound_of_music_jef_131210_16x9_992.jpg",
                TrailerURL = "https://www.youtube.com/embed/UY6uw3WpPzY",
                MainRoles = "Julie Andrews, Christopher Plummer, Eleanor Parker"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 9,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Director = "Peter Jackson",
                GenreId = 9,
                YearPublished = 2001,
                Description = "The first installment in the epic trilogy, the movie follows a young hobbit named Frodo Baggins as he embarks on a dangerous quest to destroy a powerful ring that could bring doom to Middle-earth.",
                CoverPhotoURL = "img/movie_images/movie_covers/lotr_the_fellowship_of_the_ring.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://legendary-digital-network-assets.s3.amazonaws.com/wp-content/uploads/2022/08/23111048/The-Two-Towers-7.jpg",
                TrailerURL = "https://www.youtube.com/embed/V75dMMIW2B4",
                MainRoles = "Elijah Wood, Ian McKellen, Orlando Bloom"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 10,
                Title = "Indiana Jones: Raiders of the Lost Ark",
                Director = "Steven Spielberg",
                GenreId = 10,
                YearPublished = 1981,
                Description = "Adventurous archeologist Indiana Jones races against time and enemies to find the biblical Ark of the Covenant before it falls into the wrong hands.",
                CoverPhotoURL = "img/movie_images/movie_covers/indiana_jones_raiders.jpg",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "https://www.syfy.com/sites/syfy/files/2019/04/mv5botkxmzqymty3nl5bml5banbnxkftztcwmtu4mzczmw._v1_sx1471_cr001471999_al_.jpg",
                TrailerURL = "https://www.youtube.com/embed/0xQSIdSRlAk",
                MainRoles = "Harrison Ford, Karen Allen, Paul Freeman"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 11,
                Title = "Schindler's List",
                Director = "Steven Spielberg",
                GenreId = 1,
                YearPublished = 1993,
                Description = "Oskar Schindler, a German industrialist, saves more than a thousand Polish Jews during the Holocaust by employing them in his factory.",
                CoverPhotoURL = "img/movie_images/movie_covers/schindler's_list.jpg",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "https://i.ytimg.com/vi/x4mcmymd-5s/maxresdefault.jpg",
                TrailerURL = "https://www.youtube.com/embed/gG22XNhtnoY",
                MainRoles = "Liam Neeson, Ben Kingsley, Ralph Fiennes"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 12,
                Title = "Home Alone",
                Director = "Chris Columbus",
                GenreId = 2,
                YearPublished = 1990,
                Description = "A young boy named Kevin McCallister is accidentally left behind by his family during Christmas and has to defend his home from burglars.",
                CoverPhotoURL = "img/movie_images/movie_covers/home_alone.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://www.usatoday.com/gcdn/-mm-/b74c719214fb46f112bebb7fdd4e37d42f82f105/c=0-68-1280-791/local/-/media/2015/10/03/USATODAY/USATODAY/635794823832323546-HA-1604.jpg?width=1280&height=723&fit=crop&format=pjpg&auto=webp",
                TrailerURL = "https://www.youtube.com/embed/jEDaVHmw7r4",
                MainRoles = "Macaulay Culkin, Joe Pesci, Daniel Stern"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 13,
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                GenreId = 3,
                YearPublished = 2008,
                Description = "Batman takes on the Joker, a criminal mastermind who wants to plunge Gotham City into anarchy.",
                CoverPhotoURL = "img/movie_images/movie_covers/the_dark_knight.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://breakinggeek.files.wordpress.com/2015/01/thedarkknightd3176206dsuf4.jpg",
                TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                MainRoles = "Christian Bale, Heath Ledger, Aaron Eckhart"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 14,
                Title = "Pride and Prejudice",
                Director = "Joe Wright",
                GenreId = 4,
                YearPublished = 2005,
                Description = "Elizabeth Bennet navigates issues of manners, upbringing, and marriage in the society of early 19th-century England.",
                CoverPhotoURL = "img/movie_images/movie_covers/pride_and_prejudice.jpg",
                DateAdded = DateTime.Now.AddDays(-5),
                ScenePhotoUrl = "https://lh3.googleusercontent.com/RwOEZG7GP_aR1XcsYC0huOhVxY7lH4LP4KGUVJR_lrQ5ihPCGddNbjCN0CjmXi343yom_ABfg6CWL70a7778kJ1LJGWCQz3YAHRVgcmMI4JY3zfbLt4vflr1qhZoqzIde8AjwCkb",
                TrailerURL = "https://www.youtube.com/embed/Ur_DIHs92NM",
                MainRoles = "Keira Knightley, Matthew Macfadyen, Brenda Blethyn"
            };
            movies.Add(current);


            current = new Movie
            {
                Id = 15,
                Title = "Psycho",
                Director = "Alfred Hitchcock",
                GenreId = 5,
                YearPublished = 1960,
                Description = "Marion Crane meets a grisly end at the Bates Motel, run by the mysterious Norman Bates.",
                CoverPhotoURL = "img/movie_images/movie_covers/psycho.jpg",
                DateAdded = DateTime.Now.AddDays(-4),
                ScenePhotoUrl = "https://i.ytimg.com/vi/2_I70o81fwk/maxresdefault.jpg",
                TrailerURL = "https://www.youtube.com/embed/BwVKSGu8wEA",
                MainRoles = "Anthony Perkins, Janet Leigh, Vera Miles"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 16,
                Title = "Blade Runner",
                Director = "Ridley Scott",
                GenreId = 6,
                YearPublished = 1982,
                Description = "In a dystopian future, a blade runner named Deckard is tasked with hunting down rogue replicants.",
                CoverPhotoURL = "img/movie_images/movie_covers/blade_runner.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://cinemontage.org/wp-content/uploads/2017/02/BladeRunner_Feature-678x381.jpg",
                TrailerURL = "https://www.youtube.com/embed/eogpIG53Cis",
                MainRoles = "Harrison Ford, Rutger Hauer, Sean Young"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 17,
                Title = "Jiro Dreams of Sushi",
                Director = "David Gelb",
                GenreId = 7,
                YearPublished = 2011,
                Description = "This documentary provides an intimate look at Jiro Ono, an 85-year-old sushi master in Tokyo.",
                CoverPhotoURL = "img/movie_images/movie_covers/jiro_dreams_of_sushi.jpg",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "https://media.npr.org/assets/img/2012/03/06/2_wide-dc2780d91910f6718c5e23f5f0a7ca3a7ee6c961-s1100-c50.jpg",
                TrailerURL = "https://www.youtube.com/embed/0VB_DrsHDQ0",
                MainRoles = "Jiro Ono, Yoshikazu Ono, Masuhiro Yamamoto"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 18,
                Title = "La La Land",
                Director = "Damien Chazelle",
                GenreId = 8,
                YearPublished = 2016,
                Description = "Two aspiring artists, a jazz musician and an actress, fall in love while pursuing their dreams in Los Angeles.",
                CoverPhotoURL = "img/movie_images/movie_covers/la_la_land.jpg",
                DateAdded = DateTime.Now.AddDays(-2),
                ScenePhotoUrl = "https://images.squarespace-cdn.com/content/v1/5bd4e5708dfc8cb34346c68b/1549963167505-IFYQTEWAHSM2U8S2T6DF/la_la_land_banner.jpg?format=1500w",
                TrailerURL = "https://www.youtube.com/embed/0pdqf4P9MB8",
                MainRoles = "Ryan Gosling, Emma Stone, Rosemarie DeWitt"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 19,
                Title = "Harry Potter and the Sorcerer's Stone",
                Director = "Chris Columbus",
                GenreId = 9,
                YearPublished = 2001,
                Description = "Harry Potter discovers his magical heritage and attends Hogwarts School of Witchcraft and Wizardry, where he makes friends and enemies.",
                CoverPhotoURL = "img/movie_images/movie_covers/hp_and_the_sorcerers_stone.jpg",
                DateAdded = DateTime.Now.AddDays(-4),
                ScenePhotoUrl = "https://justkillingti.me/wp-content/2016/11/article-2109071-02e5ddd20000044d-817_964x591.jpg",
                TrailerURL = "https://www.youtube.com/embed/VyHV0BRtdxo",
                MainRoles = "Daniel Radcliffe, Rupert Grint, Emma Watson"
            };
            movies.Add(current);

            current = new Movie
            {
                Id = 20,
                Title = "Jurassic Park",
                Director = "Steven Spielberg",
                GenreId = 10,
                YearPublished = 1993,
                Description = "A group of people tries to survive when a theme park featuring genetically engineered dinosaurs descends into chaos.",
                CoverPhotoURL = "img/movie_images/movie_covers/jurassic_park.jpg",
                DateAdded = DateTime.Now.AddDays(-3),
                ScenePhotoUrl = "https://i.kinja-img.com/gawker-media/image/upload/c_fill,f_auto,fl_progressive,g_center,h_675,pg_1,q_80,w_1200/buj0nndhaegv5vje8yox.jpg",
                TrailerURL = "https://www.youtube.com/embed/QWBKEmWWL38",
                MainRoles = "Sam Neill, Laura Dern, Jeff Goldblum"
            };
            movies.Add(current);

            return movies;
        }
    }
}

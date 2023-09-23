using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Seed_Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverPhotoURL", "Description", "Director", "GenreId", "Title", "TrailerURL", "YearPublished" },
                values: new object[,]
                {
                    { 1, "https://pics.filmaffinity.com/The_Shawshank_Redemption-576140557-mmed.jpg", "A tale of hope and friendship, the film follows Andy Dufresne, a banker falsely convicted of murder, as he befriends fellow inmate Red and seeks solace and eventual freedom through acts of common decency.", "Frank Darabont", 1, "The Shawshank Redemption", "https://youtu.be/PLl99DlL6b4", 1994 },
                    { 2, "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg", "The story chronicles the life of Forrest Gump, a man with a low IQ, as he inadvertently influences some of the most pivotal events in U.S. history through simple acts of kindness and love.", "Robert Zemeckis", 2, "Forrest Gump", "https://youtu.be/bLvqoHBptjg", 1994 },
                    { 3, "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781608879731/die-hard-the-ultimate-visual-history-9781608879731_hr.jpg", "NYPD officer John McClane arrives in Los Angeles to spend Christmas with his family but finds himself fighting off terrorists who have taken hostages in the Nakatomi Plaza building.", "John McTiernan", 3, "Die Hard", "https://youtu.be/gYWvwkXreaI", 1988 },
                    { 4, "https://upload.wikimedia.org/wikipedia/en/1/18/Titanic_%281997_film%29_poster.png", "This romantic tragedy follows the ill-fated voyage of the RMS Titanic, focusing on the love story between Jack, a lower-class artist, and Rose, a first-class passenger.", "James Cameron", 4, "Titanic", "https://youtu.be/I7c1etV7D7g", 1997 },
                    { 5, "https://i.etsystatic.com/27725708/r/il/7e5d08/2884298390/il_570xN.2884298390_acu6.jpg", "This chilling tale centers around the demonic possession of a young girl and the subsequent exorcism conducted by two priests to save her soul.", "William Friedkin", 5, "The Exorcist", "https://youtu.be/YDGw1MTEe9k", 1973 },
                    { 6, "https://m.media-amazon.com/images/I/81aA7hEEykL._AC_UF1000,1000_QL80_.jpg", "Young farm boy Luke Skywalker is thrust into an epic battle against the evil Galactic Empire when he meets Princess Leia and learns of his Jedi heritage.", "George Lucas", 6, "Star Wars: A New Hope", "https://www.youtube.com/watch?v=vZ734NWnAHA", 1977 },
                    { 7, "https://m.media-amazon.com/images/M/MV5BOTg3NjYxMjM5OF5BMl5BanBnXkFtZTcwMzQzMDA0MQ@@._V1_FMjpg_UX1000_.jpg", " Former Vice President Al Gore presents an eye-opening lecture about the realities and dangers of climate change in a documentary that aims to educate and inspire action.", "Davis Guggenheim", 7, "An Inconvenient Truth", "https://youtu.be/CH-qO9RRchc", 2006 },
                    { 8, "https://upload.wikimedia.org/wikipedia/en/7/7a/The-Sound-of-Music-CD.jpg", "A joyful musical that follows Maria, a young woman who leaves an Austrian convent to become the governess to the Von Trapp family, eventually falling in love with the widowed naval officer Captain Von Trapp.", "Robert Wise", 8, "The Sound of Music", "https://youtu.be/UY6uw3WpPzY", 1965 },
                    { 9, "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_FMjpg_UX1000_.jpg", "The first installment in the epic trilogy, the movie follows a young hobbit named Frodo Baggins as he embarks on a dangerous quest to destroy a powerful ring that could bring doom to Middle-earth.", "Peter Jackson", 9, "The Lord of the Rings: The Fellowship of the Ring", "https://youtu.be/V75dMMIW2B4", 2001 },
                    { 10, "https://m.media-amazon.com/images/I/61H2YD-bubL._AC_UF894,1000_QL80_.jpg", "Adventurous archeologist Indiana Jones races against time and enemies to find the biblical Ark of the Covenant before it falls into the wrong hands.", "Steven Spielberg", 10, "Indiana Jones: Raiders of the Lost Ark", "https://youtu.be/0xQSIdSRlAk", 1981 },
                    { 11, "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", "Oskar Schindler, a German industrialist, saves more than a thousand Polish Jews during the Holocaust by employing them in his factory.", "Steven Spielberg", 1, "Schindler's List", "https://youtu.be/gG22XNhtnoY", 1993 },
                    { 12, "https://m.media-amazon.com/images/I/A1T+lZ6iUZL._AC_UF894,1000_QL80_.jpg", "A young boy named Kevin McCallister is accidentally left behind by his family during Christmas and has to defend his home from burglars.", "Chris Columbus", 2, "Home Alone", "https://youtu.be/jEDaVHmw7r4", 1990 },
                    { 13, "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg", "Batman takes on the Joker, a criminal mastermind who wants to plunge Gotham City into anarchy.", "Christopher Nolan", 3, "The Dark Knight", "https://youtu.be/EXeTwQWrcwY", 2008 },
                    { 14, "https://janeausten.co.uk/cdn/shop/articles/84811a9faeb4e60fcbb44aef004d7c26_7b3cf359-896a-47a3-ad23-7b121e914d2d.jpg?v=1648220320", "Elizabeth Bennet navigates issues of manners, upbringing, and marriage in the society of early 19th-century England.", "Joe Wright", 4, "Pride and Prejudice", "https://youtu.be/Ur_DIHs92NM", 2005 },
                    { 15, "https://www.tallengestore.com/cdn/shop/products/Psycho-AlfredHitchcock1960ClassicHorrorMovie-HollywoodMoviePoster_db1728d8-ce3a-4173-87c9-0c561994ff02.jpg?v=1619431709", "Marion Crane meets a grisly end at the Bates Motel, run by the mysterious Norman Bates.", "Alfred Hitchcock", 5, "Psycho", "https://youtu.be/BwVKSGu8wEA", 1960 },
                    { 16, "https://deepfocusreview.com/wp-content/uploads/2016/12/blade_runner.jpg", "In a dystopian future, a blade runner named Deckard is tasked with hunting down rogue replicants.", "Ridley Scott", 6, "Blade Runner", "https://youtu.be/eogpIG53Cis", 1982 },
                    { 17, "https://m.media-amazon.com/images/I/810Fw8dOh4L._AC_UF894,1000_QL80_.jpg", "This documentary provides an intimate look at Jiro Ono, an 85-year-old sushi master in Tokyo.", "David Gelb", 7, "Jiro Dreams of Sushi", "https://youtu.be/0VB_DrsHDQ0", 2011 },
                    { 18, "https://static01.nyt.com/images/2017/02/26/arts/26OSCARSPOSTER4/26OSCARSPOSTER4-articleLarge.jpg?quality=75&auto=webp&disable=upscale", "Two aspiring artists, a jazz musician and an actress, fall in love while pursuing their dreams in Los Angeles.", "Damien Chazelle", 8, "La La Land", "https://youtu.be/0pdqf4P9MB8", 2016 },
                    { 19, "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/1280x1280/products/84605/93507/Harry-Potter-and-the-philosophers-stone-original-movie-poster-buy-now-at-starstills__45891.1577476239.jpg?c=2", "Harry Potter discovers his magical heritage and attends Hogwarts School of Witchcraft and Wizardry, where he makes friends and enemies.", "Chris Columbus", 9, "Harry Potter and the Sorcerer's Stone", "https://youtu.be/VyHV0BRtdxo", 2001 },
                    { 20, "https://upload.wikimedia.org/wikipedia/en/2/21/Jurassic_Park_%28book_cover%29.jpg", "A group of people tries to survive when a theme park featuring genetically engineered dinosaurs descends into chaos.", "Steven Spielberg", 10, "Jurassic Park", "https://youtu.be/QWBKEmWWL38", 1993 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}

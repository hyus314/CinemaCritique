using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_AllMoviePaths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/star_wars_a_new_hope.jpg", new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/an_inconvenient_truth.jpg", new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/the_sound_of_music.jpg", new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/lotr_the_fellowship_of_the_ring.jpg", new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/indiana_jones_raiders.jpg", new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/schindler's_list.jpg", new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/home_alone.jpg", new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/the_dark_knight.jpg", new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/pride_and_prejudice.jpg", new DateTime(2024, 10, 2, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/psycho.jpg", new DateTime(2024, 10, 3, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/jiro_dreams_of_sushi.jpg", new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/la_la_land.jpg", new DateTime(2024, 10, 5, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/hp_and_the_sorcerers_stone.jpg", new DateTime(2024, 10, 3, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/jurassic_park.jpg", new DateTime(2024, 10, 4, 13, 11, 36, 128, DateTimeKind.Local).AddTicks(7511) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/I/81aA7hEEykL._AC_UF1000,1000_QL80_.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BOTg3NjYxMjM5OF5BMl5BanBnXkFtZTcwMzQzMDA0MQ@@._V1_FMjpg_UX1000_.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/7/7a/The-Sound-of-Music-CD.jpg", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_FMjpg_UX1000_.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/I/61H2YD-bubL._AC_UF894,1000_QL80_.jpg", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/I/A1T+lZ6iUZL._AC_UF894,1000_QL80_.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://janeausten.co.uk/cdn/shop/articles/84811a9faeb4e60fcbb44aef004d7c26_7b3cf359-896a-47a3-ad23-7b121e914d2d.jpg?v=1648220320", new DateTime(2024, 10, 2, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://www.tallengestore.com/cdn/shop/products/Psycho-AlfredHitchcock1960ClassicHorrorMovie-HollywoodMoviePoster_db1728d8-ce3a-4173-87c9-0c561994ff02.jpg?v=1619431709", new DateTime(2024, 10, 3, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://m.media-amazon.com/images/I/810Fw8dOh4L._AC_UF894,1000_QL80_.jpg", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://static01.nyt.com/images/2017/02/26/arts/26OSCARSPOSTER4/26OSCARSPOSTER4-articleLarge.jpg?quality=75&auto=webp&disable=upscale", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/1280x1280/products/84605/93507/Harry-Potter-and-the-philosophers-stone-original-movie-poster-buy-now-at-starstills__45891.1577476239.jpg?c=2", new DateTime(2024, 10, 3, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/2/21/Jurassic_Park_%28book_cover%29.jpg", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(224) });
        }
    }
}

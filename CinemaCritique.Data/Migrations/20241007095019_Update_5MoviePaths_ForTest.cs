using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_5MoviePaths_ForTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/the_shawshank_redemption.jpg", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/forrest_gump.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/die_hard.jpg", new DateTime(2024, 10, 6, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/titanic.png", new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/the_exorcist.jpg", new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 2, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(208));

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
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 50, 18, 759, DateTimeKind.Local).AddTicks(224));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://pics.filmaffinity.com/The_Shawshank_Redemption-576140557-mmed.jpg", new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg", new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781608879731/die-hard-the-ultimate-visual-history-9781608879731_hr.jpg", new DateTime(2024, 10, 6, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/1/18/Titanic_%281997_film%29_poster.png", new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://i.etsystatic.com/27725708/r/il/7e5d08/2884298390/il_570xN.2884298390_acu6.jpg", new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 2, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2623));
        }
    }
}

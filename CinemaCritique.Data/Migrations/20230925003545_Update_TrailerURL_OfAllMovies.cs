using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_TrailerURL_OfAllMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8816), "https://www.youtube.com/embed/bLvqoHBptjg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 24, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8820), "https://www.youtube.com/embed/gYWvwkXreaI" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8822), "https://www.youtube.com/embed/I7c1etV7D7g" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8825), "https://www.youtube.com/embed/YDGw1MTEe9k" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8828), "https://www.youtube.com/embed/vZ734NWnAHA" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8831), "https://www.youtube.com/embed/CH-qO9RRchc" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8834), "https://www.youtube.com/embed/UY6uw3WpPzY" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8836), "https://www.youtube.com/embed/V75dMMIW2B4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8840), "https://www.youtube.com/embed/0xQSIdSRlAk" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8843), "https://www.youtube.com/embed/gG22XNhtnoY" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8845), "https://www.youtube.com/embed/jEDaVHmw7r4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8848), "https://www.youtube.com/embed/EXeTwQWrcwY" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 20, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8850), "https://www.youtube.com/embed/Ur_DIHs92NM" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 21, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8853), "https://www.youtube.com/embed/BwVKSGu8wEA" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8855), "https://www.youtube.com/embed/eogpIG53Cis" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8858), "https://www.youtube.com/embed/0VB_DrsHDQ0" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8862), "https://www.youtube.com/embed/0pdqf4P9MB8" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 21, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8864), "https://www.youtube.com/embed/VyHV0BRtdxo" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 35, 44, 765, DateTimeKind.Local).AddTicks(8867), "https://www.youtube.com/embed/QWBKEmWWL38" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1672), "https://youtu.be/bLvqoHBptjg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 24, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1675), "https://youtu.be/gYWvwkXreaI" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1677), "https://youtu.be/I7c1etV7D7g" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1679), "https://youtu.be/YDGw1MTEe9k" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1683), "https://www.youtube.com/watch?v=vZ734NWnAHA" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1685), "https://youtu.be/CH-qO9RRchc" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1688), "https://youtu.be/UY6uw3WpPzY" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1690), "https://youtu.be/V75dMMIW2B4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1693), "https://youtu.be/0xQSIdSRlAk" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1695), "https://youtu.be/gG22XNhtnoY" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1698), "https://youtu.be/jEDaVHmw7r4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1700), "https://youtu.be/EXeTwQWrcwY" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 20, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1702), "https://youtu.be/Ur_DIHs92NM" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 21, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1704), "https://youtu.be/BwVKSGu8wEA" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1707), "https://youtu.be/eogpIG53Cis" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1709), "https://youtu.be/0VB_DrsHDQ0" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1712), "https://youtu.be/0pdqf4P9MB8" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 21, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1715), "https://youtu.be/VyHV0BRtdxo" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1717), "https://youtu.be/QWBKEmWWL38" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_Shawshank_Url_MovieScene2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4889), "img/movie_images/movie_scenes/the_shawshank_redemption.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 59, 11, 538, DateTimeKind.Local).AddTicks(5024));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1206), "img/movie_images/movie_covers/the_shawshank_redemption.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 53, 55, 88, DateTimeKind.Local).AddTicks(1447));
        }
    }
}

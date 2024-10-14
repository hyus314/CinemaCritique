using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_Shawshank_Url_MovieScene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3319), "../img/movie_scenes/movie_covers/the_shawshank_redemption.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 12, 51, 59, 926, DateTimeKind.Local).AddTicks(3405));
        }
    }
}

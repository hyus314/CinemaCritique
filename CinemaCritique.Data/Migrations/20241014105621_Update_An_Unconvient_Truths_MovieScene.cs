using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_An_Unconvient_Truths_MovieScene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2728), "img/movie_images/movie_scenes/an_inconvenient_truth.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2868));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1208), "https://grist.org/wp-content/uploads/2016/05/gore-on-scissor-lift.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1252));
        }
    }
}

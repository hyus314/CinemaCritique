using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_The_Sound_of_Musics_MovieScene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8121), "img/movie_images/movie_scenes/the_sound_of_music.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 58, 5, 879, DateTimeKind.Local).AddTicks(8237));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2024, 10, 11, 13, 56, 21, 587, DateTimeKind.Local).AddTicks(2800), "img/movie_images/movie_scenes/the_soound_of_music.jpg" });

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
    }
}

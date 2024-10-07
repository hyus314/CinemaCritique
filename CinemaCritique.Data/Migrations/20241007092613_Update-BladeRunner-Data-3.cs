using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class UpdateBladeRunnerData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2567));

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
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/blade_runner.jpg", new DateTime(2024, 10, 5, 12, 26, 13, 277, DateTimeKind.Local).AddTicks(2609) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 2, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "~/img/movie_images/movie_covers/blade_runner.jpg", new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 25, 4, 613, DateTimeKind.Local).AddTicks(3413));
        }
    }
}

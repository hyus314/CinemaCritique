using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class UpdateBladeRunnerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 57, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 58, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 2, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "img/movie_images/movie_covers/blade_runner.jpg", new DateTime(2024, 10, 5, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 5, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 3, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 4, 12, 7, 49, 58, DateTimeKind.Local).AddTicks(26));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 11, 21, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2023, 11, 17, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2023, 11, 18, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoverPhotoURL", "DateAdded" },
                values: new object[] { "https://deepfocusreview.com/wp-content/uploads/2016/12/blade_runner.jpg", new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2023, 11, 20, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2023, 11, 18, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2023, 11, 19, 23, 44, 49, 868, DateTimeKind.Local).AddTicks(2320));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class UpdateBladeRunnerData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

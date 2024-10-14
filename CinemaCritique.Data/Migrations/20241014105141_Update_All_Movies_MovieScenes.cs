using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_All_Movies_MovieScenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 51, 41, 326, DateTimeKind.Local).AddTicks(1208));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 13, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2024, 10, 9, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2024, 10, 12, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2024, 10, 10, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 10, 11, 13, 50, 57, 246, DateTimeKind.Local).AddTicks(2167));
        }
    }
}

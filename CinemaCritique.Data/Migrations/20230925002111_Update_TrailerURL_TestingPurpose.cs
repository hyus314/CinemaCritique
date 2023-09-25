using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Update_TrailerURL_TestingPurpose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1634), "https://www.youtube.com/embed/PLl99DlL6b4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 24, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 3, 21, 10, 733, DateTimeKind.Local).AddTicks(1717));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "TrailerURL" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3779), "https://youtu.be/PLl99DlL6b4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2023, 9, 19, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3865));
        }
    }
}

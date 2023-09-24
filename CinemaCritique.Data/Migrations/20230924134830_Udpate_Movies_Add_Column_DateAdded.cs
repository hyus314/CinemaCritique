using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class Udpate_Movies_Add_Column_DateAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2023, 9, 19, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7771));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Movies");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class AddRolesToMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainRoles",
                table: "Movies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(4977), "Tim Robbins, Morgan Freeman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5013), "Tom Hanks, Robin Wright, Gary Sinise" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 28, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5016), "Bruce Willis, Alan Rickman, Bonnie Bedelia" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5018), "Leonardo DiCaprio, Kate Winslet, Billy Zane" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5021), "Ellen Burstyn, Max von Sydow, Linda Blair" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5024), "Mark Hamill, Harrison Ford, Carrie Fisher" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Description", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5027), "Former Vice President Al Gore presents an eye-opening lecture about the realities and dangers of climate change in a documentary that aims to educate and inspire action.", "Al Gore, Billy West" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5029), "Julie Andrews, Christopher Plummer, Eleanor Parker" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5031), "Elijah Wood, Ian McKellen, Orlando Bloom" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5035), "Harrison Ford, Karen Allen, Paul Freeman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5038), "Liam Neeson, Ben Kingsley, Ralph Fiennes" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5041), "Macaulay Culkin, Joe Pesci, Daniel Stern" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5044), "Christian Bale, Heath Ledger, Aaron Eckhart" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5046), "Keira Knightley, Matthew Macfadyen, Brenda Blethyn" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 25, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5048), "Anthony Perkins, Janet Leigh, Vera Miles" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5051), "Harrison Ford, Rutger Hauer, Sean Young" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5053), "Jiro Ono, Yoshikazu Ono, Masuhiro Yamamoto" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5057), "Ryan Gosling, Emma Stone, Rosemarie DeWitt" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 25, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5059), "Daniel Radcliffe, Rupert Grint, Emma Watson" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "MainRoles" },
                values: new object[] { new DateTime(2023, 9, 26, 20, 7, 43, 34, DateTimeKind.Local).AddTicks(5061), "Sam Neill, Laura Dern, Jeff Goldblum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainRoles",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5491), " Former Vice President Al Gore presents an eye-opening lecture about the realities and dangers of climate change in a documentary that aims to educate and inspire action." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2023, 9, 24, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2023, 9, 26, 16, 17, 21, 690, DateTimeKind.Local).AddTicks(5525));
        }
    }
}

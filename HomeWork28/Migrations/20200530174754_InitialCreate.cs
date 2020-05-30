using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork28.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frazes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frazes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Frazes",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 1, "Hurshed", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vsyo Menyaetsya" });

            migrationBuilder.InsertData(
                table: "Frazes",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 2, "Payrav", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ploxo sojelet o tom chto ne tak jil" });

            migrationBuilder.InsertData(
                table: "Frazes",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 3, "Firdavs", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vigral grin kartu" });

            migrationBuilder.InsertData(
                table: "Frazes",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 4, "Shahzod", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vzlom wifi" });

            migrationBuilder.InsertData(
                table: "Frazes",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 5, "Karim", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jivi dolgo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frazes");
        }
    }
}

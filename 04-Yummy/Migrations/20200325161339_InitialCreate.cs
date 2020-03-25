using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yummy.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false),
                    Number_of_likes = table.Column<int>(nullable: false),
                    Ingredients = table.Column<string>(nullable: true),
                    Process = table.Column<string>(nullable: true),
                    Tips_and_tricks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}

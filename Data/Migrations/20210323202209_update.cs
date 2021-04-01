using Microsoft.EntityFrameworkCore.Migrations;

namespace KlubPrátelTaborovychOhnu.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nazev",
                table: "Clanek",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nazev",
                table: "Clanek");
        }
    }
}

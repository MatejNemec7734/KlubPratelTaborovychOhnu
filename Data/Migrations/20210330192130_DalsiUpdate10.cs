using Microsoft.EntityFrameworkCore.Migrations;

namespace KlubPrátelTaborovychOhnu.Data.Migrations
{
    public partial class DalsiUpdate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Muz",
                table: "Osoba");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Muz",
                table: "Osoba",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

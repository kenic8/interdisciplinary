using Microsoft.EntityFrameworkCore.Migrations;

namespace TournamentWeb.Migrations
{
    public partial class fff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamImage",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamImage",
                table: "Teams");
        }
    }
}

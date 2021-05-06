using Microsoft.EntityFrameworkCore.Migrations;

namespace TournamentWeb.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Tournament",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Discord = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_CreatorUserId",
                table: "Tournament",
                column: "CreatorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_User_CreatorUserId",
                table: "Tournament",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_User_CreatorUserId",
                table: "Tournament");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_CreatorUserId",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Tournament");
        }
    }
}

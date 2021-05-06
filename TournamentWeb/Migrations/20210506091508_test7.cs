using Microsoft.EntityFrameworkCore.Migrations;

namespace TournamentWeb.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserStatus",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "Tournament",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bracket",
                columns: table => new
                {
                    BracketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BracketSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bracket", x => x.BracketId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_BracketId",
                table: "User",
                column: "BracketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_BracketId",
                table: "Tournament",
                column: "BracketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Bracket_BracketId",
                table: "Tournament",
                column: "BracketId",
                principalTable: "Bracket",
                principalColumn: "BracketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Bracket_BracketId",
                table: "User",
                column: "BracketId",
                principalTable: "Bracket",
                principalColumn: "BracketId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Bracket_BracketId",
                table: "Tournament");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Bracket_BracketId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Bracket");

            migrationBuilder.DropIndex(
                name: "IX_User_BracketId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_BracketId",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserStatus",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "Tournament");
        }
    }
}

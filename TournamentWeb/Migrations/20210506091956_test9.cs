using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TournamentWeb.Migrations
{
    public partial class test9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamsTeamId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeFrame = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BracketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.MatchId);
                    table.ForeignKey(
                        name: "FK_Match_Bracket_BracketId",
                        column: x => x.BracketId,
                        principalTable: "Bracket",
                        principalColumn: "BracketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchPattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchWins = table.Column<int>(type: "int", nullable: false),
                    LostGame = table.Column<bool>(type: "bit", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_TeamsTeamId",
                table: "User",
                column: "TeamsTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_BracketId",
                table: "Match",
                column: "BracketId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Teams_TeamsTeamId",
                table: "User",
                column: "TeamsTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Teams_TeamsTeamId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropIndex(
                name: "IX_User_TeamsTeamId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TeamsTeamId",
                table: "User");
        }
    }
}

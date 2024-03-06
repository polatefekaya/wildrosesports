using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_CardEntity_CardId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_DribbleEntity_DribbleId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_DuelEntity_DuelId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_FoulEntity_FoulId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_GameEntity_GameId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_LeagueEntity_LeagueId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_PassEntity_PassId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_PenaltyEntity_PenaltyId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_ShotEntity_ShotId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_SubstituteEntity_SubstitueId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_TackleEntity_TackleId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_TeamEntity_TeamId",
                table: "Statistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamEntity",
                table: "TeamEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TackleEntity",
                table: "TackleEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubstituteEntity",
                table: "SubstituteEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShotEntity",
                table: "ShotEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PenaltyEntity",
                table: "PenaltyEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PassEntity",
                table: "PassEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeagueEntity",
                table: "LeagueEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameEntity",
                table: "GameEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoulEntity",
                table: "FoulEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DuelEntity",
                table: "DuelEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DribbleEntity",
                table: "DribbleEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardEntity",
                table: "CardEntity");

            migrationBuilder.RenameTable(
                name: "TeamEntity",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "TackleEntity",
                newName: "Tackles");

            migrationBuilder.RenameTable(
                name: "SubstituteEntity",
                newName: "Substitutes");

            migrationBuilder.RenameTable(
                name: "ShotEntity",
                newName: "Shots");

            migrationBuilder.RenameTable(
                name: "PenaltyEntity",
                newName: "Penalties");

            migrationBuilder.RenameTable(
                name: "PassEntity",
                newName: "Passes");

            migrationBuilder.RenameTable(
                name: "LeagueEntity",
                newName: "Leagues");

            migrationBuilder.RenameTable(
                name: "GameEntity",
                newName: "Games");

            migrationBuilder.RenameTable(
                name: "FoulEntity",
                newName: "Fouls");

            migrationBuilder.RenameTable(
                name: "DuelEntity",
                newName: "Duels");

            migrationBuilder.RenameTable(
                name: "DribbleEntity",
                newName: "Dribbles");

            migrationBuilder.RenameTable(
                name: "CardEntity",
                newName: "Cards");

            migrationBuilder.RenameColumn(
                name: "BirtDate",
                table: "Players",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Statistics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GoalId",
                table: "Statistics",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Statistics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Players",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Players",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Teams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Teams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tackles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tackles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Substitutes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Substitutes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Shots",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Shots",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Penalties",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Penalties",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Passes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Passes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Leagues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Leagues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Games",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Games",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Fouls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Fouls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Duels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Duels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Dribbles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Dribbles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tackles",
                table: "Tackles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Substitutes",
                table: "Substitutes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shots",
                table: "Shots",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Penalties",
                table: "Penalties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passes",
                table: "Passes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fouls",
                table: "Fouls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Duels",
                table: "Duels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dribbles",
                table: "Dribbles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Conceded = table.Column<int>(type: "int", nullable: true),
                    Assists = table.Column<int>(type: "int", nullable: true),
                    Saves = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CreatedAt", "Red", "UpdatedAt", "Yellow", "YellowRed" },
                values: new object[] { new Guid("ea5ca0af-3572-46ee-b072-e2bd810ce063"), null, 0, null, 0, 0 });

            migrationBuilder.InsertData(
                table: "Dribbles",
                columns: new[] { "Id", "Attempts", "CreatedAt", "Past", "Success", "UpdatedAt" },
                values: new object[] { new Guid("dba1c8b0-fcb6-4ed5-bf05-21fd19ac1dce"), 2, null, 0, null, null });

            migrationBuilder.InsertData(
                table: "Duels",
                columns: new[] { "Id", "CreatedAt", "SuccessRate", "Total", "UpdatedAt", "Won" },
                values: new object[] { new Guid("4cfbb30e-b962-4f3a-ab3a-8c4d4c363cd3"), null, null, 18, null, 8 });

            migrationBuilder.InsertData(
                table: "Fouls",
                columns: new[] { "Id", "Committed", "CreatedAt", "Drawn", "UpdatedAt" },
                values: new object[] { new Guid("4d865701-efb7-40ba-88fc-a289e16be2a5"), 0, null, 4, null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Appearences", "Captain", "CreatedAt", "Lineups", "Minutes", "Number", "Position", "Rating", "UpdatedAt" },
                values: new object[] { new Guid("6c01bbd2-d4d2-4510-a423-6d1e4f355ca4"), 3, false, null, 3, 267, 0, "Attacker", "7.25", null });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Assists", "Conceded", "CreatedAt", "Saves", "Total", "UpdatedAt" },
                values: new object[] { new Guid("ff1c0892-e04c-4e52-8989-270f352878a7"), 0, 0, null, 0, 2, null });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "CreatedAt", "FlagUrl", "LogoUrl", "Name", "Season", "UpdatedAt" },
                values: new object[] { "203", "Turkey", null, "https://media.api-sports.io/football/flags/203.png", "https://media.api-sports.io/football/leagues/203.png", "Super Lig", 2023, null });

            migrationBuilder.InsertData(
                table: "Passes",
                columns: new[] { "Id", "Accuracy", "CreatedAt", "Key", "Total", "UpdatedAt" },
                values: new object[] { new Guid("baafd71c-4c79-4335-bb99-69f655642a16"), 12, null, 2, 39, null });

            migrationBuilder.InsertData(
                table: "Penalties",
                columns: new[] { "Id", "Committed", "CreatedAt", "Missed", "Saved", "Scored", "UpdatedAt", "Won" },
                values: new object[] { new Guid("21ecad01-d0fb-42f4-8b8b-f3d1d5ecc7c7"), 0, null, 0, 0, 0, null, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "386",
                columns: new[] { "BirthDate", "CreatedAt" },
                values: new object[] { new DateTime(1992, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Shots",
                columns: new[] { "Id", "CreatedAt", "On", "Total", "UpdatedAt" },
                values: new object[] { new Guid("7c80abe8-1f70-4e2a-87a8-905620585f13"), null, null, 7, null });

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: new Guid("c76344af-1844-4b71-8395-e3b57a12bbae"),
                columns: new[] { "CardId", "CreatedAt", "DribbleId", "DuelId", "FoulId", "GameId", "GoalId", "LeagueId", "PassId", "PenaltyId", "PlayerId", "ShotId", "TackleId", "TeamId", "UpdatedAt" },
                values: new object[] { new Guid("ea5ca0af-3572-46ee-b072-e2bd810ce063"), null, new Guid("dba1c8b0-fcb6-4ed5-bf05-21fd19ac1dce"), new Guid("4cfbb30e-b962-4f3a-ab3a-8c4d4c363cd3"), new Guid("4d865701-efb7-40ba-88fc-a289e16be2a5"), new Guid("6c01bbd2-d4d2-4510-a423-6d1e4f355ca4"), new Guid("ff1c0892-e04c-4e52-8989-270f352878a7"), "203", new Guid("baafd71c-4c79-4335-bb99-69f655642a16"), new Guid("21ecad01-d0fb-42f4-8b8b-f3d1d5ecc7c7"), "386", new Guid("7c80abe8-1f70-4e2a-87a8-905620585f13"), new Guid("bb13b436-ad97-4c87-b7d0-627f44c34949"), "549", null });

            migrationBuilder.InsertData(
                table: "Substitutes",
                columns: new[] { "Id", "Bench", "CreatedAt", "In", "Out", "UpdatedAt" },
                values: new object[] { new Guid("0fd92bff-aec8-46e5-a734-a0a46fbd7e5a"), 2, null, 1, 2, null });

            migrationBuilder.InsertData(
                table: "Tackles",
                columns: new[] { "Id", "Blocks", "CreatedAt", "Interceptions", "Total", "UpdatedAt" },
                values: new object[] { new Guid("bb13b436-ad97-4c87-b7d0-627f44c34949"), 1, null, 0, 0, null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "LogoUrl", "Name", "UpdatedAt" },
                values: new object[] { "549", null, "https://media.api-sports.io/football/teams/549.png", "Besiktas", null });

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_GoalId",
                table: "Statistics",
                column: "GoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Cards_CardId",
                table: "Statistics",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Dribbles_DribbleId",
                table: "Statistics",
                column: "DribbleId",
                principalTable: "Dribbles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Duels_DuelId",
                table: "Statistics",
                column: "DuelId",
                principalTable: "Duels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Fouls_FoulId",
                table: "Statistics",
                column: "FoulId",
                principalTable: "Fouls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Games_GameId",
                table: "Statistics",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Goals_GoalId",
                table: "Statistics",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Leagues_LeagueId",
                table: "Statistics",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Passes_PassId",
                table: "Statistics",
                column: "PassId",
                principalTable: "Passes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Penalties_PenaltyId",
                table: "Statistics",
                column: "PenaltyId",
                principalTable: "Penalties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Shots_ShotId",
                table: "Statistics",
                column: "ShotId",
                principalTable: "Shots",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Substitutes_SubstitueId",
                table: "Statistics",
                column: "SubstitueId",
                principalTable: "Substitutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Tackles_TackleId",
                table: "Statistics",
                column: "TackleId",
                principalTable: "Tackles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Teams_TeamId",
                table: "Statistics",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Cards_CardId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Dribbles_DribbleId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Duels_DuelId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Fouls_FoulId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Games_GameId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Goals_GoalId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Leagues_LeagueId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Passes_PassId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Penalties_PenaltyId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Shots_ShotId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Substitutes_SubstitueId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Tackles_TackleId",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Teams_TeamId",
                table: "Statistics");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Statistics_GoalId",
                table: "Statistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tackles",
                table: "Tackles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Substitutes",
                table: "Substitutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shots",
                table: "Shots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Penalties",
                table: "Penalties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passes",
                table: "Passes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fouls",
                table: "Fouls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Duels",
                table: "Duels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dribbles",
                table: "Dribbles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ea5ca0af-3572-46ee-b072-e2bd810ce063"));

            migrationBuilder.DeleteData(
                table: "Dribbles",
                keyColumn: "Id",
                keyValue: new Guid("dba1c8b0-fcb6-4ed5-bf05-21fd19ac1dce"));

            migrationBuilder.DeleteData(
                table: "Duels",
                keyColumn: "Id",
                keyValue: new Guid("4cfbb30e-b962-4f3a-ab3a-8c4d4c363cd3"));

            migrationBuilder.DeleteData(
                table: "Fouls",
                keyColumn: "Id",
                keyValue: new Guid("4d865701-efb7-40ba-88fc-a289e16be2a5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6c01bbd2-d4d2-4510-a423-6d1e4f355ca4"));

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "203");

            migrationBuilder.DeleteData(
                table: "Passes",
                keyColumn: "Id",
                keyValue: new Guid("baafd71c-4c79-4335-bb99-69f655642a16"));

            migrationBuilder.DeleteData(
                table: "Penalties",
                keyColumn: "Id",
                keyValue: new Guid("21ecad01-d0fb-42f4-8b8b-f3d1d5ecc7c7"));

            migrationBuilder.DeleteData(
                table: "Shots",
                keyColumn: "Id",
                keyValue: new Guid("7c80abe8-1f70-4e2a-87a8-905620585f13"));

            migrationBuilder.DeleteData(
                table: "Substitutes",
                keyColumn: "Id",
                keyValue: new Guid("0fd92bff-aec8-46e5-a734-a0a46fbd7e5a"));

            migrationBuilder.DeleteData(
                table: "Tackles",
                keyColumn: "Id",
                keyValue: new Guid("bb13b436-ad97-4c87-b7d0-627f44c34949"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "549");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tackles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Tackles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Substitutes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Substitutes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Shots");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Shots");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Penalties");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Penalties");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Passes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Passes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Leagues");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Leagues");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Fouls");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Fouls");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Duels");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Duels");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Dribbles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Dribbles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "TeamEntity");

            migrationBuilder.RenameTable(
                name: "Tackles",
                newName: "TackleEntity");

            migrationBuilder.RenameTable(
                name: "Substitutes",
                newName: "SubstituteEntity");

            migrationBuilder.RenameTable(
                name: "Shots",
                newName: "ShotEntity");

            migrationBuilder.RenameTable(
                name: "Penalties",
                newName: "PenaltyEntity");

            migrationBuilder.RenameTable(
                name: "Passes",
                newName: "PassEntity");

            migrationBuilder.RenameTable(
                name: "Leagues",
                newName: "LeagueEntity");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "GameEntity");

            migrationBuilder.RenameTable(
                name: "Fouls",
                newName: "FoulEntity");

            migrationBuilder.RenameTable(
                name: "Duels",
                newName: "DuelEntity");

            migrationBuilder.RenameTable(
                name: "Dribbles",
                newName: "DribbleEntity");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "CardEntity");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Players",
                newName: "BirtDate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamEntity",
                table: "TeamEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TackleEntity",
                table: "TackleEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubstituteEntity",
                table: "SubstituteEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShotEntity",
                table: "ShotEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PenaltyEntity",
                table: "PenaltyEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PassEntity",
                table: "PassEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeagueEntity",
                table: "LeagueEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameEntity",
                table: "GameEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoulEntity",
                table: "FoulEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DuelEntity",
                table: "DuelEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DribbleEntity",
                table: "DribbleEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardEntity",
                table: "CardEntity",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: new Guid("c76344af-1844-4b71-8395-e3b57a12bbae"),
                columns: new[] { "CardId", "DribbleId", "DuelId", "FoulId", "GameId", "LeagueId", "PassId", "PenaltyId", "PlayerId", "ShotId", "TackleId", "TeamId" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_CardEntity_CardId",
                table: "Statistics",
                column: "CardId",
                principalTable: "CardEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_DribbleEntity_DribbleId",
                table: "Statistics",
                column: "DribbleId",
                principalTable: "DribbleEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_DuelEntity_DuelId",
                table: "Statistics",
                column: "DuelId",
                principalTable: "DuelEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_FoulEntity_FoulId",
                table: "Statistics",
                column: "FoulId",
                principalTable: "FoulEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_GameEntity_GameId",
                table: "Statistics",
                column: "GameId",
                principalTable: "GameEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_LeagueEntity_LeagueId",
                table: "Statistics",
                column: "LeagueId",
                principalTable: "LeagueEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_PassEntity_PassId",
                table: "Statistics",
                column: "PassId",
                principalTable: "PassEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_PenaltyEntity_PenaltyId",
                table: "Statistics",
                column: "PenaltyId",
                principalTable: "PenaltyEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_ShotEntity_ShotId",
                table: "Statistics",
                column: "ShotId",
                principalTable: "ShotEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_SubstituteEntity_SubstitueId",
                table: "Statistics",
                column: "SubstitueId",
                principalTable: "SubstituteEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_TackleEntity_TackleId",
                table: "Statistics",
                column: "TackleId",
                principalTable: "TackleEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_TeamEntity_TeamId",
                table: "Statistics",
                column: "TeamId",
                principalTable: "TeamEntity",
                principalColumn: "Id");
        }
    }
}

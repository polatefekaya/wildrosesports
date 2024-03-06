using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsApp.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Yellow = table.Column<int>(type: "int", nullable: true),
                    YellowRed = table.Column<int>(type: "int", nullable: true),
                    Red = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DribbleEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Attempts = table.Column<int>(type: "int", nullable: true),
                    Success = table.Column<int>(type: "int", nullable: true),
                    Past = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DribbleEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DuelEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Won = table.Column<int>(type: "int", nullable: true),
                    SuccessRate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuelEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoulEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Drawn = table.Column<int>(type: "int", nullable: true),
                    Committed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoulEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Appearences = table.Column<int>(type: "int", nullable: true),
                    Lineups = table.Column<int>(type: "int", nullable: true),
                    Minutes = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Captain = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeagueEntity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Season = table.Column<int>(type: "int", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FlagUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Key = table.Column<int>(type: "int", nullable: true),
                    Accuracy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PenaltyEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Won = table.Column<int>(type: "int", nullable: true),
                    Committed = table.Column<int>(type: "int", nullable: true),
                    Scored = table.Column<int>(type: "int", nullable: true),
                    Missed = table.Column<int>(type: "int", nullable: true),
                    Saved = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Height = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Injured = table.Column<bool>(type: "bit", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BirtDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    BirthCountry = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShotEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: true),
                    On = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShotEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubstituteEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    In = table.Column<int>(type: "int", nullable: true),
                    Out = table.Column<int>(type: "int", nullable: true),
                    Bench = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstituteEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TackleEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Blocks = table.Column<int>(type: "int", nullable: true),
                    Interceptions = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TackleEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamEntity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LeagueId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubstitueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShotId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TackleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DuelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DribbleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoulId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PenaltyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistics_CardEntity_CardId",
                        column: x => x.CardId,
                        principalTable: "CardEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_DribbleEntity_DribbleId",
                        column: x => x.DribbleId,
                        principalTable: "DribbleEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_DuelEntity_DuelId",
                        column: x => x.DuelId,
                        principalTable: "DuelEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_FoulEntity_FoulId",
                        column: x => x.FoulId,
                        principalTable: "FoulEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_GameEntity_GameId",
                        column: x => x.GameId,
                        principalTable: "GameEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_LeagueEntity_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "LeagueEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_PassEntity_PassId",
                        column: x => x.PassId,
                        principalTable: "PassEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_PenaltyEntity_PenaltyId",
                        column: x => x.PenaltyId,
                        principalTable: "PenaltyEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_ShotEntity_ShotId",
                        column: x => x.ShotId,
                        principalTable: "ShotEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_SubstituteEntity_SubstitueId",
                        column: x => x.SubstitueId,
                        principalTable: "SubstituteEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_TackleEntity_TackleId",
                        column: x => x.TackleId,
                        principalTable: "TackleEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statistics_TeamEntity_TeamId",
                        column: x => x.TeamId,
                        principalTable: "TeamEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "BirtDate", "BirthCountry", "BirthPlace", "FirstName", "Height", "Injured", "LastName", "Nationality", "PhotoUrl", "Weight" },
                values: new object[] { "386", 32, null, "Cameroon", "Some Place", "Vincent", "184 cm", false, "Aboubakar", "Cameroon", "https://media.api-sports.io/football/players/386.png", "75 kg" });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "CardId", "DribbleId", "DuelId", "FoulId", "GameId", "LeagueId", "PassId", "PenaltyId", "PlayerId", "ShotId", "SubstitueId", "TackleId", "TeamId" },
                values: new object[] { new Guid("c76344af-1844-4b71-8395-e3b57a12bbae"), null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_CardId",
                table: "Statistics",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_DribbleId",
                table: "Statistics",
                column: "DribbleId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_DuelId",
                table: "Statistics",
                column: "DuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_FoulId",
                table: "Statistics",
                column: "FoulId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_GameId",
                table: "Statistics",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_LeagueId",
                table: "Statistics",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_PassId",
                table: "Statistics",
                column: "PassId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_PenaltyId",
                table: "Statistics",
                column: "PenaltyId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_PlayerId",
                table: "Statistics",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_ShotId",
                table: "Statistics",
                column: "ShotId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_SubstitueId",
                table: "Statistics",
                column: "SubstitueId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_TackleId",
                table: "Statistics",
                column: "TackleId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_TeamId",
                table: "Statistics",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "CardEntity");

            migrationBuilder.DropTable(
                name: "DribbleEntity");

            migrationBuilder.DropTable(
                name: "DuelEntity");

            migrationBuilder.DropTable(
                name: "FoulEntity");

            migrationBuilder.DropTable(
                name: "GameEntity");

            migrationBuilder.DropTable(
                name: "LeagueEntity");

            migrationBuilder.DropTable(
                name: "PassEntity");

            migrationBuilder.DropTable(
                name: "PenaltyEntity");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "ShotEntity");

            migrationBuilder.DropTable(
                name: "SubstituteEntity");

            migrationBuilder.DropTable(
                name: "TackleEntity");

            migrationBuilder.DropTable(
                name: "TeamEntity");
        }
    }
}

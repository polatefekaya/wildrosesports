﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsApp.Infrastructure.DbContext;

#nullable disable

namespace SportsApp.Infrastructure.Migrations
{
    [DbContext(typeof(PlayerDbContext))]
    [Migration("20240303011258_UpdateTables")]
    partial class UpdateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.CardEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Red")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Yellow")
                        .HasColumnType("int");

                    b.Property<int?>("YellowRed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea5ca0af-3572-46ee-b072-e2bd810ce063"),
                            Red = 0,
                            Yellow = 0,
                            YellowRed = 0
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.DribbleEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Attempts")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Past")
                        .HasColumnType("int");

                    b.Property<int?>("Success")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Dribbles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("dba1c8b0-fcb6-4ed5-bf05-21fd19ac1dce"),
                            Attempts = 2,
                            Past = 0
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.DuelEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SuccessRate")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Won")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Duels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4cfbb30e-b962-4f3a-ab3a-8c4d4c363cd3"),
                            Total = 18,
                            Won = 8
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.FoulEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Committed")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Drawn")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Fouls", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4d865701-efb7-40ba-88fc-a289e16be2a5"),
                            Committed = 0,
                            Drawn = 4
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.GameEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Appearences")
                        .HasColumnType("int");

                    b.Property<bool?>("Captain")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Lineups")
                        .HasColumnType("int");

                    b.Property<int?>("Minutes")
                        .HasColumnType("int");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Rating")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Games", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c01bbd2-d4d2-4510-a423-6d1e4f355ca4"),
                            Appearences = 3,
                            Captain = false,
                            Lineups = 3,
                            Minutes = 267,
                            Number = 0,
                            Position = "Attacker",
                            Rating = "7.25"
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.GoalEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Assists")
                        .HasColumnType("int");

                    b.Property<int?>("Conceded")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Saves")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Goals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ff1c0892-e04c-4e52-8989-270f352878a7"),
                            Assists = 0,
                            Conceded = 0,
                            Saves = 0,
                            Total = 2
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.LeagueEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlagUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("Season")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Leagues", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "203",
                            Country = "Turkey",
                            FlagUrl = "https://media.api-sports.io/football/flags/203.png",
                            LogoUrl = "https://media.api-sports.io/football/leagues/203.png",
                            Name = "Super Lig",
                            Season = 2023
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.PassEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Accuracy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Key")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Passes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("baafd71c-4c79-4335-bb99-69f655642a16"),
                            Accuracy = 12,
                            Key = 2,
                            Total = 39
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.PenaltyEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Committed")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Missed")
                        .HasColumnType("int");

                    b.Property<int?>("Saved")
                        .HasColumnType("int");

                    b.Property<int?>("Scored")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Won")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Penalties", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("21ecad01-d0fb-42f4-8b8b-f3d1d5ecc7c7"),
                            Committed = 0,
                            Missed = 0,
                            Saved = 0,
                            Scored = 0,
                            Won = 0
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.PlayerEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BirthCountry")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Height")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool?>("Injured")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhotoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Weight")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Players", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "386",
                            Age = 32,
                            BirthCountry = "Cameroon",
                            BirthDate = new DateTime(1992, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthPlace = "Some Place",
                            FirstName = "Vincent",
                            Height = "184 cm",
                            Injured = false,
                            LastName = "Aboubakar",
                            Nationality = "Cameroon",
                            PhotoUrl = "https://media.api-sports.io/football/players/386.png",
                            Weight = "75 kg"
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.ShotEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("On")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Shots", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c80abe8-1f70-4e2a-87a8-905620585f13"),
                            Total = 7
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.StatisticEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DribbleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DuelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FoulId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GoalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LeagueId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("PassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PenaltyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PlayerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ShotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubstitueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TackleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DribbleId");

                    b.HasIndex("DuelId");

                    b.HasIndex("FoulId");

                    b.HasIndex("GameId");

                    b.HasIndex("GoalId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("PassId");

                    b.HasIndex("PenaltyId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ShotId");

                    b.HasIndex("SubstitueId");

                    b.HasIndex("TackleId");

                    b.HasIndex("TeamId");

                    b.ToTable("Statistics", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c76344af-1844-4b71-8395-e3b57a12bbae"),
                            CardId = new Guid("ea5ca0af-3572-46ee-b072-e2bd810ce063"),
                            DribbleId = new Guid("dba1c8b0-fcb6-4ed5-bf05-21fd19ac1dce"),
                            DuelId = new Guid("4cfbb30e-b962-4f3a-ab3a-8c4d4c363cd3"),
                            FoulId = new Guid("4d865701-efb7-40ba-88fc-a289e16be2a5"),
                            GameId = new Guid("6c01bbd2-d4d2-4510-a423-6d1e4f355ca4"),
                            GoalId = new Guid("ff1c0892-e04c-4e52-8989-270f352878a7"),
                            LeagueId = "203",
                            PassId = new Guid("baafd71c-4c79-4335-bb99-69f655642a16"),
                            PenaltyId = new Guid("21ecad01-d0fb-42f4-8b8b-f3d1d5ecc7c7"),
                            PlayerId = "386",
                            ShotId = new Guid("7c80abe8-1f70-4e2a-87a8-905620585f13"),
                            TackleId = new Guid("bb13b436-ad97-4c87-b7d0-627f44c34949"),
                            TeamId = "549"
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.SubstituteEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Bench")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("In")
                        .HasColumnType("int");

                    b.Property<int?>("Out")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Substitutes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0fd92bff-aec8-46e5-a734-a0a46fbd7e5a"),
                            Bench = 2,
                            In = 1,
                            Out = 2
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.TackleEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Blocks")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Interceptions")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tackles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb13b436-ad97-4c87-b7d0-627f44c34949"),
                            Blocks = 1,
                            Interceptions = 0,
                            Total = 0
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.TeamEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teams", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "549",
                            LogoUrl = "https://media.api-sports.io/football/teams/549.png",
                            Name = "Besiktas"
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.StatisticEntity", b =>
                {
                    b.HasOne("SportsApp.Infrastructure.Data.Player.CardEntity", "Card")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.DribbleEntity", "Dribble")
                        .WithMany()
                        .HasForeignKey("DribbleId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.DuelEntity", "Duel")
                        .WithMany()
                        .HasForeignKey("DuelId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.FoulEntity", "Foul")
                        .WithMany()
                        .HasForeignKey("FoulId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.GameEntity", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.GoalEntity", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.LeagueEntity", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.PassEntity", "Pass")
                        .WithMany()
                        .HasForeignKey("PassId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.PenaltyEntity", "Penalty")
                        .WithMany()
                        .HasForeignKey("PenaltyId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.PlayerEntity", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.ShotEntity", "Shot")
                        .WithMany()
                        .HasForeignKey("ShotId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.SubstituteEntity", "Substitute")
                        .WithMany()
                        .HasForeignKey("SubstitueId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.TackleEntity", "Tackle")
                        .WithMany()
                        .HasForeignKey("TackleId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.TeamEntity", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Card");

                    b.Navigation("Dribble");

                    b.Navigation("Duel");

                    b.Navigation("Foul");

                    b.Navigation("Game");

                    b.Navigation("Goal");

                    b.Navigation("League");

                    b.Navigation("Pass");

                    b.Navigation("Penalty");

                    b.Navigation("Player");

                    b.Navigation("Shot");

                    b.Navigation("Substitute");

                    b.Navigation("Tackle");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
